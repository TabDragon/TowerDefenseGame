﻿using UnityEngine;

public class Enemy : MonoBehaviour
{
    [HideInInspector]
    public float speed;

    public float startSpeed = 10f;
    public float health     = 100f;
    public int worth        = 50;
    public GameObject deathEffect;

    private void Start()
    {
        speed = startSpeed;
    }

    public void TakeDamage(float amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Die();
        }
    }

    public void Slow(float pct)
    {
        speed = startSpeed * (1f - pct);
    }

    void Die ()
    {
        PlayerStats.money += worth;

        GameObject effect = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);

        Destroy(gameObject);
    }
}
