using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPace : MonoBehaviour
{
    GameObject player;
    [SerializeField]
    float chaseSpeed = 5.0f;
    [SerializeField]
    float ChaseRange = 5.0f;
    float paceDir = -1;
    public float paceSpeed = 4;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vel = rb.velocity;
        vel.x = paceDir * paceSpeed;
        rb.velocity = vel;
        //the chase direction is destination - enemy starting position
        Vector3 playerPosition = player.transform.position;
        Vector3 ChaseDir = playerPosition - transform.position;
        if (ChaseDir.magnitude < ChaseRange)
        {
            //move towards the player
            ChaseDir.Normalize();
            rb.velocity = new Vector2(1, 0) * chaseSpeed * ChaseDir;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            paceDir *= -1;
        }
    }
}
