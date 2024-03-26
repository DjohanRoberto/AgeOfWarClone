using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Troop : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;

    [SerializeField]
    private int bufferLength = 2;

    private float Timer = 0f;

    private bool Colliding = false;

    Rigidbody2D rb;

    /*[SerializeField]
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
    */

    private void OnCollisionStay2D(Collision2D collision)
    {
        GameObject other = collision.gameObject;
        /*if (other.gameObject.name != "Platform")
        {
            this.Colliding = true;
        }
        */
        if (other.CompareTag("Enemy"))
        {
            Timer += Time.deltaTime;
            if (Timer >= 1f)
            {
                Timer = 0f;
                other.GetComponent<EnemyBase>().TakeDamage(1);
            }
        }
    }

    public int getBufferLength()
    {
        return this.bufferLength;
    }


    private void Move()
    {
        var step = speed * Time.deltaTime;

        Vector3 right = new Vector3(100, 0, 0);

        transform.position = Vector3.MoveTowards(transform.position, right, step);

        if (transform.position.x > 30 || transform.position.y < -6)
        {
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // healthBar.UpdateHealthBar(health, maxHealth);
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (! this.Colliding)
        {
            this.Move();
        }
    }
}
