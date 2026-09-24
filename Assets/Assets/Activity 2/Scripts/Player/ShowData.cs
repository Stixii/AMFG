using System;
using UnityEngine;

public class ShowData : MonoBehaviour
{
    //DebugLog shows the amount of rockets the player has
    [SerializeField] RocketAmountData RocketAmount;
    
    void Update()
    {
        Debug.Log(RocketAmount.rocketAmount);
    } 
}
