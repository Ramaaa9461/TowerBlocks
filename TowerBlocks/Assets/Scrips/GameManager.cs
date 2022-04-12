using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    BlockerCreator Bc;
    BalanceBlock Bb;
    GameObject currentCube; 

    void Awake()
    {
        Bc = GetComponent<BlockerCreator>();
        Bb = GetComponent<BalanceBlock>();

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentCube = Bc.CreateBlock();
            Bb.rigidBodyJoint(currentCube.GetComponent<Rigidbody>());
        }
        

    }
}
