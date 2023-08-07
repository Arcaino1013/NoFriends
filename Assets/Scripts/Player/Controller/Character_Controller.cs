using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Character_Controller : InputController
{
    InputActionMap player;
    ParticleSystem gun;
    CharacterController controller;
    Vector3 dir, inputDir;
    float speed = 5;
    bool isGrounded = false;

    protected new void Awake()
    {
        input = transform.parent.GetComponent<CharacterManager>().Input;
        //Duno if there is a reason to try to find this doesnt seem like we defined it
        if (input == null) {Debug.LogWarning("No element of the class MyInput. We are generating out own");Debug.LogWarning("Myinput container is " + transform.parent.name); input = new MyInput(); }

        input.Player.Enable();

        input.Player.Fire.performed += OnFire;
        input.Player.Fire.canceled += OnFireCanceled;
        input.Player.Look.performed += OnLook;
        input.Player.Move.performed += OnMove;
        input.Player.Move.canceled += OnMoveCanceled;
        input.Player.Jump.performed += OnJump;

    }

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        gameObject.transform.SetAsFirstSibling();
        gun = this.transform.GetComponentInChildren<ParticleSystem>();
        gun.Stop();
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
        Debug.Log("The mouse position is " + (Mouse.current.position.ReadValue()));
        gun.Play();
    }

    protected override void OnFireCanceled(InputAction.CallbackContext context)
    {
        gun.Stop();
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        Vector2 dir = getNormalizedMousePos();
        Debug.Log(controller.transform.forward);
        controller.transform.forward = new Vector3(dir.x, controller.transform.forward.y, dir.y);
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
        dir = inputDir.x * controller.transform.right + inputDir.z * controller.transform.forward + controller.transform.up * -1;
    }
}
