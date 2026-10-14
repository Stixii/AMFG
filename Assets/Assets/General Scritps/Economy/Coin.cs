using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] CoinSpawn coinSpawn;
    [SerializeField] TMP_Text coinAmountText;
    [SerializeField] PlayerData playerData;
    
    private int coinAmount;
    
    void Start()
    {
        coinAmount = playerData.Coins;
    }

   
    void Update()
    {
        coinAmountText .text = coinAmount.ToString();
    }
}
