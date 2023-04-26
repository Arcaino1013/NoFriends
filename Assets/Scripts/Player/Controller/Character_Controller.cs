using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Character_Controller : InputController
{
    CharacterController controller;
    Vector3 dir, inputDir;
    float speed = 5;
    protected new void Awake()
    {
        input = transform.parent.GetComponent<CharacterManager>().Input;
        if (input == null) {Debug.LogWarning("No element of the class MyInput. We are generating out own"); input = new MyInput(); }
        input.Player.Enable();
        input.Player.Fire.performed += OnFire;
        input.Player.Look.performed += OnLook;
        input.Player.Move.performed += OnMove;
        input.Player.Move.canceled += OnMoveCanceled;
        input.Player.Jump.performed += OnJump;
    }

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    private void Update()
    {
        controller.Move(dir * speed * Time.deltaTime );
    }

    private void LateUpdate()
    {
        UpdateDir();
    }

    protected override void OnFire(InputAction.CallbackContext context)
    {
        //getNormalizedMousePos();
        Debug.Log("The mouse position is " + (Mouse.current.position.ReadValue()));

    }

    public void OnLook(InputAction.CallbackContext context)
    {
        Vector2 dir = getNormalizedMousePos();
        controller.transform.forward = new Vector3(dir.x, controller.transform.forward.y, dir.y);

        //Vector2 dir = context.ReadValue<Vector2>() * 0.5f;
        //controller.transform.Rotate(0, dir.x, 0);
        
    }

    protected override void OnMove(InputAction.CallbackContext context)
    {
        SetDir(context.ReadValue<Vector2>());
    }

    protected override void OnMoveCanceled(InputAction.CallbackContext context)
    {
        SetDir(context.ReadValue<Vector2>());
    }

    private void SetDir(Vector2 input)
    {
        inputDir = VectorOperations.rawInput(new Vector3(input.x, 0, input.y));
    }

    private void UpdateDir()
    {
        dir = inputDir.x * controller.transform.right + inputDir.z * controller.transform.forward;
    }
}
