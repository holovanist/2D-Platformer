using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.UI;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    GameObject FireballLv1;
    [SerializeField]
    GameObject FireballLv2;
    [SerializeField]
    float BulletSpeed = 1.0f;
    [SerializeField]
    float BulletLifetime = 2.0f;
    float timer = 0;
    float timer2 = 0;
    [SerializeField]
    float ShootDelay = 0.5f;
    float xInput;
    float yInput;
    public int lastInput;
    int counter;


    public float Mana = 10;
    public float MaxMana { get; set; }
    [SerializeField]
    float RechargeAmount;
    [SerializeField]
    float ManaUsage;

    [SerializeField]
    Image Manabar;

    private UpgradeChecker UpgradeChecker;
    private void Start()
    {
        MaxMana = Mana;
        xInput = 1;
        UpgradeChecker = GetComponent<UpgradeChecker>();
        Manabar.fillAmount = Mana / MaxMana;
    }
    // Update is called once per frame
    void Update()
    {
        timer2 += Time.deltaTime;
        if (Mana <= 10 && timer2 >= 2)
        {
            timer2 = 0;
            
            Mana += RechargeAmount;
            Manabar.fillAmount = Mana / MaxMana;
        }
        if (UpgradeChecker.MaxManaIncrease == true && counter <1)
        {
            MaxMana *= 2;
            counter++;
        }
        if (UpgradeChecker.FireballUpgrade == false)
        {
            ATK();
        } 
        else if (UpgradeChecker.FireballUpgrade == true)
        {   
            ATK();
        }
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");
        if (xInput == 1)
        {
            lastInput = 1;
        }
        if (xInput == -1)
        {
            lastInput = -1;
        }
        
    }
    public void ATK()
    {
        
        if (Time.timeScale == 1)
        {
            timer += Time.deltaTime; 
            if (Input.GetButton("Fire1") && timer > ShootDelay && Mana >= 1)
            {
                timer = 0;
                Mana -= ManaUsage;
                Manabar.fillAmount = Mana / MaxMana;

                if (yInput != 0)
                {
                        GameObject ybullet = Instantiate(FireballLv1, transform.position, Quaternion.identity);
                        ybullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0 , yInput) * BulletSpeed;
                        Destroy(ybullet, BulletLifetime);
                }

                else if (xInput != 0)
                {
                        GameObject xbullet = Instantiate(FireballLv1, transform.position, Quaternion.identity);
                        xbullet.GetComponent<Rigidbody2D>().velocity = new Vector2(xInput, 0) * BulletSpeed;
                        if (lastInput < 0 || xInput < 0)
                    {
                        xbullet.GetComponent<SpriteRenderer>().flipX = true;
                    }
                        Destroy(xbullet, BulletLifetime);
                }
                else if (xInput == 0)
                {
                    GameObject xbullet = Instantiate(FireballLv1, transform.position, Quaternion.identity);
                    xbullet.GetComponent<Rigidbody2D>().velocity = new Vector2(lastInput, 0) * BulletSpeed;
                    if (lastInput < 0 || xInput < 0)
                    {
                        xbullet.GetComponent<SpriteRenderer>().flipX = true;
                    }
                    Destroy(xbullet, BulletLifetime);
                }
            }
        }
    }
    public void ATK2()
    {
        yInput = Input.GetAxisRaw("Vertical");
        xInput = Input.GetAxisRaw("Horizontal");
        if (Time.timeScale == 1)
        {
            timer += Time.deltaTime;
            if (Input.GetButton("Fire1") && timer > ShootDelay)
            {
                timer = 0;
                Mana -= ManaUsage;
                Manabar.fillAmount = Mana / MaxMana;

                if (yInput != 0)
                {
                    GameObject ybullet = Instantiate(FireballLv1, transform.position, Quaternion.identity);
                    ybullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, yInput) * BulletSpeed;
                    Destroy(ybullet, BulletLifetime);
                }
                else if (xInput != 0)
                {
                    GameObject xbullet = Instantiate(FireballLv2, transform.position, Quaternion.identity);
                    xbullet.GetComponent<Rigidbody2D>().velocity = new Vector2(xInput, 0) * BulletSpeed;
                    if (lastInput < 0 || xInput < 0)
                    {
                        xbullet.GetComponent<SpriteRenderer>().flipX = true;
                    }
                    Destroy(xbullet, BulletLifetime);
                }
                else if (xInput == 0)
                {
                    GameObject xbullet = Instantiate(FireballLv1, transform.position, Quaternion.identity);
                    xbullet.GetComponent<Rigidbody2D>().velocity = new Vector2(lastInput, 0) * BulletSpeed;
                    if (lastInput < 0 || xInput < 0)
                    {
                        xbullet.GetComponent<SpriteRenderer>().flipX = true;
                    }
                    Destroy(xbullet, BulletLifetime);
                }
            }
        }
    }
}
