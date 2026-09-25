using UnityEngine;

public class Shotgun : MonoBehaviour
{
    [SerializeField] Detection detection;
   [SerializeField] TurretData turret;
   [SerializeField] GameObject bulletPrefab;
   
   [SerializeField] Transform player;
   [SerializeField] float spreadAngle = 10f;
   [SerializeField] int bulletAmount = 6;
   
   [SerializeField] Transform shootingPoint;


    //Firerate  and checks when to fire
    void Update()
    {   
        if (detection.distance <= turret.Range)
        {
            turret.AttackRate += Time.deltaTime;
            float fireInterval = 1f / turret.AttackRate;
            while (turret.AttackRate >= fireInterval)
            {
                ShotgunShot();
                turret.AttackRate -= fireInterval;
            }
        }
    } 

    void ShotgunShot()
    {   
        //tracks the player
        Vector3 aimDirection = (player.position - shootingPoint.position).normalized;
        float randomAngle = Random.Range(-spreadAngle, spreadAngle);
        Vector3 shotDirection = Quaternion.AngleAxis(randomAngle, Vector3.up) * aimDirection;

        //gets the angle
        float spreadStep = 30f / Mathf.Max(1, bulletAmount - 1);
        float startAngle = -spreadStep * (bulletAmount - 1) / 2f;
        Vector3 origin = shootingPoint.position;

        for (int i = 0; i < bulletAmount; i++)
        {   
            //Spread shot
            float spread = startAngle + (spreadStep * i);
            Vector3 pelletDirection = Quaternion.AngleAxis(spread, Vector3.up) * shotDirection;
            float angle = Mathf.Atan2(pelletDirection.z, pelletDirection.x) * Mathf.Rad2Deg;

            //Creates the prefab and moves towards the player
            GameObject bullet = Instantiate(bulletPrefab, origin, Quaternion.identity);
            bullet.GetComponent<BulletMove>().Init(angle, origin, turret.BulletSpeed, turret.Lifetime);
        }
    }
}
