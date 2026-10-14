
using UnityEngine;

public class TurretDetection : MonoBehaviour
{   

    //Detection for player and target

   [SerializeField] Transform startingPoint;
   
   [SerializeField] Transform endingPoint;
   [SerializeField] TurretData turretRangeData;
   [SerializeField] private bool isInRange;

    private float range; 
    public float distance;

    void Awake()
    {
        range = turretRangeData.Range;
    }

    //Updates the distance and shows it in the logs
    void Update()
    {
        distance =  Vector3.Distance(startingPoint.position, endingPoint.position);
        //Debug.Log(distance); 
        isInRange = distance <= range;
    }

    public bool IsInRange{get; private set;}

}
