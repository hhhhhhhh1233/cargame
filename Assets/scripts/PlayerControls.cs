//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/scripts/PlayerControls.inputactions
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

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Driving"",
            ""id"": ""731ffab7-bf94-4c9d-a062-8f176d634ff3"",
            ""actions"": [
                {
                    ""name"": ""Steer"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0f7093bd-d052-4c3a-9169-6cbf14c049a3"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a96cd4be-b29e-49e6-b7f4-e9c8498aecde"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Accelerate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""fea4b37c-f2d5-4116-988e-ac292a7c2633"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Decelerate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""be0182a5-4a78-4913-ad63-824d66991eee"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""QuitGame"",
                    ""type"": ""Button"",
                    ""id"": ""1761a2ef-505f-4181-978c-bab68a1a34e2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""13ca7895-a030-4b5c-b36f-a7eabb218a8f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Respawn"",
                    ""type"": ""Button"",
                    ""id"": ""624ccf0e-d5e4-4794-92d2-e55b0ca0cc97"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""UseItem"",
                    ""type"": ""Button"",
                    ""id"": ""eed8d8ec-573a-4d66-8179-cab599a4dc1e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""5410c786-422f-46e5-b7f7-ba82a31fd13b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""efe08a51-4640-4455-b35a-41f1fbaef329"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6fbd609a-899a-4cdc-8bf9-758323ce09f8"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""9770555a-d6ce-4de8-94cf-1b69c4e03223"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""81071f95-e162-4a45-bac3-6ba62ea3300e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""4282657f-9d40-4b6d-8fa0-df166a9dc0bc"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""8f0fbbc3-5309-4e2f-9354-8d58aec19da8"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ed84c41b-a2b2-4a2f-adf4-dc6e3fb360e4"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2d42fe6e-9913-49b8-8b0e-ccf78cb86537"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""54249ac3-3d31-4b6d-b4b9-f1d45984ffa2"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone(min=0.7)"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""2aed3a5b-8034-45a8-b5c8-b6bb0d6cd63d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""fe09b861-b532-4d91-9af8-baa6b5ca184a"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a482c03b-109f-4f09-9af2-2c6a1744ef1f"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""098581ac-aef4-4244-8594-14913defac18"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""54924742-b989-41df-a2d0-3cc7ccd1ae85"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""20fd4629-c57b-40d3-98e9-fca0f36e6258"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9897720f-031b-4230-ad96-d768a92f48c9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da5a95b4-43b4-45dd-b2a8-1d0f49b844d0"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Decelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b9e829f2-e421-41e7-bcdb-fac42acdf470"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Decelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a02a12b0-8de9-4a11-9846-fcfa756417f2"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""QuitGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb5ca6be-9d51-4537-883d-68d1c1d55690"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""QuitGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8965e7b9-e7c4-49e9-92c6-0ad56c37073e"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e0428ad-ed79-40c8-b445-b780042e59fa"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""67cb166d-57d0-4662-868a-d413b0b5cfe2"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Respawn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""695a1b01-88d2-483f-ba47-aaeef348f166"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Respawn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""601526e4-8f82-4d0b-bfac-9c1e810c4a83"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""UseItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""affdfefd-70ba-4d7b-be79-9ed547e7f52f"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""UseItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KBM"",
            ""bindingGroup"": ""KBM"",
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
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Driving
        m_Driving = asset.FindActionMap("Driving", throwIfNotFound: true);
        m_Driving_Steer = m_Driving.FindAction("Steer", throwIfNotFound: true);
        m_Driving_Aim = m_Driving.FindAction("Aim", throwIfNotFound: true);
        m_Driving_Accelerate = m_Driving.FindAction("Accelerate", throwIfNotFound: true);
        m_Driving_Decelerate = m_Driving.FindAction("Decelerate", throwIfNotFound: true);
        m_Driving_QuitGame = m_Driving.FindAction("QuitGame", throwIfNotFound: true);
        m_Driving_Shoot = m_Driving.FindAction("Shoot", throwIfNotFound: true);
        m_Driving_Respawn = m_Driving.FindAction("Respawn", throwIfNotFound: true);
        m_Driving_UseItem = m_Driving.FindAction("UseItem", throwIfNotFound: true);
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

    // Driving
    private readonly InputActionMap m_Driving;
    private IDrivingActions m_DrivingActionsCallbackInterface;
    private readonly InputAction m_Driving_Steer;
    private readonly InputAction m_Driving_Aim;
    private readonly InputAction m_Driving_Accelerate;
    private readonly InputAction m_Driving_Decelerate;
    private readonly InputAction m_Driving_QuitGame;
    private readonly InputAction m_Driving_Shoot;
    private readonly InputAction m_Driving_Respawn;
    private readonly InputAction m_Driving_UseItem;
    public struct DrivingActions
    {
        private @PlayerControls m_Wrapper;
        public DrivingActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Steer => m_Wrapper.m_Driving_Steer;
        public InputAction @Aim => m_Wrapper.m_Driving_Aim;
        public InputAction @Accelerate => m_Wrapper.m_Driving_Accelerate;
        public InputAction @Decelerate => m_Wrapper.m_Driving_Decelerate;
        public InputAction @QuitGame => m_Wrapper.m_Driving_QuitGame;
        public InputAction @Shoot => m_Wrapper.m_Driving_Shoot;
        public InputAction @Respawn => m_Wrapper.m_Driving_Respawn;
        public InputAction @UseItem => m_Wrapper.m_Driving_UseItem;
        public InputActionMap Get() { return m_Wrapper.m_Driving; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DrivingActions set) { return set.Get(); }
        public void SetCallbacks(IDrivingActions instance)
        {
            if (m_Wrapper.m_DrivingActionsCallbackInterface != null)
            {
                @Steer.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnSteer;
                @Steer.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnSteer;
                @Steer.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnSteer;
                @Aim.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnAim;
                @Accelerate.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnAccelerate;
                @Accelerate.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnAccelerate;
                @Accelerate.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnAccelerate;
                @Decelerate.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnDecelerate;
                @Decelerate.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnDecelerate;
                @Decelerate.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnDecelerate;
                @QuitGame.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnQuitGame;
                @QuitGame.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnQuitGame;
                @QuitGame.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnQuitGame;
                @Shoot.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnShoot;
                @Respawn.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnRespawn;
                @Respawn.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnRespawn;
                @Respawn.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnRespawn;
                @UseItem.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnUseItem;
                @UseItem.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnUseItem;
                @UseItem.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnUseItem;
            }
            m_Wrapper.m_DrivingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Steer.started += instance.OnSteer;
                @Steer.performed += instance.OnSteer;
                @Steer.canceled += instance.OnSteer;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Accelerate.started += instance.OnAccelerate;
                @Accelerate.performed += instance.OnAccelerate;
                @Accelerate.canceled += instance.OnAccelerate;
                @Decelerate.started += instance.OnDecelerate;
                @Decelerate.performed += instance.OnDecelerate;
                @Decelerate.canceled += instance.OnDecelerate;
                @QuitGame.started += instance.OnQuitGame;
                @QuitGame.performed += instance.OnQuitGame;
                @QuitGame.canceled += instance.OnQuitGame;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Respawn.started += instance.OnRespawn;
                @Respawn.performed += instance.OnRespawn;
                @Respawn.canceled += instance.OnRespawn;
                @UseItem.started += instance.OnUseItem;
                @UseItem.performed += instance.OnUseItem;
                @UseItem.canceled += instance.OnUseItem;
            }
        }
    }
    public DrivingActions @Driving => new DrivingActions(this);
    private int m_KBMSchemeIndex = -1;
    public InputControlScheme KBMScheme
    {
        get
        {
            if (m_KBMSchemeIndex == -1) m_KBMSchemeIndex = asset.FindControlSchemeIndex("KBM");
            return asset.controlSchemes[m_KBMSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IDrivingActions
    {
        void OnSteer(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnAccelerate(InputAction.CallbackContext context);
        void OnDecelerate(InputAction.CallbackContext context);
        void OnQuitGame(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnRespawn(InputAction.CallbackContext context);
        void OnUseItem(InputAction.CallbackContext context);
    }
}
