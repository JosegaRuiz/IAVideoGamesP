using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class scriptLeader2 : MonoBehaviour
{

	public float speed;
	public Text countText;

	// Leader1's health
	public int maxHealth = 100;
	public int currentHealth;
	public HealthBar healthBar;

	//Coin's counter
	private int count;

	// Start is called before the first frame update
	void Start()
	{
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
		speed = 7f;
		count = 0;
		SetCountText();
	}

	// Update is called once per frame
	void Update()
	{
		//Acción para descrementar la vida del jugador
		//AQUI
		if (Input.GetKeyDown(KeyCode.Space))
		{
			TakeDamage(20);
		}
		//Acción para descrementar la vida del jugador
		transform.Translate(speed * Input.GetAxis("HorizontalArrow") * Time.deltaTime, 0f, speed * Input.GetAxis("VerticalArrow") * Time.deltaTime);
	}

	void TakeDamage(int damage)
	{
		currentHealth -= damage;
		healthBar.SetHealth(currentHealth);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Pick Up"))
		{
			other.gameObject.SetActive(false);
			count += 1;
			SetCountText();
		}
	}

	void SetCountText()
	{
		countText.text = count.ToString() + " Points";
		//if (count >= 10)
		//{
		//    winText.text = "WIN";
		//}
	}
}
