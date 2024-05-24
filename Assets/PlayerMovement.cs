using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float maxHealth = 10;

    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    float health;

    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + (movement * moveSpeed * Time.fixedDeltaTime));
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        //Play damage sound
        //Play damage animation

        Debug.Log("HIT");

        if (health < 0)
        {
            Die();
        }
    }

    void Die()
    {
        //End Game

    }
}
