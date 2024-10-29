using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.XR;

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
    [SerializeField]
    float ShootDelay = 0.5f;
    public float xInput;
    public float yInput;
    int lastInput;
    private UpgradeChecker UpgradeChecker;
    private void Start()
    {
        xInput = 1;
        UpgradeChecker = GetComponent<UpgradeChecker>();
    }
    // Update is called once per frame
    void Update()
    {
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
            if (Input.GetButton("Fire1") && timer > ShootDelay)
            {
                timer = 0;


                if (yInput != 0)
                {
                    if (yInput == 1)
                    {
                        GameObject bullet = Instantiate(FireballLv1, transform.position, Quaternion.identity);
                        bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0 , yInput) * BulletSpeed;
                        Destroy(bullet, BulletLifetime);
                    }
                    if (yInput == -1)
                    {
                        GameObject bullet = Instantiate(FireballLv1, transform.position, Quaternion.identity);
                        bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, yInput) * BulletSpeed;
                        Destroy(bullet, BulletLifetime);
                    }
                }

                else if (xInput != 0)
                {
                    if (xInput == 1)
                    {
                        GameObject bullet = Instantiate(FireballLv1, transform.position, Quaternion.identity);
                        bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(xInput, 0) * BulletSpeed;
                        Destroy(bullet, BulletLifetime);
                    }
                    if (xInput == -1)
                    {
                        GameObject bullet = Instantiate(FireballLv1, transform.position, Quaternion.identity);
                        bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(xInput, 0) * BulletSpeed;
                        Destroy(bullet, BulletLifetime);
                    }
                }
                else
                {
                    GameObject bullet = Instantiate(FireballLv1, transform.position, Quaternion.identity);
                    bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(lastInput, 0) * BulletSpeed;
                    Destroy(bullet, BulletLifetime);
                }
            }
        }
    }
    public void ATK2()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        if (xInput == 1)
        {
            lastInput = 1;
        }
        if (xInput == -1)
        {
            lastInput = -1;
        }
        if (Time.timeScale == 1)
        {
            timer += Time.deltaTime;
            if (Input.GetButton("Fire1") && timer > ShootDelay)
            {
                timer = 0;


                if (xInput != 0)
                {
                    if (xInput == 1)
                    {
                        GameObject bullet = Instantiate(FireballLv2, transform.position, Quaternion.identity);
                        bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(xInput, 0) * BulletSpeed;
                        Destroy(bullet, BulletLifetime);
                    }
                    if (xInput == -1)
                    {
                        GameObject bullet = Instantiate(FireballLv2, transform.position, Quaternion.identity);
                        bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(xInput, 0) * BulletSpeed;
                        Destroy(bullet, BulletLifetime);
                    }
                }
                else
                {
                    GameObject bullet = Instantiate(FireballLv2, transform.position, Quaternion.identity);
                    bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(lastInput, 0) * BulletSpeed;
                    Destroy(bullet, BulletLifetime);
                }
            }
        }
        yInput = Input.GetAxisRaw("Vertical");
        if (Time.timeScale == 1)
        {
              timer += Time.deltaTime;
            if (Input.GetButton("Fire1") && timer > ShootDelay)
            {
                timer = 0;
                if (yInput != 0)
                {
                    if (yInput == 1)
                    {
                        GameObject bullet = Instantiate(FireballLv1, transform.position, Quaternion.identity);
                        bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, yInput) * BulletSpeed;
                        Destroy(bullet, BulletLifetime);
                    }
                    if (yInput == -1)
                    {
                        GameObject bullet = Instantiate(FireballLv1, transform.position, Quaternion.identity);
                        bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, yInput) * BulletSpeed;
                        Destroy(bullet, BulletLifetime);
                    }
                }
            }
        }
    }

}
