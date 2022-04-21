using System;
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
    int currentLife = 0;
    [SerializeField] Text currentFloor;
    [SerializeField] Text currentLifeText;

    [SerializeField] Vector3 updatePosition;

    float timer;
    bool activeTimer = false;
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
        if (activeTimer)
        {
            timer += Time.deltaTime;

            if (timer > 1.5f)
            {
                InstantiateBlocks();
                timer = 0;
                activeTimer = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Bb.rigidBodyJoint(null);
            activeTimer = true;
        }

  

    }
    public void InstantiateBlocks()
    {
        currentCube = Bc.CreateBlock();
        Bb.rigidBodyJoint(currentCube.GetComponent<Rigidbody>());
    }
    public void upPositions()
    {
        Bb.upPivotPosition(updatePosition);
        Bc.upInitPosition(updatePosition);
    }
    public void SubtractLife()
    {
        if (currentLife > 0)
        {
            currentLife--;
        }
        else
        {
            restart();
        }
        currentLifeText.text = currentLife.ToString();
    }

    private void restart()
    {
        
    }

    public void currentFloorText(int floor)
    {
        currentFloor.text = floor.ToString();
    }
}
