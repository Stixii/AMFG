using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] EnemyData data;
    [SerializeField] Detection detection;
    [SerializeField] Health healthManager;

    public float enemyHealth;
    public float enemySpeed;
    public float enemyDamage;

    private void Start()
    {
        enemyHealth = data.Health;
        enemySpeed = data.Speed;
        enemyDamage = data.Damage;
    }

    void Update()
    {   
        //Damage Health when it reaches goal
        if (detection.distance <= 0)
        {
            healthManager.currentHealth = healthManager.currentHealth - enemyDamage;
        }

        //Destroy gameobject if ITS health reaches 0
        if (enemyHealth == 0)
        {
            Destroy(gameObject);
        }
    }


}
