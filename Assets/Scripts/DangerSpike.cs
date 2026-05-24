using UnityEngine;

public class SpikeDamage : MonoBehaviour
{
    public const int DamageAmount = 10;

    public HealthBarScript healthBar;

    void Awake()
    {
        if (healthBar == null)
        {
            healthBar = FindObjectOfType<HealthBarScript>();
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            healthBar.TakeDamage(DamageAmount);
        }
    }
}
