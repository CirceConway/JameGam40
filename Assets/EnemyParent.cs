using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyParent : MonoBehaviour
{

    //Stats
    protected float health;
    protected float damage;
    protected float moveSpeed;
    protected float attackSpeed;
    protected float projSpeed;

    //protected Rigidbody2D rb;

    protected GameObject player;

    protected Controller controller;

    

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(Attack);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void setBasics(Controller controller, GameObject player, float health, float damage, float moveSpeed, float attackSpeed)
    {
        this.controller = controller;
        this.player = player;

        this.health = health;
        this.damage = damage;
        this.moveSpeed = moveSpeed;
        this.attackSpeed = attackSpeed;

    }

    //Always destroys enemy, each enemy type will have added behavior
    public virtual void OnDeath()
    {
        //Destroy(GameObject);
    }

    protected virtual IEnumerator Attack()
    {
        yield return new WaitForSeconds(1 / attackSpeed);
    }

}
