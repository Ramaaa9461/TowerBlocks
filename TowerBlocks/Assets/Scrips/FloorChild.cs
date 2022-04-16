using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorChild : MonoBehaviour
{
    [SerializeField] Camera cam;
    Transform newCamPosition;

    public void OnNewChild()
    {
        newCamPosition = transform.GetChild(transform.childCount - 1);

        cam.GetComponent<CameraMovement>().upCamera(newCamPosition.position.y + newCamPosition.localScale.y);
    }
 

}
