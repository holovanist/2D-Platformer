using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;
    [SerializeField]
    float BulletSpeed = 1.0f;
    [SerializeField]
    float BulletLifetime = 2.0f;
    float timer = 0;
    [SerializeField]
    float ShootDelay = 0.5f;
    public float xInput;
    int lastInput;
    // Update is called once per frame
    void Update()
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
        if (Time.timeScale ==1)
        {
            timer += Time.deltaTime; //0.016667 = 60fps
                                 //if you click
            if (Input.GetButton("Fire1") && timer > ShootDelay)
            {
                timer = 0;


                if (xInput != 0)
                {
                    if(xInput == 1)
                    {
                        GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
                        bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(xInput, 0) * BulletSpeed;
                        Destroy(bullet, BulletLifetime);
                    }
                    if (xInput == -1)
                    {
                        GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
                        bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(xInput, 0) * BulletSpeed;
                        Destroy(bullet, BulletLifetime);
                    }
                }
                else
                {
                    GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
                    bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(lastInput, 0) * BulletSpeed;
                    Destroy(bullet, BulletLifetime);
                }
                //spawn in the bullet
                
                //Push the bullet towards the mouse
                //bullet.GetComponent<Rigidbody2D>().velocity = mouseDir * BulletSpeed;

            }
        }
    }
}
