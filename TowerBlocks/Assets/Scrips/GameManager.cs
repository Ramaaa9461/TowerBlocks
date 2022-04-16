using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;


    BlockerCreator Bc;
    BalanceBlock Bb;
    GameObject currentCube;

    [SerializeField] int totalLife = 3;
    [SerializeField] int currentLife = 0;
    [SerializeField] Text currentFloor;
    [SerializeField] Text currentLifeText;

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

        currentFloor.text = "0";
        currentLife = totalLife + 1;
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
    public void SubtractLife()
    {
        if (currentLife > 0)
        {
            currentLife--;
        }
        currentLifeText.text = currentLife.ToString();
    }


    public void currentFloorText(int floor)
    {
        currentFloor.text = floor.ToString();
    }
}
