using System;
using UnityEngine;

public class Detection : MonoBehaviour
{   

    //Detection for player and target

   [SerializeField] Transform Object;
   
   [SerializeField] Transform Player;

    public float distance;
   
   //Updates the distance and shows it in the logs
    void Update()
    {
        distance =  Vector3.Distance(Object.position, Player.position);
        Debug.Log(distance); 
    }
}
