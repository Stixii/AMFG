using UnityEngine;
using UnityEngine.UIElements.Experimental;


[CreateAssetMenu(fileName = "Rockets", menuName = "Data/Rockets")]
public class RocketAmountData : ScriptableObject
{
   [SerializeField] private int RocketAmount;
   [SerializeField] private int MaxRockets = 8;


    //Allows for pulbic access so that PickUp script can add to the universal value for the player
   public int rocketAmount 
   {
      //Limits the amount of rockets 
    get => RocketAmount;
    set => RocketAmount =  Mathf.Clamp(value,0,MaxRockets);
   }
}
