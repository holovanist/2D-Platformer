using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
                if(Input.GetKeyDown(KeyCode.D))
                {

                }
                if (Input.GetKeyDown(KeyCode.A))
                {

                }
                if (Input.GetKeyDown(KeyCode.S))
                {

                }
                if (Input.GetKeyDown(KeyCode.W))
                {

                }
                //spawn in the bullet
                GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
                //Push the bullet towards the mouse
                //bullet.GetComponent<Rigidbody2D>().velocity = mouseDir * BulletSpeed;
                Destroy(bullet, BulletLifetime);
            }
        }
    }
}
