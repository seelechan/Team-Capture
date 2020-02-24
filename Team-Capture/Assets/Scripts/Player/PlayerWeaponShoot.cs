﻿using Core;
using Mirror;
using UI;
using UnityEngine;
using Weapons;

namespace Player
{
	public class PlayerWeaponShoot : NetworkBehaviour
	{
		private PlayerManager playerManager;
		private WeaponManager weaponManager;

		[SerializeField] private string pickupTag = "Pickup";

		private void Start()
		{
			weaponManager = GetComponent<WeaponManager>();
			playerManager = GetComponent<PlayerManager>();
		}

		private void Update()
		{
			if (!isLocalPlayer)
				return;

			if (ClientUI.IsPauseMenuOpen)
				return;

			//Cache our current weapon
			TCWeapon weapon = GetCurrentWeapon();

			//Looks like the weapon isn't setup yet
			if (weapon == null)
				return;

			if (playerManager.IsDead)
			{
				CancelInvoke(nameof(ShootWeapon));
				return;
			}

			if (weapon.currentBulletsAmount < weapon.maxBullets && !weapon.isReloading)
				//Do a reload
				if (Input.GetButtonDown("Reload"))
				{
					CancelInvoke(nameof(ShootWeapon));
					weaponManager.StartCoroutine(weaponManager.ReloadCurrentWeapon());
					return;
				}

			//Semi-automatic weapons
			if (weapon.fireRate <= 0f)
			{
				//Only shoot if the player just pressed the button
				if (Input.GetButtonDown("Fire1") && !weapon.isReloading) ShootWeapon();
			}
			//Full auto weapons
			else
			{
				if (Input.GetButtonDown("Fire1") && !weapon.isReloading)
					InvokeRepeating(nameof(ShootWeapon), 0f, 1f / weapon.fireRate);
				else if (Input.GetButtonUp("Fire1")) CancelInvoke(nameof(ShootWeapon));
			}
		}

		[Client]
		private void ShootWeapon()
		{
			if (!isLocalPlayer)
				return;

			TCWeapon weapon = GetCurrentWeapon();

			if (weapon.currentBulletsAmount <= 0)
			{
				weaponManager.StartCoroutine(weaponManager.ReloadCurrentWeapon());
				playerManager.clientUi.hud.UpdateAmmoUi(weaponManager);
				return;
			}

			weapon.currentBulletsAmount--;

			//Do a muzzle flash
			CmdWeaponMuzzleFlash(transform.name);

			//Do the actual weapon shoot logic
			CmdWeaponShoot(transform.name);

			playerManager.clientUi.hud.UpdateAmmoUi(weaponManager);
		}

		[Command]
		private void CmdWeaponShoot(string sourcePlayer)
		{
			PlayerManager player = GameManager.GetPlayer(sourcePlayer);
			if (player == null) return;

			//SimulationHelper.SimulateCommand(player, () => CmdWeaponRayCast(sourcePlayer));
			WeaponRayCast(sourcePlayer);
		}

		[Server]
		private void WeaponRayCast(string sourcePlayer)
		{
			//First, get our player
			PlayerManager player = GameManager.GetPlayer(sourcePlayer);
			if (player == null) return;

			//Next, get what weapon the player was using
			TCWeapon tcWeapon = player.GetComponent<WeaponManager>().GetActiveWeapon();
			if (tcWeapon == null)
				return;

			//Get the direction the player was facing
			Transform playerFacingDirection = player.GetComponent<PlayerSetup>().GetPlayerCamera().transform;

			for (int i = 0; i < tcWeapon.bulletsAmount; i++)
			{
				//Calculate random spread
				Vector3 spread = Vector3.zero;
				spread += playerFacingDirection.up * Random.Range(tcWeapon.spreadMin, tcWeapon.spreadMax);
				spread += playerFacingDirection.right * Random.Range(tcWeapon.spreadMin, tcWeapon.spreadMax);

				Vector3 direction = playerFacingDirection.forward + spread.normalized * Random.Range(0f, 0.2f);

				//Was a player hit?
				bool playerHit = false;

				//Now do our raycast
				// ReSharper disable once Unity.PreferNonAllocApi
				RaycastHit[] hits = Physics.RaycastAll(playerFacingDirection.position, direction,
					tcWeapon.range);
				foreach (RaycastHit hit in hits)
				{
					//If a player was hit then skip through
					if(playerHit)
						continue;

					//If the hit was the sourcePlayer, then ignore it
					if (hit.collider.name == sourcePlayer)
						continue;

					//We want bullets to go through pickups
					if(hit.collider.CompareTag(pickupTag))
						continue;

					//Do impact effect on all clients
					RpcWeaponImpact(hit.point, hit.normal);

					//So if we hit a player then do damage
					if (hit.collider.GetComponent<PlayerManager>() == null) continue;
					hit.collider.GetComponent<PlayerManager>().TakeDamage(tcWeapon.damage, sourcePlayer);
					playerHit = true;
				}
			}
		}

		private TCWeapon GetCurrentWeapon()
		{
			return weaponManager.GetActiveWeapon();
		}

		#region Weapon Effects

		#region Weapon Muzzle

		[Command]
		private void CmdWeaponMuzzleFlash(string playerId)
		{
			RpcWeaponMuzzleFlash(playerId);
		}

		[ClientRpc]
		private void RpcWeaponMuzzleFlash(string playerId)
		{
			PlayerManager player = GameManager.GetPlayer(playerId);
			if (player == null) return;

			player.GetComponent<WeaponManager>().GetActiveWeaponGraphics().muzzleFlash.Play(true);
		}

		#endregion

		#region Weapon Impact

		[ClientRpc(channel = 2)]
		private void RpcWeaponImpact(Vector3 pos, Vector3 normal)
		{
			GameObject hitEffect =
				Instantiate(GameManager.GetActiveScene().weaponHit, pos, Quaternion.LookRotation(normal));
			Destroy(hitEffect, GameManager.GetActiveScene().hitObjectLastTime);
		}

		#endregion

		#endregion
	}
}