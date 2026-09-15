using System;
using UnityEngine;

public class Detection : MonoBehaviour
{
   [SerializeField] Transform Target;
   
   [SerializeField] Transform Player;

    public float distance;
   
    void Update()
    {
        distance =  Vector3.Distance(Target.position, Player.position);
        Debug.Log(distance);


        
    }
}
