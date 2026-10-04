using UnityEngine;
using UnityEngine.UI;

public class WinningPlatform : MonoBehaviour
{
    //Before using the script assign these variables to narrow search time for specific functions
    //easier visibility to see which script is connected to where and what its being used for
    //Directly navigates developers to the component/function/script affected. <3
    [SerializeField] Detection detection;
    [SerializeField] GameObject WinnerText;

    // Update is called once per frame
    void Update()
    {

        if (detection.distance <= 2 )
        {   
           WinnerText.SetActive(true);
           Debug.Log("Winning Platform");
        }

        else
        {
            if (detection.distance >=2)
            WinnerText.SetActive(false);
        }

    }
}
