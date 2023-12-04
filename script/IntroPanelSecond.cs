using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroPanelSecond : MonoBehaviour
    
{
    public GameObject secondIntro;
    public GameObject three;

    // Start is called before the first frame update
    public void MulaiBut()
    {
        secondIntro.SetActive(false);
        three.SetActive(true);

    }
}
