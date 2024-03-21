using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Troop : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;

    [SerializeField]
    public int bufferLength = 2;

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
    // Start is called before the first frame update
    void Start()
    {
        // healthBar.UpdateHealthBar(health, maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        var step = speed * Time.deltaTime;

        Vector3 right = new Vector3(100, 0, 0);

        transform.position = Vector3.MoveTowards(transform.position, right , step);

        if (transform.position.x > 30 || transform.position.y < -6) 
        {
            Destroy(this.gameObject);
        }

    }
}
