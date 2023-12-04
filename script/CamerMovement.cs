using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float FollowSpeed = 2f;
    public Transform target;
    public float yOffset = 1f;
    
    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(target.position.x, target.position.y + yOffset, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed * Time.deltaTime);
        
    }
}
