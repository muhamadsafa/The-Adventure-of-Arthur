using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectTile : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody2D projectileRb;
    public float speed;
    public float projectilelife;
    public float projecttileCount;


    void Start()
    {
        projecttileCount = projectilelife;

    }

    // Update is called once per frame
    void Update()
    {
        projecttileCount -= Time.deltaTime;
        if(projecttileCount <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void FixedUpdate()
    {
        projectileRb.velocity = new Vector2(speed, projectileRb.velocity.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
        Destroy(gameObject);
    }
}
