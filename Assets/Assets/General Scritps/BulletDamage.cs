using System;
using Unity.VisualScripting;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    
    [SerializeField] Detection detection;
    [SerializeField] TurretData turret;

    float Damage = 0f;

    float enemyHealth;
    Enemy enemyScript;

    void Start()
    {
        Damage = turret.TurretDamage;
        enemyHealth = enemyScript.enemyHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (detection.distance <= .5)
        {
            enemyHealth = enemyHealth - Damage ;
            Debug.Log("Enemy took damage");
        }
    }
}
