using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    
    [SerializeField] Detection detection;
    [SerializeField] Enemy enemy;

    void Update()
    {
        if (detection.distance <= .5f)
        {
            DamageEnemy();
        }
    }

    public void DamageEnemy()
    {
        enemy.enemyHealth -= 1;
        if (enemy.enemyHealth <= 0f)
        {
            Destroy(enemy.gameObject);
        }
    }
}
