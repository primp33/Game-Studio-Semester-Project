using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
	public int maxHealth = 100;
	public int currentHealth;
	public int damage = 20;
	//public int pluslife = 20;
	public GameObject dontdestroy;
	private levelSystem levelsystem;
	private int level;
	private Animator playeranim;

	public HealthBar healthBar;

	// Start is called before the first frame update
	void Start()
	{
        dontdestroy = GameObject.FindWithTag("DontDestroy");
        levelsystem = dontdestroy.GetComponent<levelSystem>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
		level = levelsystem.level;
		playeranim = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{
		if (!(level == levelsystem.level))
		{
            level = levelsystem.level;
            maxHealth += levelsystem.level * 50;
		}
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
		//if (collision.gameObject.tag == "healingitem")
		//{
		//	Healing(pluslife);
		//	collision.gameObject.SetActive(false);
		//}
	}

	void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);

		playeranim.Play("Base Layer.be attack");
	}

	void Healing(int pluslife)
	{
		currentHealth += pluslife;
		healthBar.SetHealth(currentHealth);
	}
}
