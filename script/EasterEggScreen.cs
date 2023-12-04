using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EasterEggScreen : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject EasterEgg;

    public void Setup()
    {

        EasterEgg.SetActive(true);
    }

    public void LanjutButt()
    {
        EasterEgg.SetActive(false);
    }

}

