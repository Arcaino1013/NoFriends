using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    Collider collider;
    int health = 100;
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
        Debug.Log("Collided with a particle");
    }
}
