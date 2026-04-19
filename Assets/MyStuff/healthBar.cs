using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class healthBar : MonoBehaviour
{
    public Slider healthSlider;
    public Slider easedHealthSlider;
    public float maxHealth = 100f;
    public float health;
    private float lerpSpeed = 0.05f;
    public string gameOverScreen;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (healthSlider.value != health)
        {
            healthSlider.value = health;
        }

        if (healthSlider.value != easedHealthSlider.value)
        {
            easedHealthSlider.value = Mathf.Lerp(easedHealthSlider.value, health, lerpSpeed);
        }

        if (health <= 0)
        {
            SceneManager.LoadScene(gameOverScreen);
        }
    }
}
