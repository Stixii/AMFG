using UnityEngine;

public class Pathing : MonoBehaviour
{
    
    [SerializeField] Transform[] pathPoints;
    [SerializeField] Enemy enemy;
    [SerializeField] Transform enemyPosition;
    [SerializeField] EnemyData enemyData;

    private float speed;

    void Start()
    {
        speed = enemyData.Speed;
    }


    void Update()
    {
        if (pathPoints == null || pathPoints.Length < 4 || enemyPosition == null)
            return;

        float t = Mathf.Repeat(Time.time * speed, 1f);

        Vector3 p0 = pathPoints[0].position;
        Vector3 p1 = pathPoints[1].position;
        Vector3 p2 = pathPoints[2].position;
        Vector3 p3 = pathPoints[3].position;

        Vector3 bezierPoint =
            Mathf.Pow(1f - t, 3) * p0 +
            3f * Mathf.Pow(1f - t, 2) * t * p1 +
            3f * (1f - t) * Mathf.Pow(t, 2) * p2 +
            Mathf.Pow(t, 3) * p3;

     enemyPosition.position = bezierPoint;
    }
}
