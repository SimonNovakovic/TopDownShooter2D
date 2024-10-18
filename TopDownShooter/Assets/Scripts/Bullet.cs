using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Hazard"))
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Player") != true)
        {
            Destroy(gameObject);
        }
    }


}
