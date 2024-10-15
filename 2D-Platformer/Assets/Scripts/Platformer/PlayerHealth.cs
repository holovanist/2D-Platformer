using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    string levelToLoad = "Lose";
    [SerializeField]
    float health = 10f;
    [SerializeField]
    float baseMaxHealth = 10f;
    [SerializeField]
    float BossDamage = 0.05f;
    [SerializeField]
    float EnemyDamage = 1f;
    [SerializeField]
    Image healthbar;
    [SerializeField]
    float iframes;
    float timer;
    void Start()
    {
        healthbar.fillAmount = health / baseMaxHealth;
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if (health < 1f)
        {
            SceneManager.LoadScene(levelToLoad);
            health = baseMaxHealth;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && timer >= iframes)
        {
            EnemyHit();
        }
        if (collision.gameObject.tag == "Boss" && timer >= iframes)
        {
            BossHit();
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && timer >= iframes)
        {
            EnemyHit();
        }
        if (collision.gameObject.tag == "Boss" && timer >= iframes)
        {
            BossHit();
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && timer >= iframes)
        {
            EnemyHit();
        }
        if (collision.gameObject.tag == "Boss" && timer >= iframes)
        {
            BossHit();
        }
        if (health <= baseMaxHealth)
        {
            if (collision.gameObject.tag == "Healing pool")
            {
                health += 1f;
                healthbar.fillAmount = health / baseMaxHealth;
            }
        }
        if (collision.gameObject.tag == "Enemy Bullet" && timer >= iframes)
        {
            BossHit();
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && timer >= iframes)
        {
            EnemyHit();
        }
        if (collision.gameObject.tag == "Boss" && timer >= iframes)
        {
            BossHit();
        }
    }
    public void EnemyHit()
    {
        health -= EnemyDamage;
        timer = 0;
        healthbar.fillAmount = health / baseMaxHealth;
    }
    public void BossHit()
    {
        health -= BossDamage;
        timer = 0;
        healthbar.fillAmount = health / baseMaxHealth;
    }
}