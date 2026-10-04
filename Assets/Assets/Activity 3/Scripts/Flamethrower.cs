using UnityEngine;

public class Flamethrower : MonoBehaviour
{
   
   [SerializeField] Detection detection;
   [SerializeField] TurretData turret;
   [SerializeField] GameObject bulletPrefab;
   [SerializeField] Transform player;
   [SerializeField] float spreadAngle = 10f;
   
   [SerializeField] Transform turretOrientation;
   [SerializeField] Transform shootingPoint;


    //Firerate  and checks when to fire
    void Update()
    {   
        if (detection.distance <= turret.Range)
        {   
             //setting aim direction as a local variable
            Vector3 aimDirection = (player.position - shootingPoint.position).normalized;
            aimDirection.y = 0f;

            turretOrientation.rotation = Quaternion.LookRotation(aimDirection, Vector3.up);

            turret.AttackRate += Time.deltaTime * 3f;
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
        //tracks the player
        Vector3 aimDirection = (player.position - shootingPoint.position).normalized;
        float randomAngle = Random.Range(-spreadAngle, spreadAngle);
        Vector3 shotDirection = Quaternion.AngleAxis(randomAngle, Vector3.up) * aimDirection;

        //gets the angle
        float angle = Mathf.Atan2(shotDirection.z, shotDirection.x) * Mathf.Rad2Deg;
        Vector3 origin = shootingPoint.position;

        //Creates the prefab and moves towards the player
        GameObject bullet = Instantiate(bulletPrefab, origin, Quaternion.identity);
        bullet.GetComponent<BulletMove>().Init(angle, origin, turret.BulletSpeed, turret.Lifetime);
    }
}
