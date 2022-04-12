using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockerCreator : MonoBehaviour
{
    GameObject cube;
    public GameObject CreateBlock()
    {
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        cube.transform.localScale = new Vector3(4, 2, 2);
        cube.AddComponent<Rigidbody>();
        cube.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ;
    
        
        cube.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();

        cube.transform.position = new Vector3(0, 3, 0);

        return cube;
    }

    public GameObject getCube()
    {
        return cube;
    }

}
