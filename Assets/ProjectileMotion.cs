using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMotion : MonoBehaviour
{

    public float secondsAlive = 1f;

    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 direction;

    void Start()
    {
        Destroy(gameObject, secondsAlive);
    }

    void FixedUpdate()
    {
        direction.x = transform.right.x;
        direction.y = transform.right.y;

        rb.MovePosition(rb.position + (direction * Time.fixedDeltaTime * moveSpeed));
    }

}
