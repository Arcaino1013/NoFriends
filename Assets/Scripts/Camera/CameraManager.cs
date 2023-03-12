using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class CameraManager : MonoBehaviour
{
    //The field will only be temporary serialized
    [SerializeField]GameObject assignedPlayer;
    Camera myCam;
    MyInput input;

    Vector2 toLook = Vector2.zero;


    public void Awake()
    {
        input = transform.parent.GetComponent<CharacterManager>().Input;
        if (input == null) { Debug.LogWarning("No element of the class MyInput. We are generating out own"); input = new MyInput(); }
    }

    public void Start()
    {
        myCam = GetComponent<Camera>();
        if (assignedPlayer == null) {throw new Exception("There is no player gameObject assigned to this camera"); }
        if (myCam == null) { throw new Exception("No camera element found"); }
    }

    public void Update()
    {
        myCam.transform.LookAt(toLook);   
    }
}
