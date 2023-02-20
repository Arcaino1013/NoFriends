using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ProyectileSO : ScriptableObject
{
    [SerializeField]int damage;
    [SerializeField] int p_amount;
    [SerializeField] float speed;
    
    enum fire_mode{ auto, burst, tap }
    [SerializeField] fire_mode mode;
}
