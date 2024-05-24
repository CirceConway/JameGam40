using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeerAI : EnemyParent
{
    /*
    float health;
    float damage;
    float moveSpeed;
    float attackSpeed;
    float projSpeed;
    */
    

    //GameObject player;

    //Controller controller;

    Vector3 lookDirection;
    
    public Rigidbody2D rb;
    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(player);
        StartCoroutine(Attack());
    }

    void FixedUpdate()
    {
        Debug.Log(player);
        lookDirection = player.GetComponent<Rigidbody2D>().position - rb.position;
        rb.rotation = -1 * Mathf.Atan2(lookDirection.x, lookDirection.y) * Mathf.Rad2Deg + 90;
    }

    public override void setBasics(Controller controller, GameObject player, float health, float damage, float moveSpeed, float attackSpeed)
    {
        this.controller = controller;
        
        this.player = player;
        //Debug.Log(this.player);
        this.health = health;
        this.damage = damage;
        this.moveSpeed = moveSpeed;
        this.attackSpeed = attackSpeed;

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
