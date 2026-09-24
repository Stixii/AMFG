using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    Vector3 spawnPoint;
    Vector3 direction;
    float speed;
    float lifetime;
    float timer;

    public void Init(float angleDegrees, Vector3 origin, float rocketSpeed, float rocketLifetime)
    {
        spawnPoint = origin;
        transform.position = origin;
        speed = rocketSpeed;
        lifetime = rocketLifetime;
        timer = 0f;

        float rad = angleDegrees * Mathf.Deg2Rad;
        direction = new Vector3(Mathf.Cos(rad), Mathf.Sin(rad), 0f);
    }

    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;

        timer += Time.deltaTime;
        if (timer >= lifetime)
        {
            Destroy(gameObject);
        }
    }
}