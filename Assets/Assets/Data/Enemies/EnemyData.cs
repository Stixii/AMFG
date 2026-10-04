using UnityEngine;


[CreateAssetMenu(fileName = "EnemyData", menuName = "Data/EnemyData")]

public class EnemyData : ScriptableObject
{
    [SerializeField] GameObject enemyPrefab;
    
    [SerializeField] int health;
    [SerializeField] float speed;



    public GameObject EnemyPrefab
    {
        get => enemyPrefab;
        set => enemyPrefab = value;
    }

    public int Health
    {
        get => health;
        set => health = value;
    }
    
    public float Speed
    {
        get => speed;
        set => speed = value;
    }


}
