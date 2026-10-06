using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [SerializeField] TurretData turret;

    Vector3 spawnPoint;
    Vector3 direction;
    float speed;
    float lifetime;
    float timer;
    float turretDamage;
    Enemy enemy;
    [SerializeField] Detection detection;
    [SerializeField] GameObject bulletPrefab;

    //Initializes the bullet speed 
    void Awake()
    {
        speed = turret.BulletSpeed;
        lifetime = turret.Lifetime;
    } 

    //Gets the values from the game object spawning the prefab
    public void Init(float angleDegrees, Vector3 origin, float rocketSpeed, float rocketLifetime)
    {
        spawnPoint = origin;
        transform.position = origin;
        speed = rocketSpeed;
        lifetime = rocketLifetime;
        timer = 0f;
        turretDamage = turret.TurretDamage;

        //Spawns the  rockets on the X and Y axis and shoots them out
        float rad = angleDegrees * Mathf.Deg2Rad;
        direction = new Vector3(Mathf.Cos(rad), 0f, Mathf.Sin(rad));
    }

    //lifetime of a bullet
    void Update()
    {
        DamageEnemy();
        transform.position += direction * speed * Time.deltaTime;

        timer += Time.deltaTime;
        if (timer >= lifetime)
        {
            Destroy(gameObject);
        }
    }

    private void DamageEnemy()
    {
        if (detection.distance > .5)
        {
            if (gameObject.GetComponent<Enemy>() != null)
            {
                enemy.health -= turretDamage;
                    if (enemy.health < 0f)
                {
                    Destroy(gameObject.GetComponent<Enemy>());
                }

            }
        }

    }
}
