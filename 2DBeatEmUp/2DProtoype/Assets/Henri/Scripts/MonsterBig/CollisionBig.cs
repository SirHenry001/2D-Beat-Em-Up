using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBig : MonoBehaviour
{

    public PlayerMovement playerMovement;
    public BigEnemyAi bigEnemy;

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
            Instantiate(bigEnemy.hitAudio, bigEnemy.audioSpawnEnemy.transform.position, bigEnemy.audioSpawnEnemy.transform.rotation);
            Instantiate(bigEnemy.hitAudio2, bigEnemy.audioSpawnEnemy.transform.position, bigEnemy.audioSpawnEnemy.transform.rotation);
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
