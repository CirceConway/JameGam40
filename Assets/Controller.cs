using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject mainCamera;

    public GameObject deer;

    //Deer Stats
    public float deerHealth = 10f;
    public float deerDamage = 5f;
    public float deerSpeed = 5f;
    public float deerAttackSpeed = 2f;
    public float deerProjSpeed = 5f;

    GameObject player;
    

    // Start is called before the first frame update
    void Start()
    {
        player = Instantiate(playerPrefab);

        GameObject g1 = Instantiate(deer, transform.position, transform.rotation);
        g1.GetComponent<DeerAI>().setBasics(this, player, deerDamage, deerSpeed, deerAttackSpeed, deerProjSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        mainCamera.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -7f);
    }
}
