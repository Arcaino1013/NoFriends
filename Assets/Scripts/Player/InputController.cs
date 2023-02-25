using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class InputController : MonoBehaviour, InputMap.IPlayerActions
{
    PlayerInput input;



    protected void Awake()
    {
        input = GetComponent<PlayerInput>();
        if(input == null ) { Debug.LogWarning("PlayerInput is empty please fix."); } 
    }




    public void OnFire(InputAction.CallbackContext context)
    {
        Debug.Log("We fired");
        
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }




}
