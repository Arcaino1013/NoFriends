using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class InputController : MonoBehaviour
{
    protected MyInput inputs;


    protected void Awake()
    {
        inputs = new MyInput();
        inputs.Player.Enable();
        inputs.Player.Fire.performed += OnFire;
        inputs.Player.Look.performed += OnLook;
        inputs.Player.Move.performed += OnMove;
        inputs.Player.Move.canceled += OnMoveCanceled;
        inputs.Player.Jump.performed += OnJump;
    }




    protected virtual void OnFire(InputAction.CallbackContext context) {Debug.Log("We fired");}
    protected virtual void OnLook(InputAction.CallbackContext context) {Debug.Log("We looked");}
    protected virtual void OnMove(InputAction.CallbackContext context) {Debug.Log("We moved");}
    protected virtual void OnMoveCanceled(InputAction.CallbackContext context) {Debug.Log("We cancelled the move moved");}
    protected virtual void OnJump(InputAction.CallbackContext context) { Debug.Log("We jumped"); }
}
