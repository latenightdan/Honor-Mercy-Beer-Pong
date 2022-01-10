// GENERATED AUTOMATICALLY FROM 'Assets/Scrips/New Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @NewControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @NewControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""New Controls"",
    ""maps"": [
        {
            ""name"": ""ThrowButton"",
            ""id"": ""c0d357db-6462-4393-a87f-549d4719a2c1"",
            ""actions"": [
                {
                    ""name"": ""Throw"",
                    ""type"": ""Button"",
                    ""id"": ""a55cce54-f90d-46a0-8aaf-03d9b42f18c9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ThrowMinus"",
                    ""type"": ""PassThrough"",
                    ""id"": ""99d7c7f7-7ce4-4c24-bc70-010d789587c5"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ThrowPlus"",
                    ""type"": ""PassThrough"",
                    ""id"": ""77ba21e1-fcb5-43b0-9195-595fc9229831"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""axxx"",
                    ""type"": ""Button"",
                    ""id"": ""e85e92d6-0a60-47a5-8d00-14ddbc0ab325"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""54e4fcd8-183b-483b-b3a8-15fbd371b35c"",
                    ""path"": ""<DualShockGamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a42ec220-652d-4ced-a70b-209e89cb79a1"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1fac79a0-f438-47d5-a787-4e7631c36b8f"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ThrowMinus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac77444e-b0e2-4010-bf01-467a1b2120b4"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press(pressPoint=0.1,behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ThrowMinus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1876cf75-0e18-44ef-8692-34ecb603c7be"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": ""Press(pressPoint=0.1,behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ThrowPlus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""956c3030-98f2-438d-a801-fb8b6806e179"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""axxx"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a93418fe-245f-43fe-98f7-8d734203edb8"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""axxx"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d7438da6-61e1-4d2b-b5ad-9dfcb8b5d947"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""axxx"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Playa"",
            ""id"": ""8a3b0ae3-76c0-428e-85b6-f7d120f2c7e0"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9a893de8-df5b-4f42-bd02-71d456d44b7e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""844e930b-98c6-478e-9e40-ac3e2f2b8075"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e1cac988-5474-4389-b25d-63c5e511eef2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HONOR"",
                    ""type"": ""Button"",
                    ""id"": ""3093588c-0378-4ad3-abb5-b128eaa2adaf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MERCY"",
                    ""type"": ""Button"",
                    ""id"": ""f97695b7-83bb-4bd6-af89-b895c69d184c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TakeNarc"",
                    ""type"": ""Button"",
                    ""id"": ""3833fe79-9f99-45ae-b73e-956e64c9a2ce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0d8210d0-9b1e-41a8-868a-5f06181c6a1e"",
                    ""path"": ""<DualShockGamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""85f53704-6d11-4b7a-9aab-bef3d1792e4d"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1aa9a7cc-a78a-4583-a31e-7ec43d62a320"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b96b444f-92a5-4cb4-a191-d83c866e42ce"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d343f5a7-0641-4856-afd7-819dcd07c1ca"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b82454d-654c-4eb6-abfe-53ce399483e2"",
                    ""path"": ""<DualShockGamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HONOR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""661a818e-4aa7-4a5f-9741-df8ce4ce4c2c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HONOR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1cea3855-2387-41a0-8eb0-cfcbfa2cb531"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MERCY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""806ea140-edea-4d8c-b746-2174e7b349ec"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MERCY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1bae35ce-cdd0-4223-961f-6efb954fc0a1"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TakeNarc"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f62b0a6a-bf2e-4721-9734-388689bf3ce0"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TakeNarc"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""ui"",
            ""id"": ""cd7eb9d0-1e2a-4b35-aee1-80226e2f54ec"",
            ""actions"": [
                {
                    ""name"": ""stick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""cf92c646-57fe-455c-ae3c-c8d3cc8e1d23"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""submit"",
                    ""type"": ""Button"",
                    ""id"": ""23be42bc-1ade-422e-9f1a-802e63a8d0a3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""cancel"",
                    ""type"": ""Button"",
                    ""id"": ""152af883-cde7-48e9-8140-4b0a922d95c6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e3f638d5-eb04-4807-8001-9665ca5c9a13"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""gamepad"",
                    ""action"": ""stick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""d pad"",
                    ""id"": ""56468290-1a3d-48af-9eed-e000271b0e04"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""stick"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8ff9f47e-2ceb-46d1-80c7-012cd619fc37"",
                    ""path"": ""<DualShockGamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""gamepad"",
                    ""action"": ""stick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c5e8c390-faad-45e5-b2ae-502b134e4839"",
                    ""path"": ""<DualShockGamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""gamepad"",
                    ""action"": ""stick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""78f7d663-1d78-4200-8c73-9023aca9cfa9"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""gamepad"",
                    ""action"": ""stick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""62a4e6ae-c472-49ae-b995-4c906d1208ce"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""gamepad"",
                    ""action"": ""stick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5f942df6-beb7-4255-b3c3-036e739f5c8e"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""gamepad"",
                    ""action"": ""submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f78c4bb6-6a1d-4e5c-b81a-441321060419"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""gamepad"",
                    ""action"": ""cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""gamepad"",
            ""bindingGroup"": ""gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<DualShock4GampadiOS>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // ThrowButton
        m_ThrowButton = asset.FindActionMap("ThrowButton", throwIfNotFound: true);
        m_ThrowButton_Throw = m_ThrowButton.FindAction("Throw", throwIfNotFound: true);
        m_ThrowButton_ThrowMinus = m_ThrowButton.FindAction("ThrowMinus", throwIfNotFound: true);
        m_ThrowButton_ThrowPlus = m_ThrowButton.FindAction("ThrowPlus", throwIfNotFound: true);
        m_ThrowButton_axxx = m_ThrowButton.FindAction("axxx", throwIfNotFound: true);
        // Playa
        m_Playa = asset.FindActionMap("Playa", throwIfNotFound: true);
        m_Playa_Movement = m_Playa.FindAction("Movement", throwIfNotFound: true);
        m_Playa_Jump = m_Playa.FindAction("Jump", throwIfNotFound: true);
        m_Playa_Look = m_Playa.FindAction("Look", throwIfNotFound: true);
        m_Playa_HONOR = m_Playa.FindAction("HONOR", throwIfNotFound: true);
        m_Playa_MERCY = m_Playa.FindAction("MERCY", throwIfNotFound: true);
        m_Playa_TakeNarc = m_Playa.FindAction("TakeNarc", throwIfNotFound: true);
        // ui
        m_ui = asset.FindActionMap("ui", throwIfNotFound: true);
        m_ui_stick = m_ui.FindAction("stick", throwIfNotFound: true);
        m_ui_submit = m_ui.FindAction("submit", throwIfNotFound: true);
        m_ui_cancel = m_ui.FindAction("cancel", throwIfNotFound: true);
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

    // ThrowButton
    private readonly InputActionMap m_ThrowButton;
    private IThrowButtonActions m_ThrowButtonActionsCallbackInterface;
    private readonly InputAction m_ThrowButton_Throw;
    private readonly InputAction m_ThrowButton_ThrowMinus;
    private readonly InputAction m_ThrowButton_ThrowPlus;
    private readonly InputAction m_ThrowButton_axxx;
    public struct ThrowButtonActions
    {
        private @NewControls m_Wrapper;
        public ThrowButtonActions(@NewControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Throw => m_Wrapper.m_ThrowButton_Throw;
        public InputAction @ThrowMinus => m_Wrapper.m_ThrowButton_ThrowMinus;
        public InputAction @ThrowPlus => m_Wrapper.m_ThrowButton_ThrowPlus;
        public InputAction @axxx => m_Wrapper.m_ThrowButton_axxx;
        public InputActionMap Get() { return m_Wrapper.m_ThrowButton; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ThrowButtonActions set) { return set.Get(); }
        public void SetCallbacks(IThrowButtonActions instance)
        {
            if (m_Wrapper.m_ThrowButtonActionsCallbackInterface != null)
            {
                @Throw.started -= m_Wrapper.m_ThrowButtonActionsCallbackInterface.OnThrow;
                @Throw.performed -= m_Wrapper.m_ThrowButtonActionsCallbackInterface.OnThrow;
                @Throw.canceled -= m_Wrapper.m_ThrowButtonActionsCallbackInterface.OnThrow;
                @ThrowMinus.started -= m_Wrapper.m_ThrowButtonActionsCallbackInterface.OnThrowMinus;
                @ThrowMinus.performed -= m_Wrapper.m_ThrowButtonActionsCallbackInterface.OnThrowMinus;
                @ThrowMinus.canceled -= m_Wrapper.m_ThrowButtonActionsCallbackInterface.OnThrowMinus;
                @ThrowPlus.started -= m_Wrapper.m_ThrowButtonActionsCallbackInterface.OnThrowPlus;
                @ThrowPlus.performed -= m_Wrapper.m_ThrowButtonActionsCallbackInterface.OnThrowPlus;
                @ThrowPlus.canceled -= m_Wrapper.m_ThrowButtonActionsCallbackInterface.OnThrowPlus;
                @axxx.started -= m_Wrapper.m_ThrowButtonActionsCallbackInterface.OnAxxx;
                @axxx.performed -= m_Wrapper.m_ThrowButtonActionsCallbackInterface.OnAxxx;
                @axxx.canceled -= m_Wrapper.m_ThrowButtonActionsCallbackInterface.OnAxxx;
            }
            m_Wrapper.m_ThrowButtonActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Throw.started += instance.OnThrow;
                @Throw.performed += instance.OnThrow;
                @Throw.canceled += instance.OnThrow;
                @ThrowMinus.started += instance.OnThrowMinus;
                @ThrowMinus.performed += instance.OnThrowMinus;
                @ThrowMinus.canceled += instance.OnThrowMinus;
                @ThrowPlus.started += instance.OnThrowPlus;
                @ThrowPlus.performed += instance.OnThrowPlus;
                @ThrowPlus.canceled += instance.OnThrowPlus;
                @axxx.started += instance.OnAxxx;
                @axxx.performed += instance.OnAxxx;
                @axxx.canceled += instance.OnAxxx;
            }
        }
    }
    public ThrowButtonActions @ThrowButton => new ThrowButtonActions(this);

    // Playa
    private readonly InputActionMap m_Playa;
    private IPlayaActions m_PlayaActionsCallbackInterface;
    private readonly InputAction m_Playa_Movement;
    private readonly InputAction m_Playa_Jump;
    private readonly InputAction m_Playa_Look;
    private readonly InputAction m_Playa_HONOR;
    private readonly InputAction m_Playa_MERCY;
    private readonly InputAction m_Playa_TakeNarc;
    public struct PlayaActions
    {
        private @NewControls m_Wrapper;
        public PlayaActions(@NewControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Playa_Movement;
        public InputAction @Jump => m_Wrapper.m_Playa_Jump;
        public InputAction @Look => m_Wrapper.m_Playa_Look;
        public InputAction @HONOR => m_Wrapper.m_Playa_HONOR;
        public InputAction @MERCY => m_Wrapper.m_Playa_MERCY;
        public InputAction @TakeNarc => m_Wrapper.m_Playa_TakeNarc;
        public InputActionMap Get() { return m_Wrapper.m_Playa; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayaActions set) { return set.Get(); }
        public void SetCallbacks(IPlayaActions instance)
        {
            if (m_Wrapper.m_PlayaActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayaActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayaActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayaActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_PlayaActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayaActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayaActionsCallbackInterface.OnJump;
                @Look.started -= m_Wrapper.m_PlayaActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayaActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayaActionsCallbackInterface.OnLook;
                @HONOR.started -= m_Wrapper.m_PlayaActionsCallbackInterface.OnHONOR;
                @HONOR.performed -= m_Wrapper.m_PlayaActionsCallbackInterface.OnHONOR;
                @HONOR.canceled -= m_Wrapper.m_PlayaActionsCallbackInterface.OnHONOR;
                @MERCY.started -= m_Wrapper.m_PlayaActionsCallbackInterface.OnMERCY;
                @MERCY.performed -= m_Wrapper.m_PlayaActionsCallbackInterface.OnMERCY;
                @MERCY.canceled -= m_Wrapper.m_PlayaActionsCallbackInterface.OnMERCY;
                @TakeNarc.started -= m_Wrapper.m_PlayaActionsCallbackInterface.OnTakeNarc;
                @TakeNarc.performed -= m_Wrapper.m_PlayaActionsCallbackInterface.OnTakeNarc;
                @TakeNarc.canceled -= m_Wrapper.m_PlayaActionsCallbackInterface.OnTakeNarc;
            }
            m_Wrapper.m_PlayaActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @HONOR.started += instance.OnHONOR;
                @HONOR.performed += instance.OnHONOR;
                @HONOR.canceled += instance.OnHONOR;
                @MERCY.started += instance.OnMERCY;
                @MERCY.performed += instance.OnMERCY;
                @MERCY.canceled += instance.OnMERCY;
                @TakeNarc.started += instance.OnTakeNarc;
                @TakeNarc.performed += instance.OnTakeNarc;
                @TakeNarc.canceled += instance.OnTakeNarc;
            }
        }
    }
    public PlayaActions @Playa => new PlayaActions(this);

    // ui
    private readonly InputActionMap m_ui;
    private IUiActions m_UiActionsCallbackInterface;
    private readonly InputAction m_ui_stick;
    private readonly InputAction m_ui_submit;
    private readonly InputAction m_ui_cancel;
    public struct UiActions
    {
        private @NewControls m_Wrapper;
        public UiActions(@NewControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @stick => m_Wrapper.m_ui_stick;
        public InputAction @submit => m_Wrapper.m_ui_submit;
        public InputAction @cancel => m_Wrapper.m_ui_cancel;
        public InputActionMap Get() { return m_Wrapper.m_ui; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UiActions set) { return set.Get(); }
        public void SetCallbacks(IUiActions instance)
        {
            if (m_Wrapper.m_UiActionsCallbackInterface != null)
            {
                @stick.started -= m_Wrapper.m_UiActionsCallbackInterface.OnStick;
                @stick.performed -= m_Wrapper.m_UiActionsCallbackInterface.OnStick;
                @stick.canceled -= m_Wrapper.m_UiActionsCallbackInterface.OnStick;
                @submit.started -= m_Wrapper.m_UiActionsCallbackInterface.OnSubmit;
                @submit.performed -= m_Wrapper.m_UiActionsCallbackInterface.OnSubmit;
                @submit.canceled -= m_Wrapper.m_UiActionsCallbackInterface.OnSubmit;
                @cancel.started -= m_Wrapper.m_UiActionsCallbackInterface.OnCancel;
                @cancel.performed -= m_Wrapper.m_UiActionsCallbackInterface.OnCancel;
                @cancel.canceled -= m_Wrapper.m_UiActionsCallbackInterface.OnCancel;
            }
            m_Wrapper.m_UiActionsCallbackInterface = instance;
            if (instance != null)
            {
                @stick.started += instance.OnStick;
                @stick.performed += instance.OnStick;
                @stick.canceled += instance.OnStick;
                @submit.started += instance.OnSubmit;
                @submit.performed += instance.OnSubmit;
                @submit.canceled += instance.OnSubmit;
                @cancel.started += instance.OnCancel;
                @cancel.performed += instance.OnCancel;
                @cancel.canceled += instance.OnCancel;
            }
        }
    }
    public UiActions @ui => new UiActions(this);
    private int m_gamepadSchemeIndex = -1;
    public InputControlScheme gamepadScheme
    {
        get
        {
            if (m_gamepadSchemeIndex == -1) m_gamepadSchemeIndex = asset.FindControlSchemeIndex("gamepad");
            return asset.controlSchemes[m_gamepadSchemeIndex];
        }
    }
    public interface IThrowButtonActions
    {
        void OnThrow(InputAction.CallbackContext context);
        void OnThrowMinus(InputAction.CallbackContext context);
        void OnThrowPlus(InputAction.CallbackContext context);
        void OnAxxx(InputAction.CallbackContext context);
    }
    public interface IPlayaActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnHONOR(InputAction.CallbackContext context);
        void OnMERCY(InputAction.CallbackContext context);
        void OnTakeNarc(InputAction.CallbackContext context);
    }
    public interface IUiActions
    {
        void OnStick(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
    }
}
