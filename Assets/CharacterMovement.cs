using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    //Gravity shouldnt be necessary  but will be implemented later just in case i want to add other features
    CharacterController controller;
    float speed = 5;
    private void Start()
    {
        controller = gameObject.transform.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        controller.Move(movementDirection()* speed *Time.deltaTime);
    }


    private Vector3 movementDirection()
    {
        float x,y, z;
        x = Input.GetAxis("Horizontal");
        y = 0; //For now we have to simulate gravity
        z = Input.GetAxis("Vertical");

        Debug.Log("This is the InputVector : X =" + x.ToString() + "; Y =" + y.ToString() + " Z =" + z.ToString());
        return new Vector3(x,y,z);
    }
}
