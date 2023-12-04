using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ProjectTileLaunch : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject projectilePrefab;
    public Transform launchPoint;

    public float shootTime;
    public float shootCounter;

    void Start()
    {
        shootCounter = shootTime;
    }


    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && shootCounter <= 0)
        {
            Instantiate(projectilePrefab, launchPoint.position, Quaternion.identity);
            shootCounter = shootTime;
        }
        shootCounter -= Time.deltaTime;
    }

}
