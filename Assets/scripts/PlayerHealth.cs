using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

    public int startingHealth = 100;    
    public int currentHealth;   
    public int damage;
    public Image imageDamage;
    public GameObject lifeBar;
    public Slider healthSlider;
    public float flashSpeed = 5f;

    Color flashColour = new Color(1f, 0f, 0f, 0.1f);
    bool damaged;

    void Awake()
    {
        currentHealth = startingHealth;
    }

    void Update()
    {
        if (currentHealth == 0)
        {
            lifeBar.GetComponent<Image>().color = new Color(0f, 0f, 0f, 0f);
            imageDamage.color = lifeBar.GetComponent<Image>().color;
            Time.timeScale = 0;
        }
        if (damaged)
        {
            imageDamage.color = flashColour;
        }
        else
        {
            imageDamage.color = Color.Lerp (imageDamage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        damaged = false;
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        healthSlider.value = currentHealth;
        damaged = true;

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject, 0);
            TakeDamage(damage);
        }
    }
}
