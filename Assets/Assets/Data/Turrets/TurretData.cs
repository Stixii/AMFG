using UnityEngine;


[CreateAssetMenu(fileName = "TurretData", menuName = "Data/TurretData")]
public class TurretData : ScriptableObject
{

    [SerializeField] private float range;
    [SerializeField] private float attackRate;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float lifeTime;
    [SerializeField] private float turretDamage;

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

    public float Lifetime
    {
        get => lifeTime;
        set => lifeTime = value;
    }

    public float TurretDamage
    {
        get => turretDamage;
        set => turretDamage = value;
    }

}
