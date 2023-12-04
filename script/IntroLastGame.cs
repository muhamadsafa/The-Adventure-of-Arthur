using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroLastGame : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject lastIntro;
    public GameObject tutorpanel;

    public void startgame()
    {
        lastIntro.SetActive(false);
        tutorpanel.SetActive(true);
    }
}
