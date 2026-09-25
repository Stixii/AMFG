using UnityEngine;

public class Flamethrower : MonoBehaviour
{
   
   [SerializeField] Detection detection;
   [SerializeField] TurretData turret;
   [SerializeField] GameObject bulletPrefab;
   [SerializeField] float spreadAngle = 10f;
   
   [SerializeField] Transform shootingPoint;
    
    

    void Update()
    {
        if (detection.distance <= turret.Range)
        {
            turret.AttackRate += Time.deltaTime;
            float fireInterval = 1f / turret.AttackRate;
            while (turret.AttackRate >= fireInterval)
            {
                FlamethowerShoot();
                turret.AttackRate -= fireInterval;
            }
        }


    } 

    void FlamethowerShoot()
    {
        float randomAngle = Random.Range (-spreadAngle, spreadAngle);
        float angleRad = randomAngle * Mathf.Deg2Rad;

        Vector3 localSpreadDir = new Vector3(Mathf.Sin(angleRad), 0f, Mathf.Cos(angleRad));
    }


}
