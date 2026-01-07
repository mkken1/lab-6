using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Text HealthText;
    private player player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        currentHealth = maxHealth;
    }
    void Start()
    {
        player = FindFirstObjectByType<player>();
        HealthText.text="Здоровье: "+currentHealth.ToString();
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        HealthText.text="Здоровье: "+currentHealth.ToString();
        Debug.Log("health: по шапке получил");

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
