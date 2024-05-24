using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyParent : MonoBehaviour
{

    //Stats
    public int health;
    public int damage;
    public float moveSpeed;
    public float attackSpeed;

    public GameObject player;

    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(Attack);
    }

    // Update is called once per frame
    void Update()
    {
        
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
