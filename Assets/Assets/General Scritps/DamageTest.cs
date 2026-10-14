using Unity.VisualScripting;
using UnityEngine;

public class DamageTest : MonoBehaviour
{
  
    [SerializeField] Enemy enemy;

    public void DamageEnemy()
    {
        enemy.enemyHealth -= 1;
                    if (enemy.enemyHealth < 0f)
                {
                    Destroy(enemy.gameObject);
                }
    }
}
