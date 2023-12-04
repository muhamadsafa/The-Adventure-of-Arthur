using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroPanel : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject introPanel;
    public GameObject IntroSecond;


    public void setup()
    {
        introPanel.SetActive(true);
    }
    public void Lanjut()
    {
        introPanel.SetActive(false);
        IntroSecond.SetActive(true);
    }
  
}
