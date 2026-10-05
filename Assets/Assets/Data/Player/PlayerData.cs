using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Data/PlayerData")]

public class PlayerData : ScriptableObject
{
  [SerializeField] float maxHealth;
  [SerializeField] float currentHealth;
  [SerializeField] int coins;


public float MaxHealth
    {
        get => maxHealth;
        set => maxHealth = value;
    }

public float CurrentHealth
    {
        get => currentHealth;
        set => currentHealth = value;
    }

public int Coins
    {
        get => coins;
        set => coins = value;
    }

}
