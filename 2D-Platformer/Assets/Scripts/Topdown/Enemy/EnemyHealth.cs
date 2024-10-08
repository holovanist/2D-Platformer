using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    float health = 5f;
    [SerializeField]
    float BaseMaxHp = 5f;
    Image healthbar;
    //reduce the enemy health when hit by player bullet
    //destroy the enemy if health is zero
    // Start is called before the first frame update
    void Start()
    {
       //healthbar.fillAmount = health / BaseMaxHp;
        healthbar = GetComponentsInChildren<Image>()[1];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerBullet")
        {
            health -= 1;
            healthbar.fillAmount = health / BaseMaxHp;
            if (health < .2f)
            {
                Destroy(gameObject);
            }
        }
    }
}
