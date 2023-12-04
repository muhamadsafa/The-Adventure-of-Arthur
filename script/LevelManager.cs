using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static LevelManager instance;
    public Transform respawnPoint;
    public GameObject playerPre;



    private void Awake()
    {
        instance = this;

    }
    public void respawn()
    {
        Instantiate(playerPre, respawnPoint.position, Quaternion.identity);
    }
    public void Restart()
    {
        // Restart The Scene
        
        // Position
        // Health
        
    }
}
