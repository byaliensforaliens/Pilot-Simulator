using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;

    // Adjusted starting point for camera
    private Vector3 offset= new Vector3(21, 0, 0);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Added main camera offset
        transform.position = plane.transform.position + offset;
    }
}
