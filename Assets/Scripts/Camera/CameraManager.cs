using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class CameraManager : MonoBehaviour
{
    //The field will only be temporary serialized
    [SerializeField]GameObject assignedPlayer;
    [SerializeField]Camera myCam;
    MyInput input;

    Vector2 toLook = Vector2.zero;
    Transform toFollow;


    public void Awake()
    {
        myCam = GetComponent<Camera>();
        input = transform.parent.GetComponent<CharacterManager>().Input;
        toFollow = transform.parent.Find("Controller").gameObject.transform;
        if(toFollow == null) { Debug.LogWarning("toFollow is empty"); }
        if (input == null) { Debug.LogWarning("No element of the class MyInput. We are generating out own"); input = new MyInput(); }
        if(myCam == null) { Debug.LogWarning("Mycam is empty"); }
    }

    public void Start()
    {
        myCam = GetComponent<Camera>();
        if (assignedPlayer == null) {throw new Exception("There is no player gameObject assigned to this camera"); }
        if (myCam == null) { throw new Exception("No camera element found"); }
    }

    public void Update()
    {
        //myCam.transform.LookAt(toFollow.transform.position);
        //myCam.transform.position = new Vector3(toFollow.position.x, myCam.transform.position.y, toFollow.transform.position.z);
    }
}
