using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{

    public GameObject gameOverMenu;
   
    public void Setup()
    {

        gameOverMenu.SetActive(true);
    }
    
    public void RestartButton()
    {
        SceneManager.LoadScene("1-1");
    }
    
}
