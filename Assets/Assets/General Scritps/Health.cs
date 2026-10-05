using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] PlayerData data;
    [SerializeField] Image backgroundHealthBarSprite;
    [SerializeField] Image healthBarSprite;
    [SerializeField] Image ghostHealthBarSprite;
    [SerializeField] float ghostFollowSpeed = 2f;

    private float maxHealth;
    private float currentHealth;

    void Start()
    {
        maxHealth = data.MaxHealth;
        currentHealth = maxHealth;
        HealthBarUpdate(maxHealth, currentHealth);
        ghostHealthBarSprite.fillAmount = healthBarSprite.fillAmount;
    }

    void Update()
    {
        HealthBarUpdate(maxHealth, currentHealth);
        GhostHealthBarUpdate();
    }

    //Actual HP
    public void HealthBarUpdate(float maxHealth, float currentHealth)
    {
        healthBarSprite.fillAmount = maxHealth > 0f
            ? Mathf.Clamp01(currentHealth / maxHealth)
            : 0f;
    }

    //Ghost HP bar
    public void GhostHealthBarUpdate()
    {
        ghostHealthBarSprite.fillAmount = Mathf.Lerp(
            ghostHealthBarSprite.fillAmount,
            healthBarSprite.fillAmount,
            ghostFollowSpeed * Time.deltaTime);
    }

    public void TakeDamage()
    {
        currentHealth = Mathf.Max(0f, currentHealth - 1f);
        Debug.Log("Took 1 Damage");
        HealthBarUpdate(maxHealth, currentHealth);

        if (currentHealth <= 0)
        {
            Debug.Log("You lost");
        }
    }
}
