using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    
    [SerializeField] Detection detection;
    [SerializeField] TurretData turret;
    [SerializeField] EnemyData enemyData;
    float Damage = 0f;

    float enemyHealth;
    

    void Start()
    {
        Damage = turret.TurretDamage;
        enemyHealth = enemyData.Health;
    }

    // Update is called once per frame
    void Update()
    {
        if (detection.distance <= .5)
        {
            enemyHealth = enemyHealth - Damage;
            Debug.Log("Enemy took damage");
        }
    }
}
