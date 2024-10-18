using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    [SerializeField] int playerHealth = 5;
    [SerializeField] float invincibilityTime = 2f;
    bool invicible = false;

    void DisableInvincibility()
    {
        invicible = false;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Hazard"))
        {
            if (invicible == true)
            {
                return;
            }
            if (playerHealth > 0)
            {
                playerHealth--;
                invicible = true;
                Invoke("DisableInvincibility", invincibilityTime);
                Debug.Log("PlayerHealth: " + playerHealth);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }


}
