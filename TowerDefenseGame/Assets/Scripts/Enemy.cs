﻿using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [HideInInspector]
    public float speed;

    public float    startSpeed  = 10f;
    public float    startHealth      = 100f;
    private float   health;
    public int      worth       = 50;
    public GameObject deathEffect;

    [Header("Unity Stuff")]
    public Image healthBar;

    private void Start()
    {
        speed = startSpeed;
        health = startHealth;
    }

    public void TakeDamage(float amount)
    {
        health -= amount;

        healthBar.fillAmount = health / startHealth;

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

        WaveSpawner.EnemiesAlive--;

        Destroy(gameObject);
    }
}
