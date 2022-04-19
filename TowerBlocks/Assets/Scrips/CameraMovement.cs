using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
   [SerializeField] Vector3 offSet;
    public void upCamera(Vector3 camPosition)
    {
        StartCoroutine(FadeIn(camPosition));
        //transform.position = new Vector3(transform.position.x, camPositionY, transform.position.z);
    }
    IEnumerator FadeIn(Vector3 camPosition)
    {
        float progress = 0;
        Vector3 newPositon = new Vector3(transform.position.x, camPosition.y, transform.position.z) + offSet;

        while (progress <= 1)
        {
            transform.position = Vector3.Lerp(transform.position, newPositon, progress);
            progress += Time.deltaTime;
            yield return null;
        }
        transform.position = newPositon;
    }
}
