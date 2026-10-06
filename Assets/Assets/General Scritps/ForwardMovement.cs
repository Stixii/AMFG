using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] GameObject Lose;
    private float speed = 10f;
    private float turnSpeed = 300f;
    public int health = 5;

    // Update is called once per frame
    void Update()
    {

        //Constant forward movemny
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        float turnInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * turnInput * turnSpeed * Time.deltaTime);
    

        if (health < 0)
        {
            Destroy(gameObject);
            Lose.SetActive(true);
        }
    }
}
