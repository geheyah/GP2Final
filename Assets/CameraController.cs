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
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100))
        {
            Vector3 targetPosition = new Vector3(hit.point.x, height, hit.point.z);
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * damping);
        }
    }
}
