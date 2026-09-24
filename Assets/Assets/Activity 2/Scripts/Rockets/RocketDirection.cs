using System;

using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] GameObject rocketPrefab;
    [SerializeField] Transform player;


    [SerializeField] float speed = 5f;
    [SerializeField] float RocketTime = 5f;
    [SerializeField] float Timer = 3f;
    [SerializeField] RocketAmountData rocketAmount;

    void Update()
    {
     Timer -= Time.deltaTime;   

    if (Timer <= 0)
        {
            Timer = 3f;
            RocketShoot();
        }

    }

    void RocketShoot()
    {
        Vector3 origin = player.position;

        float spacing = 360f / rocketAmount.rocketAmount;
        float offset = spacing / 2f;

        for (int i = 0; i <rocketAmount.rocketAmount; i++)
        {
            float angle = offset + (spacing * i);

            GameObject Rocket = Instantiate(rocketPrefab, origin, Quaternion.identity);
            Rocket.GetComponent<RocketMovement>().Init(angle, origin, speed, RocketTime);
        }
    }




}
