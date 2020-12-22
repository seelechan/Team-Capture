//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.1.0
//     from Assets/Settings/Input/GameInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Team_Capture
{
    public partial class @GameInput : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @GameInput()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInput"",
    ""maps"": [
        {
            ""name"": ""Console"",
            ""id"": ""f3429d8d-a20d-46da-8941-3d1f3b19159d"",
            ""actions"": [
                {
                    ""name"": ""ToggleConsole"",
                    ""type"": ""Button"",
                    ""id"": ""81d8bfb3-06a9-484a-841b-9598944a1ecd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""AutoComplete"",
                    ""type"": ""Button"",
                    ""id"": ""f172c47a-cba5-4b1c-b153-c802d6978817"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HistoryUp"",
                    ""type"": ""Button"",
                    ""id"": ""d8d6bf72-842e-4440-b42a-10610510fad6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HistoryDown"",
                    ""type"": ""Button"",
                    ""id"": ""c798c230-b894-4124-9324-c637d5e4c894"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SubmitInput"",
                    ""type"": ""Button"",
                    ""id"": ""7ed22b2a-26cf-4580-bb4a-8ccfeb3e83ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3261766d-74ae-421f-be12-f893cc2ae8ed"",
                    ""path"": ""<Keyboard>/backquote"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""ToggleConsole"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d33f864-3bad-4e60-908d-6a60dea8dc1f"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""AutoComplete"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d15723b0-8349-4dc5-bb63-97be50dea492"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""HistoryUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2544f27d-8483-45f7-b4ae-dd29db35de1f"",
                    ""path"": ""<Keyboard>/pageUp"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""HistoryUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2c5c4fab-3aeb-4850-a214-4e1778acc549"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""HistoryDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3960e645-6fbe-4e4c-b945-e5774dce1620"",
                    ""path"": ""<Keyboard>/pageDown"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""HistoryDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba755523-c1bf-449a-90bb-aad0fb5700a3"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""SubmitInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d4092c7c-f047-4334-82b1-0f77701e7484"",
                    ""path"": ""<Keyboard>/numpadEnter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""SubmitInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MenuController"",
            ""id"": ""94878f43-56d2-4d25-8782-ef6ec623286e"",
            ""actions"": [
                {
                    ""name"": ""Close"",
                    ""type"": ""Button"",
                    ""id"": ""44234032-4fd7-4286-b535-117fdff0b435"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e0a2f3bd-8315-43f1-829e-5d3aa5a77adb"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Close"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""StartVideo"",
            ""id"": ""df7b0a06-e16a-4698-9061-0eea7267b829"",
            ""actions"": [
                {
                    ""name"": ""Skip"",
                    ""type"": ""Button"",
                    ""id"": ""185fe5c5-0670-418d-a606-5a318b4f0e90"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""67fa4ab2-92c0-401d-8bfd-bb7b4d44b290"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Skip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player"",
            ""id"": ""b89642bb-b069-4676-83b4-13d73f3c5e0e"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""1f4c7b6f-6cf9-47bb-983f-df5e9759019b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""f944ac8c-c24a-4713-bea7-0a4fb3a734c3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""ScaleVector2(x=0.5,y=0.5)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ScoreBoard"",
                    ""type"": ""Button"",
                    ""id"": ""4d2b60cd-4942-4793-a050-0566a553ee22"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Suicide"",
                    ""type"": ""Button"",
                    ""id"": ""ee0ff9a6-6394-4556-bebb-1d8194490890"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""fc490ca0-1fb5-4fb9-93e5-277f5e819682"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""a4954379-46da-4348-8f4c-3f87fc09e49d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""WeaponSelection"",
                    ""type"": ""Value"",
                    ""id"": ""75e6bbb3-9a28-4b13-a87a-9dc96932b16e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""e0868325-2507-4719-9a91-6b6340aa1ae0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""817b007a-bea4-4b74-91fe-6df681621973"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2f0a6348-92f5-4c3b-96c3-4c0bc199dd3a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8e126bf7-12b7-4a0d-85f4-b820c1cd5466"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a0f59049-bc2c-4c71-942d-9bd62f5e81de"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""251fd00f-0cee-4e37-84f2-85c7ca5c43e7"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b774095-6274-41a4-8044-108abfa35742"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""ScoreBoard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4be1904a-5c3a-46d3-b1c9-b96fb6635215"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Suicide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d52655ad-ce66-4639-b662-66d6ca312418"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""89111bc2-d9ba-46c0-a797-ed7dbf863d3c"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""872aef05-ccf2-40e0-99a3-ad826420a473"",
                    ""path"": ""<Mouse>/scroll/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""WeaponSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""41ec4b0f-6c3b-42e7-af7e-44d219fc39b7"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""WeaponSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardMouse"",
            ""bindingGroup"": ""KeyboardMouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Console
            m_Console = asset.FindActionMap("Console", throwIfNotFound: true);
            m_Console_ToggleConsole = m_Console.FindAction("ToggleConsole", throwIfNotFound: true);
            m_Console_AutoComplete = m_Console.FindAction("AutoComplete", throwIfNotFound: true);
            m_Console_HistoryUp = m_Console.FindAction("HistoryUp", throwIfNotFound: true);
            m_Console_HistoryDown = m_Console.FindAction("HistoryDown", throwIfNotFound: true);
            m_Console_SubmitInput = m_Console.FindAction("SubmitInput", throwIfNotFound: true);
            // MenuController
            m_MenuController = asset.FindActionMap("MenuController", throwIfNotFound: true);
            m_MenuController_Close = m_MenuController.FindAction("Close", throwIfNotFound: true);
            // StartVideo
            m_StartVideo = asset.FindActionMap("StartVideo", throwIfNotFound: true);
            m_StartVideo_Skip = m_StartVideo.FindAction("Skip", throwIfNotFound: true);
            // Player
            m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
            m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
            m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
            m_Player_ScoreBoard = m_Player.FindAction("ScoreBoard", throwIfNotFound: true);
            m_Player_Suicide = m_Player.FindAction("Suicide", throwIfNotFound: true);
            m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
            m_Player_Pause = m_Player.FindAction("Pause", throwIfNotFound: true);
            m_Player_WeaponSelection = m_Player.FindAction("WeaponSelection", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }
        public IEnumerable<InputBinding> bindings => asset.bindings;

        public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return asset.FindAction(actionNameOrId, throwIfNotFound);
        }
        public int FindBinding(InputBinding bindingMask, out InputAction action)
        {
            return asset.FindBinding(bindingMask, out action);
        }

        // Console
        private readonly InputActionMap m_Console;
        private IConsoleActions m_ConsoleActionsCallbackInterface;
        private readonly InputAction m_Console_ToggleConsole;
        private readonly InputAction m_Console_AutoComplete;
        private readonly InputAction m_Console_HistoryUp;
        private readonly InputAction m_Console_HistoryDown;
        private readonly InputAction m_Console_SubmitInput;
        public struct ConsoleActions
        {
            private @GameInput m_Wrapper;
            public ConsoleActions(@GameInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @ToggleConsole => m_Wrapper.m_Console_ToggleConsole;
            public InputAction @AutoComplete => m_Wrapper.m_Console_AutoComplete;
            public InputAction @HistoryUp => m_Wrapper.m_Console_HistoryUp;
            public InputAction @HistoryDown => m_Wrapper.m_Console_HistoryDown;
            public InputAction @SubmitInput => m_Wrapper.m_Console_SubmitInput;
            public InputActionMap Get() { return m_Wrapper.m_Console; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(ConsoleActions set) { return set.Get(); }
            public void SetCallbacks(IConsoleActions instance)
            {
                if (m_Wrapper.m_ConsoleActionsCallbackInterface != null)
                {
                    @ToggleConsole.started -= m_Wrapper.m_ConsoleActionsCallbackInterface.OnToggleConsole;
                    @ToggleConsole.performed -= m_Wrapper.m_ConsoleActionsCallbackInterface.OnToggleConsole;
                    @ToggleConsole.canceled -= m_Wrapper.m_ConsoleActionsCallbackInterface.OnToggleConsole;
                    @AutoComplete.started -= m_Wrapper.m_ConsoleActionsCallbackInterface.OnAutoComplete;
                    @AutoComplete.performed -= m_Wrapper.m_ConsoleActionsCallbackInterface.OnAutoComplete;
                    @AutoComplete.canceled -= m_Wrapper.m_ConsoleActionsCallbackInterface.OnAutoComplete;
                    @HistoryUp.started -= m_Wrapper.m_ConsoleActionsCallbackInterface.OnHistoryUp;
                    @HistoryUp.performed -= m_Wrapper.m_ConsoleActionsCallbackInterface.OnHistoryUp;
                    @HistoryUp.canceled -= m_Wrapper.m_ConsoleActionsCallbackInterface.OnHistoryUp;
                    @HistoryDown.started -= m_Wrapper.m_ConsoleActionsCallbackInterface.OnHistoryDown;
                    @HistoryDown.performed -= m_Wrapper.m_ConsoleActionsCallbackInterface.OnHistoryDown;
                    @HistoryDown.canceled -= m_Wrapper.m_ConsoleActionsCallbackInterface.OnHistoryDown;
                    @SubmitInput.started -= m_Wrapper.m_ConsoleActionsCallbackInterface.OnSubmitInput;
                    @SubmitInput.performed -= m_Wrapper.m_ConsoleActionsCallbackInterface.OnSubmitInput;
                    @SubmitInput.canceled -= m_Wrapper.m_ConsoleActionsCallbackInterface.OnSubmitInput;
                }
                m_Wrapper.m_ConsoleActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @ToggleConsole.started += instance.OnToggleConsole;
                    @ToggleConsole.performed += instance.OnToggleConsole;
                    @ToggleConsole.canceled += instance.OnToggleConsole;
                    @AutoComplete.started += instance.OnAutoComplete;
                    @AutoComplete.performed += instance.OnAutoComplete;
                    @AutoComplete.canceled += instance.OnAutoComplete;
                    @HistoryUp.started += instance.OnHistoryUp;
                    @HistoryUp.performed += instance.OnHistoryUp;
                    @HistoryUp.canceled += instance.OnHistoryUp;
                    @HistoryDown.started += instance.OnHistoryDown;
                    @HistoryDown.performed += instance.OnHistoryDown;
                    @HistoryDown.canceled += instance.OnHistoryDown;
                    @SubmitInput.started += instance.OnSubmitInput;
                    @SubmitInput.performed += instance.OnSubmitInput;
                    @SubmitInput.canceled += instance.OnSubmitInput;
                }
            }
        }
        public ConsoleActions @Console => new ConsoleActions(this);

        // MenuController
        private readonly InputActionMap m_MenuController;
        private IMenuControllerActions m_MenuControllerActionsCallbackInterface;
        private readonly InputAction m_MenuController_Close;
        public struct MenuControllerActions
        {
            private @GameInput m_Wrapper;
            public MenuControllerActions(@GameInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @Close => m_Wrapper.m_MenuController_Close;
            public InputActionMap Get() { return m_Wrapper.m_MenuController; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MenuControllerActions set) { return set.Get(); }
            public void SetCallbacks(IMenuControllerActions instance)
            {
                if (m_Wrapper.m_MenuControllerActionsCallbackInterface != null)
                {
                    @Close.started -= m_Wrapper.m_MenuControllerActionsCallbackInterface.OnClose;
                    @Close.performed -= m_Wrapper.m_MenuControllerActionsCallbackInterface.OnClose;
                    @Close.canceled -= m_Wrapper.m_MenuControllerActionsCallbackInterface.OnClose;
                }
                m_Wrapper.m_MenuControllerActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Close.started += instance.OnClose;
                    @Close.performed += instance.OnClose;
                    @Close.canceled += instance.OnClose;
                }
            }
        }
        public MenuControllerActions @MenuController => new MenuControllerActions(this);

        // StartVideo
        private readonly InputActionMap m_StartVideo;
        private IStartVideoActions m_StartVideoActionsCallbackInterface;
        private readonly InputAction m_StartVideo_Skip;
        public struct StartVideoActions
        {
            private @GameInput m_Wrapper;
            public StartVideoActions(@GameInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @Skip => m_Wrapper.m_StartVideo_Skip;
            public InputActionMap Get() { return m_Wrapper.m_StartVideo; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(StartVideoActions set) { return set.Get(); }
            public void SetCallbacks(IStartVideoActions instance)
            {
                if (m_Wrapper.m_StartVideoActionsCallbackInterface != null)
                {
                    @Skip.started -= m_Wrapper.m_StartVideoActionsCallbackInterface.OnSkip;
                    @Skip.performed -= m_Wrapper.m_StartVideoActionsCallbackInterface.OnSkip;
                    @Skip.canceled -= m_Wrapper.m_StartVideoActionsCallbackInterface.OnSkip;
                }
                m_Wrapper.m_StartVideoActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Skip.started += instance.OnSkip;
                    @Skip.performed += instance.OnSkip;
                    @Skip.canceled += instance.OnSkip;
                }
            }
        }
        public StartVideoActions @StartVideo => new StartVideoActions(this);

        // Player
        private readonly InputActionMap m_Player;
        private IPlayerActions m_PlayerActionsCallbackInterface;
        private readonly InputAction m_Player_Move;
        private readonly InputAction m_Player_Look;
        private readonly InputAction m_Player_ScoreBoard;
        private readonly InputAction m_Player_Suicide;
        private readonly InputAction m_Player_Jump;
        private readonly InputAction m_Player_Pause;
        private readonly InputAction m_Player_WeaponSelection;
        public struct PlayerActions
        {
            private @GameInput m_Wrapper;
            public PlayerActions(@GameInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_Player_Move;
            public InputAction @Look => m_Wrapper.m_Player_Look;
            public InputAction @ScoreBoard => m_Wrapper.m_Player_ScoreBoard;
            public InputAction @Suicide => m_Wrapper.m_Player_Suicide;
            public InputAction @Jump => m_Wrapper.m_Player_Jump;
            public InputAction @Pause => m_Wrapper.m_Player_Pause;
            public InputAction @WeaponSelection => m_Wrapper.m_Player_WeaponSelection;
            public InputActionMap Get() { return m_Wrapper.m_Player; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerActions instance)
            {
                if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                    @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                    @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                    @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                    @ScoreBoard.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnScoreBoard;
                    @ScoreBoard.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnScoreBoard;
                    @ScoreBoard.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnScoreBoard;
                    @Suicide.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSuicide;
                    @Suicide.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSuicide;
                    @Suicide.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSuicide;
                    @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                    @Pause.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                    @Pause.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                    @Pause.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                    @WeaponSelection.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponSelection;
                    @WeaponSelection.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponSelection;
                    @WeaponSelection.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeaponSelection;
                }
                m_Wrapper.m_PlayerActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @Look.started += instance.OnLook;
                    @Look.performed += instance.OnLook;
                    @Look.canceled += instance.OnLook;
                    @ScoreBoard.started += instance.OnScoreBoard;
                    @ScoreBoard.performed += instance.OnScoreBoard;
                    @ScoreBoard.canceled += instance.OnScoreBoard;
                    @Suicide.started += instance.OnSuicide;
                    @Suicide.performed += instance.OnSuicide;
                    @Suicide.canceled += instance.OnSuicide;
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                    @Pause.started += instance.OnPause;
                    @Pause.performed += instance.OnPause;
                    @Pause.canceled += instance.OnPause;
                    @WeaponSelection.started += instance.OnWeaponSelection;
                    @WeaponSelection.performed += instance.OnWeaponSelection;
                    @WeaponSelection.canceled += instance.OnWeaponSelection;
                }
            }
        }
        public PlayerActions @Player => new PlayerActions(this);
        private int m_KeyboardMouseSchemeIndex = -1;
        public InputControlScheme KeyboardMouseScheme
        {
            get
            {
                if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("KeyboardMouse");
                return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
            }
        }
        public interface IConsoleActions
        {
            void OnToggleConsole(InputAction.CallbackContext context);
            void OnAutoComplete(InputAction.CallbackContext context);
            void OnHistoryUp(InputAction.CallbackContext context);
            void OnHistoryDown(InputAction.CallbackContext context);
            void OnSubmitInput(InputAction.CallbackContext context);
        }
        public interface IMenuControllerActions
        {
            void OnClose(InputAction.CallbackContext context);
        }
        public interface IStartVideoActions
        {
            void OnSkip(InputAction.CallbackContext context);
        }
        public interface IPlayerActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnLook(InputAction.CallbackContext context);
            void OnScoreBoard(InputAction.CallbackContext context);
            void OnSuicide(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
            void OnPause(InputAction.CallbackContext context);
            void OnWeaponSelection(InputAction.CallbackContext context);
        }
    }
}
