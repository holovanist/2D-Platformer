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
    float SpellDirection;
    float xInput;
    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale ==1)
        {
            timer += Time.deltaTime; //0.016667 = 60fps
                                 //if you click
            if (Input.GetButton("Fire1") && timer > ShootDelay)
            {
                timer = 0;
                xInput = Input.GetAxisRaw("Horizontal");

                if (xInput != 0)
                {
                    if(xInput == 1)
                    {
                        GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
                        bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(xInput, 0);
                    }
                }
                else
                { 
                    if( xInput == -1)
                    {
                        GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
                        bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(xInput, 0);
                    }
                }
                //spawn in the bullet
                
                //Push the bullet towards the mouse
                //bullet.GetComponent<Rigidbody2D>().velocity = mouseDir * BulletSpeed;
                //Destroy(bullet, BulletLifetime);
            }
        }
    }
}
