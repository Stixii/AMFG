using UnityEngine;
using UnityEngine.SceneManagement;

public class NoGoZoneDetection : MonoBehaviour
{   

    //Before using the script assign these variables to narrow search time for specific functions
    //easier visibility to see which script is connected to where and what its being used for
    //Directly navigates developers to the component/function/script affected. <3
    [SerializeField] Detection detection;
    [SerializeField] Transform Platform;
    [SerializeField] MeshRenderer Zone;
    [SerializeField] Material[]  Colors;
  
    float timer = 0f;
    Vector3 originalRotation;
    

    //Get starting positions
    void Start()
    {
        originalRotation = Platform.localEulerAngles;
    }


    //Shake platform
    void Update()
    {   

        //Changes color if too close and shalkes the platform if 2 seconds passed 
        //Start the Scene: "Start" 
        //Reset.
        if (detection.distance <= 5 )
        {   
            
            Zone.material = Colors[0];
           Debug.Log("Danger");

            float shakeX = Random.Range(-2f, 2f);
            float shakeZ = Random.Range(-2f, 2f);

            Platform.localEulerAngles = originalRotation + new Vector3(shakeX, 0f, shakeZ);

            timer += Time.deltaTime;
            if (timer >= 3f)
            {
                SceneManager.LoadScene("Activity-1");
            }
        }

        else 
        {   
            Zone.material = Colors[1];
            Debug.Log("Neutral");
        }
    }
}
