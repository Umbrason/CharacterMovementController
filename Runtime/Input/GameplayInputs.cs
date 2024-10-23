//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Packages/com.umbrason.charactermovementcontroller/Runtime/Input/GameplayInputs.inputactions
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

public partial class @GameplayInputs: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameplayInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameplayInputs"",
    ""maps"": [
        {
            ""name"": ""FPS Controls"",
            ""id"": ""4b5accc5-cc72-4000-818a-c591bb5e783b"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""86741e53-c7d1-4fc5-bfe6-92ebcc780107"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""161db900-860a-45d6-ac6b-3cd15c30dc20"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""45d976a4-c4d3-4ea4-962b-039dba9ee20a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""55c1d44b-bc43-424c-80e4-4113824683fd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e1c44793-473b-4f89-8adf-2dfaf7737ccc"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""79caea68-ffad-4160-a5bf-8e396d8aa710"",
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
                    ""id"": ""7a3f1544-3d1b-44aa-97c7-037d0d55fe14"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1f307ca1-7f49-496f-a116-042c47ae1a9f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5b1233ed-ece3-411a-a806-97ce8b0f3d26"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f30e059b-8e7c-48c6-9ca8-922ce310932c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""51350431-5ceb-4136-be55-f0763907f7f0"",
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
                    ""id"": ""2d783537-ab1e-4384-8c76-cba46e285881"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f8ee871b-fcc8-47af-b296-247da657dbfb"",
                    ""path"": ""<Mouse>/forwardButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // FPS Controls
        m_FPSControls = asset.FindActionMap("FPS Controls", throwIfNotFound: true);
        m_FPSControls_Move = m_FPSControls.FindAction("Move", throwIfNotFound: true);
        m_FPSControls_Jump = m_FPSControls.FindAction("Jump", throwIfNotFound: true);
        m_FPSControls_Look = m_FPSControls.FindAction("Look", throwIfNotFound: true);
        m_FPSControls_Crouch = m_FPSControls.FindAction("Crouch", throwIfNotFound: true);
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

    // FPS Controls
    private readonly InputActionMap m_FPSControls;
    private List<IFPSControlsActions> m_FPSControlsActionsCallbackInterfaces = new List<IFPSControlsActions>();
    private readonly InputAction m_FPSControls_Move;
    private readonly InputAction m_FPSControls_Jump;
    private readonly InputAction m_FPSControls_Look;
    private readonly InputAction m_FPSControls_Crouch;
    public struct FPSControlsActions
    {
        private @GameplayInputs m_Wrapper;
        public FPSControlsActions(@GameplayInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_FPSControls_Move;
        public InputAction @Jump => m_Wrapper.m_FPSControls_Jump;
        public InputAction @Look => m_Wrapper.m_FPSControls_Look;
        public InputAction @Crouch => m_Wrapper.m_FPSControls_Crouch;
        public InputActionMap Get() { return m_Wrapper.m_FPSControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FPSControlsActions set) { return set.Get(); }
        public void AddCallbacks(IFPSControlsActions instance)
        {
            if (instance == null || m_Wrapper.m_FPSControlsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_FPSControlsActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Look.started += instance.OnLook;
            @Look.performed += instance.OnLook;
            @Look.canceled += instance.OnLook;
            @Crouch.started += instance.OnCrouch;
            @Crouch.performed += instance.OnCrouch;
            @Crouch.canceled += instance.OnCrouch;
        }

        private void UnregisterCallbacks(IFPSControlsActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Look.started -= instance.OnLook;
            @Look.performed -= instance.OnLook;
            @Look.canceled -= instance.OnLook;
            @Crouch.started -= instance.OnCrouch;
            @Crouch.performed -= instance.OnCrouch;
            @Crouch.canceled -= instance.OnCrouch;
        }

        public void RemoveCallbacks(IFPSControlsActions instance)
        {
            if (m_Wrapper.m_FPSControlsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IFPSControlsActions instance)
        {
            foreach (var item in m_Wrapper.m_FPSControlsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_FPSControlsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public FPSControlsActions @FPSControls => new FPSControlsActions(this);
    public interface IFPSControlsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
    }
}