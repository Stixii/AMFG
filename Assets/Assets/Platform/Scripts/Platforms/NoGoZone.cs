using UnityEngine;
using UnityEngine.SceneManagement;

public class NoGoZone : MonoBehaviour
{
    [SerializeField] Detection ruhroh;
    [SerializeField] Transform Platform;
    [SerializeField] Renderer Zone;
    [SerializeField] Material[]  Colors;
  
    float timer = 0f;
    Vector3 originalRotation;
    
    void Start()
    {
        originalRotation = Platform.localEulerAngles;
    }

    void Update()
    {
        if (ruhroh.distance <= 5 )
        {   
            Zone.material = Colors[0];
           Debug.Log("Neutral COLOR");

            float shakeX = Random.Range(-2f, 2f);
            float shakeZ = Random.Range(-2f, 2f);

            Platform.localEulerAngles = originalRotation + new Vector3(shakeX, 0f, shakeZ);


            timer += Time.deltaTime;
            if (timer >= 3f)
            {
                SceneManager.LoadScene("Start");
            }
        }

        else 
        {   
            Zone.material = Colors[1];
            Debug.Log("RED COLOR");
        }

       

    }
}
