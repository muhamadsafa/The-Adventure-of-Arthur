using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int lifetime = 2;
    private float timer;

    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Enemy")
        {
            Destroy(target.gameObject); // Menhancurkan tag enemy
        }
        Destroy(gameObject); // Menghancurkan benda sendiri
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > lifetime)
        {
            timer = 0;
            Destroy(gameObject);
        }
        
    }
}
