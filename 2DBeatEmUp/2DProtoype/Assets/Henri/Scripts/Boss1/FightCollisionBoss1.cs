using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightCollisionBoss1 : MonoBehaviour
{

    public PlayerMovement playerMovement;

    public int dealDamage;
    public int scareSanity;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            playerMovement = collision.gameObject.GetComponent<PlayerMovement>();

            playerMovement.SanityLoss(scareSanity);
            playerMovement.GetHit();
            playerMovement.PlayerHealth(dealDamage);
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
