using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class easterEggTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public EasterEggScreen Eg;
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Eg.Setup();
            
            
        }
    }
}
