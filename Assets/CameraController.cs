using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]private Camera cam;
    public float height = 10.0f; // height of the camera above the ground
    public float damping = 1.0f; // smoothness of the camera movement
    void Start()
    {
        cam = GetComponent<Camera>();
        
    }
    void Update()
    {
         //updown
         if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(new Vector3(1, 0, 0) * Time.deltaTime * 100, Space.World);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(new Vector3(-1, 0, 0) * Time.deltaTime * 100, Space.World);
        }
        //left right
         if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * 100, Space.World);
        }
         if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * 100, Space.World);
        }
        //optional
         if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * 100, Space.World);
        }
         if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, 0, -1) * Time.deltaTime * 100, Space.World);
        }
    }
}
