using System;

using UnityEngine;

public class RocketDirection : MonoBehaviour
{
    //Before using the script assign these variables to narrow search time for specific functions
    //easier visibility to see which script is connected to where and what its being used for
    //Directly navigates developers to the component/function/script affected. <3

    [SerializeField] GameObject rocketPrefab;
    [SerializeField] Transform player;

    [Header("Data")]
    [SerializeField] float speed = 5f;
    [SerializeField] float RocketTime = 5f;
    [SerializeField] float Timer = 3f;
    [SerializeField] RocketAmountData rocketAmount;


    //Calls the function when the timer hits 0 then sets the timer to 3 again
    void Update()
    {
     Timer -= Time.deltaTime;   

    if (Timer <= 0)
        {
            Timer = 3f;
            RocketShoot();
        }

    }

    //Function that shoots the rockets from the player
    void RocketShoot()
    {
        Vector3 origin = player.position;

        float spacing = 360f / rocketAmount.rocketAmount;
        float offset = spacing / 1f;

        for (int i = 0; i <rocketAmount.rocketAmount; i++)
        {
            float angle = offset + (spacing * i);

            GameObject Rocket = Instantiate(rocketPrefab, origin, Quaternion.Euler(0f,0f,angle));
            Rocket.GetComponent<RocketMovement>().Init(angle, origin, speed, RocketTime);
        }
    }
}
