using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class InputController : MonoBehaviour
{
    protected MyInput input;


    protected void Awake()
    {
        if (input == null) { input = new MyInput(); }
        input.Player.Enable();
    }




    protected virtual void OnFire(InputAction.CallbackContext context) {Debug.Log("We fired");}
    protected virtual void OnLook(InputAction.CallbackContext context) {Debug.Log("We looked");}
    protected virtual void OnMove(InputAction.CallbackContext context) {Debug.Log("We moved");}
    protected virtual void OnMoveCanceled(InputAction.CallbackContext context) {Debug.Log("We cancelled the move moved");}
    protected virtual void OnJump(InputAction.CallbackContext context) { Debug.Log("We jumped"); }
}
