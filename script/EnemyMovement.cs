using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] PatrolPoint;
    public float moveSpeed;
    public int patrolDestination;

    // agar enemy mengejar
    public Transform playerTransform;
    public bool isChasing;
    public float chaseDistance;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (isChasing)
        {
            if(transform.position.x > playerTransform.position.x)
            {
                transform.position += Vector3.left * moveSpeed * Time.deltaTime;
            }
            if (transform.position.x < playerTransform.position.x)
            {
                transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            }
        }
        else
        {
            if(Vector2.Distance(transform.position,playerTransform.position) < chaseDistance)
            {
                isChasing = true;
            }

            if (patrolDestination == 0)
            {
              
                transform.position = Vector2.MoveTowards(transform.position, PatrolPoint[0].position, moveSpeed * Time.deltaTime);
                
                if (Vector2.Distance(transform.position, PatrolPoint[0].position) < .2f)
                {
                    patrolDestination = 1;
                    
                }
                
            }
            if (patrolDestination == 1)
            {
            
                transform.position = Vector2.MoveTowards(transform.position, PatrolPoint[1].position, moveSpeed * Time.deltaTime);
                if (Vector2.Distance(transform.position, PatrolPoint[1].position) < .2f)
                {
                    patrolDestination = 0;
                }
                
            }
        }

       
    }
    
}
