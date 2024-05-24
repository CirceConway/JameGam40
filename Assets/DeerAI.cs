using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeerAI : EnemyParent
{
    Vector3 lookDirection;

    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Attack());
    }

    void FixedUpdate()
    {
        lookDirection = player.GetComponent<Rigidbody2D>().position - rb.position;
        rb.rotation = -1 * Mathf.Atan2(lookDirection.x, lookDirection.y) * Mathf.Rad2Deg + 90;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override IEnumerator Attack()
    {
        while (true) 
        {
            Instantiate(projectile, transform.position, transform.rotation);

            yield return new WaitForSeconds(1 / attackSpeed);
        }
        

        
    }
}
