using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] EnemyData data;

    public float health;
    public float speed;
    public float damage;

    private void Start()
    {
        health = data.Health;
        speed = data.Speed;
        damage = data.Damage;
    }

    void Update()
    {
        
    }


}
