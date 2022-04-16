using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public void upCamera(float camPositionY)
    {
       // transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, camPositionY, transform.position.z), Time.deltaTime * 10);
        transform.position = new Vector3(transform.position.x, camPositionY, transform.position.z);
    }
}
