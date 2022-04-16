using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    Vector3 vel = Vector3.zero;
    [SerializeField] float transitionSpeed = 5;
    public void upCamera(float camPositionY)
    {
        // transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, camPositionY, transform.position.z), Time.deltaTime * transitionSpeed);
         transform.position = new Vector3(transform.position.x, camPositionY, transform.position.z);
        // transform.position = Vector3.SmoothDamp(transform.position, new Vector3(transform.position.x, camPositionY, transform.position.z), ref vel, smoothness);
    }
    public void VibrationCam()
    {

    }
}
