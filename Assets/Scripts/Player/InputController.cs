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
    }




    protected virtual void OnFire(InputAction.CallbackContext context)
    {
        Debug.Log("We fired");
    }

    public virtual void OnLook(InputAction.CallbackContext context)
    {
        Debug.Log("We looked");
    }

    public virtual void OnMove(InputAction.CallbackContext context)
    {
        Debug.Log("We moved");
    }

    public virtual void OnMoveCanceled(InputAction.CallbackContext context)
    {
        Debug.Log("We cancelled the move moved");
    }
}
