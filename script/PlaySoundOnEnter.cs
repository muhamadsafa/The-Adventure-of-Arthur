using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnEnter : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource source;
    Collider2D soundTrigger;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
        soundTrigger = GetComponent<Collider2D>();
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            source.Play();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            source.Stop();
        }
    }
}
