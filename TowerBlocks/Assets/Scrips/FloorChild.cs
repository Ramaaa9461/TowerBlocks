using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorChild : MonoBehaviour
{
    [SerializeField] Camera cam;
    Transform lastChild;

    public void OnNewChild()
    {
        lastChild = transform.GetChild(transform.childCount - 1);

        cam.GetComponent<CameraMovement>().upCamera(lastChild.position);// lastChild.localScale.y);
    }
 

}
