// GENERATED AUTOMATICALLY FROM 'Assets/Resources/Controls/DefaultControls.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class DefaultControls : IInputActionCollection
{
    private InputActionAsset asset;
    public DefaultControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DefaultControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""707c45f8-533b-467e-ab43-e9ce8ec94c97"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""eeb8acc9-a099-48d6-8d4b-070f64ce9880"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""a5a026b0-74e5-47a5-8e2d-5b716d8857c4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""InventoryScroll"",
                    ""type"": ""Button"",
                    ""id"": ""5f05ace5-da5c-4fe7-9350-7010d2abc7d7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""InventoryUse"",
                    ""type"": ""Button"",
                    ""id"": ""a8bfbd13-331c-475f-9c1d-e24eb14518b6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""13059c5a-b3c0-4f50-9193-c9ab1b0fd8ef"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""fdd9e688-8d82-4274-9111-5124a311b934"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""858f3992-0ff1-4ff8-a797-2ed5f12c3e6e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""64680874-ffac-4149-afa5-db949c94f8e4"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""edaf4dd1-6fd3-4cf9-a738-af40493b9ed2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7a6b419f-41c8-475c-a8af-45eca48edc1d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""AnalogStick"",
                    ""id"": ""f92bac86-10ba-449a-88b2-1f4f13f23e57"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""88900c64-4aaf-4960-b385-390be54f7072"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""681737ab-023f-4920-9ab8-8c2e882c2a18"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""92364238-2277-4aef-80bb-1c22bc20c086"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0cae652f-872e-4b9d-ab60-e771d08b1f67"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""D-pad"",
                    ""id"": ""4d61e1f4-dc6a-40b4-bd3b-a82c39450129"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f2996857-1df1-4703-81cd-ef21523765fb"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""64ed9b69-742b-4d43-9c55-829c61501319"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d0633dc6-3eb9-408d-b340-9a23cdccf8b5"",
                    ""path"": ""<XInputController>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c74ea03f-a33f-471f-9d58-f02a87009644"",
                    ""path"": ""<XInputController>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9e3d177a-d0bb-4fa6-aefd-4db244a55034"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""78c0b98f-762b-477f-b570-c5fe49752e31"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""InventoryScrollArrows"",
                    ""id"": ""44ee4229-78c9-4ded-93df-f9636a9004ee"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Press(pressPoint=0.5)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InventoryScroll"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d127060d-4c07-492d-b0b5-784ff68dcc14"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""InventoryScroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ae9f67a5-6e8e-4f14-860c-3b265ba5182d"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""InventoryScroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8bf17760-306b-4bf2-b85b-1051ea95f242"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""InventoryUse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ed966c9-2260-4d63-87a3-10611ea8a7fe"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""InventoryUse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""412d9dca-2c20-4919-bb40-15907ac96656"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""InventoryUse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d56f9a8d-a9aa-4d23-81d1-3504cb468475"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""InventoryUse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""InventoryScrollAnalog"",
                    ""id"": ""fdb31184-d3f7-4665-b2a7-01bc9c107990"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Press(pressPoint=0.5)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InventoryScroll"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""08156417-d53e-489b-87a4-7f2fe7a06baa"",
                    ""path"": ""<XInputController>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""InventoryScroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ebf43ba8-9a47-43fe-a6e2-0e1aac6b8acc"",
                    ""path"": ""<XInputController>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""InventoryScroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""48a06a3f-daf3-4c94-a68a-52f99c1dced0"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""39a406cf-7e1b-44f4-be2e-f5ff382fbfa3"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxGamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardAndMouse"",
            ""bindingGroup"": ""KeyboardAndMouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XboxGamepad"",
            ""bindingGroup"": ""XboxGamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Action = m_Player.FindAction("Action", throwIfNotFound: true);
        m_Player_InventoryScroll = m_Player.FindAction("InventoryScroll", throwIfNotFound: true);
        m_Player_InventoryUse = m_Player.FindAction("InventoryUse", throwIfNotFound: true);
        m_Player_Pause = m_Player.FindAction("Pause", throwIfNotFound: true);
    }

    ~DefaultControls()
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Action;
    private readonly InputAction m_Player_InventoryScroll;
    private readonly InputAction m_Player_InventoryUse;
    private readonly InputAction m_Player_Pause;
    public struct PlayerActions
    {
        private DefaultControls m_Wrapper;
        public PlayerActions(DefaultControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Action => m_Wrapper.m_Player_Action;
        public InputAction @InventoryScroll => m_Wrapper.m_Player_InventoryScroll;
        public InputAction @InventoryUse => m_Wrapper.m_Player_InventoryUse;
        public InputAction @Pause => m_Wrapper.m_Player_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                Action.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction;
                Action.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction;
                Action.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction;
                InventoryScroll.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventoryScroll;
                InventoryScroll.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventoryScroll;
                InventoryScroll.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventoryScroll;
                InventoryUse.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventoryUse;
                InventoryUse.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventoryUse;
                InventoryUse.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventoryUse;
                Pause.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                Pause.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                Pause.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                Movement.started += instance.OnMovement;
                Movement.performed += instance.OnMovement;
                Movement.canceled += instance.OnMovement;
                Action.started += instance.OnAction;
                Action.performed += instance.OnAction;
                Action.canceled += instance.OnAction;
                InventoryScroll.started += instance.OnInventoryScroll;
                InventoryScroll.performed += instance.OnInventoryScroll;
                InventoryScroll.canceled += instance.OnInventoryScroll;
                InventoryUse.started += instance.OnInventoryUse;
                InventoryUse.performed += instance.OnInventoryUse;
                InventoryUse.canceled += instance.OnInventoryUse;
                Pause.started += instance.OnPause;
                Pause.performed += instance.OnPause;
                Pause.canceled += instance.OnPause;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardAndMouseSchemeIndex = -1;
    public InputControlScheme KeyboardAndMouseScheme
    {
        get
        {
            if (m_KeyboardAndMouseSchemeIndex == -1) m_KeyboardAndMouseSchemeIndex = asset.FindControlSchemeIndex("KeyboardAndMouse");
            return asset.controlSchemes[m_KeyboardAndMouseSchemeIndex];
        }
    }
    private int m_XboxGamepadSchemeIndex = -1;
    public InputControlScheme XboxGamepadScheme
    {
        get
        {
            if (m_XboxGamepadSchemeIndex == -1) m_XboxGamepadSchemeIndex = asset.FindControlSchemeIndex("XboxGamepad");
            return asset.controlSchemes[m_XboxGamepadSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
        void OnInventoryScroll(InputAction.CallbackContext context);
        void OnInventoryUse(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
