using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockerCreator : MonoBehaviour
{
     GameObject cube;

    float horizontalForce = 10;
    Vector3 initialPosition = new Vector3(0, 8,  0);
    Vector3 axis;
    public GameObject CreateBlock()
    {
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        cube.transform.localScale = new Vector3(4, 2, 2);

        cube.AddComponent<Rigidbody>();
        cube.AddComponent<CollisionsBlocks>();

        cube.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ;
        cube.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();

        cube.layer = 7;
        cube.transform.position = initialPosition;

        horizontalForce = Random.Range(10, 15);
        axis = Random.Range(0, 2) == 0 ? Vector3.right : Vector3.left;

        cube.GetComponent<Rigidbody>().AddForce(axis * horizontalForce, ForceMode.Impulse);


        return cube;
    }
    public void upInitPosition(Vector3 upPosition)
    {
       initialPosition += upPosition;
    }

    public GameObject getCube()
    {
        return cube;
    }


}
