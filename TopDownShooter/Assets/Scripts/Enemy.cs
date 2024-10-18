using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameObject player;

    [SerializeField] float enemySpeed = 1f;
    Rigidbody2D rb;
    bool isTouchingBullet = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("PlayerBox");
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            Vector2 direction = (player.transform.position - transform.position).normalized;
            rb.MovePosition(rb.position + direction * enemySpeed * Time.fixedDeltaTime);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            isTouchingBullet = true;
        }
    }

}
