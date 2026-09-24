using System;
using UnityEngine;

public class Detection : MonoBehaviour
{   

    //Detection for player and target

   [SerializeField] Transform Target;
   
   [SerializeField] Transform Player;

    public float distance;
   
   //Updates the distance and shows it in the logs
    void Update()
    {
        distance =  Vector3.Distance(Target.position, Player.position);
        Debug.Log(distance); 
    }
}
