using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    [SerializeField]
    float health, maxHealth = 10f;

    [SerializeField]
    FloatingHealthBar healthBar;
    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;
        healthBar.UpdateHealthBar(health, maxHealth);
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(this.gameObject);
    }

    private void Awake()
    {
        healthBar = GetComponentInChildren<FloatingHealthBar>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject == true)
        {
            TakeDamage(1);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        healthBar.UpdateHealthBar(health, maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
