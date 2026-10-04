using UnityEngine;

public class Sniper : MonoBehaviour
{
[SerializeField] Detection detection;
   [SerializeField] TurretData turret;
   [SerializeField] GameObject bulletPrefab;
   [SerializeField] Transform player;
   [SerializeField] Transform turretOrientation;
   //[SerializeField] float spreadAngle = 10f;
   
   [SerializeField] Transform shootingPoint;

//Isolating access from a singular object
    private float range;
    private float attackRate;
    private float bulletSpeed;
    private float lifetime;
    void Start()
    {
        range = turret.Range;
        attackRate = turret.AttackRate;
        bulletSpeed = turret.BulletSpeed;
        lifetime = turret.Lifetime;
    }



    //Firerate  and checks when to fire
    void Update()
    {   
        if (detection.distance <= range)
        {   
            //setting aim direction as a local variable
            Vector3 aimDirection = (player.position - shootingPoint.position).normalized;
            aimDirection.y = 0f;

            turretOrientation.rotation = Quaternion.LookRotation(aimDirection, Vector3.up);


            attackRate += Time.deltaTime;
            float fireInterval = 1f / attackRate;
            while (attackRate >= fireInterval)
            {
                SniperShoot();
                attackRate -= fireInterval;
            }
        }
    } 

    void SniperShoot()
    {   
        //tracks the player
        Vector3 aimDirection = (player.position - shootingPoint.position).normalized;
        //float randomAngle = Random.Range(-spreadAngle, spreadAngle);
        Vector3 shotDirection = Quaternion.AngleAxis(1f, Vector3.up) * aimDirection;

        //gets the angle
        float angle = Mathf.Atan2(shotDirection.z, shotDirection.x) * Mathf.Rad2Deg;
        Vector3 origin = shootingPoint.position;

        //Creates the prefab and moves towards the player
        GameObject bullet = Instantiate(bulletPrefab, origin, Quaternion.identity);
        bullet.GetComponent<BulletMove>().Init(angle, origin, bulletSpeed, lifetime);
    }
}
