using System;
using UnityEngine;

public class PickUP : MonoBehaviour
{

//Before using the script assign these variables to narrow search time for specific functions
//easier visibility to see which script is connected to where and what its being used for
//Directly navigates developers to the component/function/script affected. <3
[SerializeField] Detection detection;
[SerializeField] RocketAmountData RocketData;
[SerializeField] GameObject PickUp;


    //Checks if the player gets close enough and destroys itself and 
    //increments the rocketAmount value
    void Update()
    {
        
    if (detection.distance <= .5f)
        {
            RocketData.rocketAmount++;
            Debug.Log(detection.distance);
            Destroy(PickUp);
        }
    }
}
