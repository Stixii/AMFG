using UnityEngine;

public class Missle : MonoBehaviour
{
    
    [SerializeField] private GameObject missle;
    [SerializeField] private Transform target;
    [SerializeField] private Detection detection;
    private int lifetime = 5;
    //private int damage = 1;
    private float turnSpeed = 5f;
    private float speed = 1f;



    // Update is called once per frame
    void Update()
    {   
        //Lock on
        Vector3 direction = target.position - transform.position;

        Quaternion targertRotation = Quaternion.LookRotation(direction);

        //Turning off the bullet
        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            targertRotation,
            turnSpeed * Time.deltaTime
            );

        //move the bullet forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (detection.distance <= 0)
        {
            
        }

        if (lifetime - Time.deltaTime > lifetime)
        {
            Destroy(missle);
        }

    }
}
