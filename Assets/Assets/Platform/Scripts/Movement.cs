using UnityEngine;

public class Movement : MonoBehaviour
{
    
    //Basic movement using transform and old input system 

    public float speed = 5f;
    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * 5f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime * 5f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * Time.deltaTime * 5f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Time.deltaTime * 5f;
        }
    }
}
