using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    BlockerCreator Bc;
    BalanceBlock Bb;
    GameObject currentCube;
    //Vector3 upPosition = new Vector3(0, 2, 0);

    void Awake()
    {
        instance = this;
        Bc = GetComponent<BlockerCreator>();
        Bb = GetComponent<BalanceBlock>();
    }
    private void Start()
    {
        currentCube = Bc.CreateBlock();
        Bb.rigidBodyJoint(currentCube.GetComponent<Rigidbody>());

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Bb.rigidBodyJoint(null);
            //upPositions();
        }
    }
    public void InstantiateBlocks()
    {
        currentCube = Bc.CreateBlock();
        Bb.rigidBodyJoint(currentCube.GetComponent<Rigidbody>());
    }
    public void upPositions()
    {
        Bb.upPivotPosition(currentCube.transform.localScale.y);
        Bc.upInitPosition(currentCube.transform.localScale.y);
    }
}
