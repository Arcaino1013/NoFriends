using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputPlayer
{
    //InputActionMap testMap = new InputActionMap();
    //InputActionAsset actions = new InputActionAsset();
    InputAction move = new InputAction();
    InputAction fire = new InputAction();

    public InputPlayer() 
    {
        //
        //testMap.ad
    }


    public InputAction Move { get { return move;}   set { move = value;} }
    public InputAction Fire { get { return fire;}   set { fire = value;} }


}
