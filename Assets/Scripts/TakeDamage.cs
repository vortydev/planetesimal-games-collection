using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    HealthBarD healthbar;
    PlayerControllerV2 playerController;

    private void Start()
    {
        playerController = GetComponentInParent<PlayerControllerV2>();
        healthbar = GetComponentInParent<HealthBarD>();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            healthbar.TakeDamage(playerController.damageTaken);
        }
    }
}
