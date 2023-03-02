using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Character_Controller : InputController
{
    CharacterController controller;
    Vector2 dir;
    float speed = 5;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void OnEnable()
    {
        
    }

    private void Update()
    {
        controller.Move(new Vector3(dir.x,0,dir.y) * speed * Time.deltaTime );
    }

    protected override void OnFire(InputAction.CallbackContext context)
    {
        Debug.Log("We fired, the overriten method");

    }

    public void OnLook(InputAction.CallbackContext context)
    {
        Debug.Log("We looked, the overriten method");
    }

    public override void OnMove(InputAction.CallbackContext context)
    {
        dir = context.ReadValue<Vector2>();
        dir = VectorOperations.rawInput(dir);
        Debug.Log("The movement direction is x " + dir.x + " y " + dir.y);
    }

    public override void OnMoveCanceled(InputAction.CallbackContext context)
    {
        dir = context.ReadValue<Vector2>();
        dir = VectorOperations.rawInput(dir);
        Debug.Log("We cancelled the move moved");
    }
}
