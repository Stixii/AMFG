using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    private Enemy enemy;
    [SerializeField] GameObject coinPrefab;




    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        if (enemy = GetComponent<Enemy>())
        {
            Instantiate(coinPrefab,transform.position, Quaternion.identity);
        }
    }
}
