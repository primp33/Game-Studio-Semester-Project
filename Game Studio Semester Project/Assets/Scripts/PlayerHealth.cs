using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
	public int maxHealth = 100;
	public int currentHealth;
	public int damage = 20;
	public int pluslife = 20;

	public HealthBar healthBar;

	// Start is called before the first frame update
	void Start()
	{
        currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
	}

	// Update is called once per frame
	void Update()
	{
        if (currentHealth == 0)
        {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
        
	}

	void OnCollisionEnter2D(Collision2D collision)
    {
		if ((collision.gameObject.tag == "enemy") || (collision.gameObject.name == "Roaming Enemy"))

        {
			TakeDamage(damage);

		}
		if (collision.gameObject.tag == "healingitem")
		{
			Healing(pluslife);
			collision.gameObject.SetActive(false);
		}
	}

	void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}

	void Healing(int pluslife)
	{
		currentHealth += pluslife;
		healthBar.SetHealth(currentHealth);
	}
}
