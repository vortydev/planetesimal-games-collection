﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] HealthBarD healthBar;
    public float damage = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Weapon")
            return;

        if (collision.tag == "Player")
        {
            healthBar.TakeDamage(damage);
        }
    }
}
