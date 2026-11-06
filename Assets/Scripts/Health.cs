using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public GameObject health_UI;
    public int health;
    public int maxHealth = 10;
    public Slider slider;

    public GameObject gameOverScreen;
    public Camera mainCamera;

    void Start()
    {
        health = maxHealth;
        slider.maxValue = maxHealth;
        slider.value = health;

        gameOverScreen.SetActive(false);

    }


    void Updaate()
    {

    }

    public void TekeDamage(int amount)
    {
        health -= amount;
        slider.value = health;

        if (health <= 0)
        {
                        Die();

            Destroy(gameObject);
        }
    }
    void Die(){
        health=0;
        health_UI.SetActive(false);
        gameOverScreen.SetActive(true);
        mainCamera.transform.SetParent(null);
        mainCamera.gameObject.SetActive(true);
        Time.timeScale=0f;

    }
}


