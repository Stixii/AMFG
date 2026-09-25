using UnityEngine;


[CreateAssetMenu(fileName = "TurretData", menuName = "Data/TurretData")]
public class TurretData : ScriptableObject
{

    [SerializeField] private float range;
    [SerializeField] private float attackRate;
    [SerializeField] private float bulletSpeed;


    public float Range 
    {
        get => range;
        set => range = value;
    }

    public float AttackRate
    {
       get => attackRate;
       set => attackRate = value; 
    }

    public float BulletSpeed
    {
        get => bulletSpeed;
        set => bulletSpeed = value;
    }



}
