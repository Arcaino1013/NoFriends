using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Character_Controller : InputController
{
    CharacterController controller;
    [SerializeField]PlayerInput input = new PlayerInput();
    float speed = 5;

    private void Awake()
    {
        //input = new PlayerInput();
    }

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        controller.Move(movementDirection()* speed *Time.deltaTime);
    }


    private Vector3 movementDirection()
    {
        float x = 0,y, z = 0;
        //x = Input.GetAxis("Horizontal");
        y = 0; //For now we have to simulate gravity
        //z = Input.GetAxis("Vertical");

        Debug.Log("This is the InputVector : X =" + x.ToString() + "; Y =" + y.ToString() + " Z =" + z.ToString());
        return new Vector3(x,y,z);
    }
}
