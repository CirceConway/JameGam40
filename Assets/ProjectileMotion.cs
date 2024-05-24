using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMotion : MonoBehaviour
{

    public float secondsAlive = 1f;

    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    public Controller controller;

    Vector2 direction;

    float damage;

    void Start()
    {
        damage = 5f;
        Destroy(gameObject, secondsAlive);
    }

    public void setStats(float damage, float moveSpeed)
    {
        this.damage = damage;
        this.moveSpeed = moveSpeed;
    }

    void FixedUpdate()
    {
        direction.x = transform.right.x;
        direction.y = transform.right.y;

        rb.MovePosition(rb.position + (direction * Time.fixedDeltaTime * moveSpeed));
    }

    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag.Equals("Player"))
        {
            target.gameObject.GetComponent<PlayerMovement>().TakeDamage(damage);
            Destroy(gameObject);
        }
    }

}
