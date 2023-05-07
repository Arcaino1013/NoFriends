using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    protected MyInput input;
    Collider collider;
    int health = 100;

    public void Awake()
    {
        input = new MyInput();
    }

    void Start()
    {
        collider = gameObject.GetComponent<Collider>();
        if(collider == null)
        {
            Debug.Log("No collider attached to Player " + gameObject.name);
        }
    }

    //Damage Detectiont has to be worked on
    public void OnParticleCollision(GameObject other)
    {
        Debug.Log("Got shot");
    }

    public MyInput Input { get { return input; } }
}
