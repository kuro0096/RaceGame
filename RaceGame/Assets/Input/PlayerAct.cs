// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerAct.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerAct : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public @PlayerAct()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerAct"",
    ""maps"": [
        {
            ""name"": ""ActionTest"",
            ""id"": ""220ae36b-d96c-4f17-9a39-a2d76a2cef12"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""df6825bd-f906-460d-b441-00a0b075e361"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""89d729a7-5ceb-42a2-aa4a-c2e6fb60770f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""99cf4c55-0b75-401b-8368-1443a3853284"",
                    ""path"": ""<XInputController>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""146cc3ef-603d-4123-8916-74c1b1a7d1e4"",
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
                    ""id"": ""6c793e6a-216e-48e8-ac56-8c38c381bcd1"",
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
                    ""id"": ""fbe59a24-27d6-4daf-a0ab-cb818ecf7f21"",
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
                    ""id"": ""9ab8d185-3049-42b8-8181-1b93637684b3"",
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
                    ""id"": ""f7b25d88-0641-4d9f-bbe4-4dec9896546b"",
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
                    ""id"": ""f890c334-9941-4d30-aee0-c87d09ae82a1"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""387d9b7e-df0d-482a-adfa-8b19122f59fe"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ActionTest
        m_ActionTest = asset.FindActionMap("ActionTest", throwIfNotFound: true);
        m_ActionTest_Move = m_ActionTest.FindAction("Move", throwIfNotFound: true);
        m_ActionTest_Jump = m_ActionTest.FindAction("Jump", throwIfNotFound: true);
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

    // ActionTest
    private readonly InputActionMap m_ActionTest;
    private IActionTestActions m_ActionTestActionsCallbackInterface;
    private readonly InputAction m_ActionTest_Move;
    private readonly InputAction m_ActionTest_Jump;
    public struct ActionTestActions
    {
        private @PlayerAct m_Wrapper;
        public ActionTestActions(@PlayerAct wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_ActionTest_Move;
        public InputAction @Jump => m_Wrapper.m_ActionTest_Jump;
        public InputActionMap Get() { return m_Wrapper.m_ActionTest; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionTestActions set) { return set.Get(); }
        public void SetCallbacks(IActionTestActions instance)
        {
            if (m_Wrapper.m_ActionTestActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_ActionTestActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_ActionTestActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_ActionTestActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_ActionTestActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_ActionTestActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_ActionTestActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_ActionTestActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public ActionTestActions @ActionTest => new ActionTestActions(this);
    public interface IActionTestActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
