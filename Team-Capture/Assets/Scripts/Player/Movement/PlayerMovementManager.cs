using System;
using Console;
using Mirror;
using UnityEngine;

namespace Player.Movement
{
	//This code is built on unity-fastpacedmultiplayer
	//https://github.com/JoaoBorks/unity-fastpacedmultiplayer
	//
	//MIT License
	//Copyright (c) 2015 ultimatematchthree, 2017 Joao Borks [joao.borks@gmail.com]

	[RequireComponent(typeof(CharacterController))]
	[RequireComponent(typeof(PlayerManager))]
	public sealed class PlayerMovementManager : NetworkBehaviour
	{
		private PlayerManager playerManager;

		[SerializeField] private Transform groundCheck;
		[SerializeField] private float groundDistance = 0.7f;
		[SerializeField] private LayerMask groundMask;

		#region Movement Controls

		[Header("Movement Settings")]
		[SerializeField] private float moveSpeed = 11.0f;
		[SerializeField] private float jumpHeight = 3f;

		[SerializeField] private float gravityAmount = 9.81f;

		[SerializeField] private Transform cameraTransform;

		#endregion

		/// <summary>
		/// Delay for interpolation
		/// </summary>
		[Header("Network")]
		[Range(1, 60)]
		[Tooltip("Delay for interpolation")]
		public int interpolationDelay = 12;

		/// <summary>
		/// The rate for updating inputs
		/// </summary>
		[SerializeField]
		[Range(10, 50)]
		[Tooltip("The rate for updating inputs")]
		private int inputUpdateRate = 10;

		/// <summary>
		/// Controls how many inputs are needed before sending update command
		/// </summary>
		public int InputBufferSize { get; private set; }

		/// <summary>
		/// The current state of the player
		/// </summary>
		[NonSerialized]
		[SyncVar(hook = nameof(OnServerStateChange))]
		public PlayerState State = PlayerState.Zero;

		/// <summary>
		/// The state handler (Observer or predictor)
		/// </summary>
		private IPlayerMovementStateHandler stateHandler;

		/// <summary>
		/// The <see cref="PlayerMovementServer"/>, set if we are the server
		/// </summary>
		private PlayerMovementServer server;

		/// <summary>
		/// The <see cref="CharacterController"/>
		/// </summary>
		private CharacterController characterController;

		private void Awake()
		{
			InputBufferSize = (int)(1 / Time.fixedDeltaTime) / inputUpdateRate;
			playerManager = GetComponent<PlayerManager>();
		}

		private void OnGUI()
		{
			if(!ShowPos) return;

			GUI.skin.label.fontSize = 20;

			GUI.Box(new Rect(8, 10, 300, 90), "");

			GUI.Label(new Rect(10, 10, 1000, 40), $"Velocity: {characterController.velocity}");
			GUI.Label(new Rect(10, 30, 1000, 40), $"Position: {transform.position}");
			GUI.Label(new Rect(10, 50, 1000, 40), $"LookingAt: {cameraTransform.rotation}");
			GUI.Label(new Rect(10, 70, 1000, 40), $"IsGround: {Physics.Raycast(groundCheck.position, Vector3.down, groundDistance, groundMask)}");
		}

		public override void OnStartServer()
		{
			base.OnStartServer();
			server = gameObject.AddComponent<PlayerMovementServer>();
		}

		private void Start()
		{
			characterController = GetComponent<CharacterController>();
			if (!isLocalPlayer)
			{
				stateHandler = gameObject.AddComponent<PlayerMovementObserver>();
				return;
			}

			//Setup for local player
			GetComponentInChildren<Renderer>().material.color = Color.green;
			stateHandler = gameObject.AddComponent<PlayerMovementPredictor>();
			gameObject.AddComponent<PlayerMovementInput>();
		}

		public void SyncState(PlayerState overrideState)
		{
			if(playerManager.IsDead)
				return;

			characterController.Move(overrideState.Position - transform.position);

			transform.rotation = Quaternion.Euler(0, overrideState.RotationY, 0);
			cameraTransform.rotation = Quaternion.Euler(overrideState.RotationX, overrideState.RotationY, 0);
		}

		public void OnServerStateChange(PlayerState oldState, PlayerState newState)
		{
			State = newState;
			stateHandler?.OnStateChange(State);
		}

		[Command(channel = 0)]
		public void CmdMove(PlayerInputs[] inputs)
		{
			server.AddInputs(inputs);
		}

		/// <summary>
		/// Sets the player's position
		/// </summary>
		/// <param name="pos"></param>
		/// <param name="rotationX"></param>
		/// <param name="rotationY"></param>
		/// <param name="resetVelocity"></param>
		[Server]
		public void SetCharacterPosition(Vector3 pos, float rotationX, float rotationY, bool resetVelocity = false)
		{
			PlayerState newState = new PlayerState
			{
				Position = pos,
				RotationX = rotationX,
				RotationY = rotationY,
				Velocity = State.Velocity
			};

			if (resetVelocity)
				newState.Velocity = Vector3.zero;

			State = newState;
			OnServerStateChange(State, newState);

			TargetSetPosition(connectionToClient, State);
		}

		[TargetRpc]
		// ReSharper disable once UnusedParameter.Local
		private void TargetSetPosition(NetworkConnection conn, PlayerState newState)
		{
			transform.position = newState.Position;
			transform.rotation = Quaternion.Euler(0, newState.RotationY, 0);
			cameraTransform.rotation = Quaternion.Euler(newState.RotationX, newState.RotationY, 0);
		}

		#region Movement Methods

		public PlayerState Move(PlayerState previous, PlayerInputs input, int timestamp)
		{
			PlayerState playerState = new PlayerState
			{
				MoveNum = previous.MoveNum + 1,
				Timestamp = timestamp,
				Position = previous.Position,
				Velocity = previous.Velocity,
				RotationX = previous.RotationX,
				RotationY = previous.RotationY
			};

			bool isGrounded = Physics.Raycast(groundCheck.position, Vector3.down, groundDistance, groundMask);

			//Calculate velocity
			Vector3 inputs = new Vector3(input.Directions.x, 0f, input.Directions.y) * moveSpeed;
			playerState.Velocity = transform.TransformDirection(inputs);
			playerState.Velocity.y = previous.Velocity.y;

			//Gravity
			if(!isGrounded)
				playerState.Velocity.y -= gravityAmount * Time.deltaTime;
			else
				playerState.Velocity.y = -2f;

			//Jumping
			if (input.Jump && isGrounded)
				playerState.Velocity.y = jumpHeight;

			//Apply velocity to position
			playerState.Position += playerState.Velocity * Time.deltaTime;

			//Mouse Movement
			playerState.RotationX -= input.MouseDirections.y;
			playerState.RotationY += input.MouseDirections.x;

			playerState.RotationX = Mathf.Clamp(playerState.RotationX, -90, 90);

			return playerState;
		}

		#endregion

		#region Commands

		[ConVar("cl_showpos", "Shows the position and other stuff like that of the player", true)]
		public static bool ShowPos = false;

		#endregion
	}
}