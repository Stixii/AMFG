using UnityEngine;
using UnityEngine.UI;

public class WinningPlatform : MonoBehaviour
{
    [SerializeField] Detection YuhUh;
    [SerializeField] GameObject Winner;

    // Update is called once per frame
    void Update()
    {

        if (YuhUh.distance <= 5 )
        {   
           Winner.SetActive(true);
           Debug.Log("Winning Platform");
        }

        else
        {
            if (YuhUh.distance >=5)
            Winner.SetActive(false);
        }

    }
}
