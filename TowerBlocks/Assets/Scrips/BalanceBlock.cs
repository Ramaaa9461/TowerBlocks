using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalanceBlock : MonoBehaviour
{

    [SerializeField] GameObject pivot;
    SpringJoint SJ;
    LineRenderer LR;
    void Awake()
    {
        SJ = pivot.GetComponent<SpringJoint>();
        LR = pivot.GetComponent<LineRenderer>();
    }
    private void Update()
    {
        if (SJ.connectedBody != null)
        {
            LR.enabled = true;

            LR.SetPosition(0, pivot.transform.position);
            LR.SetPosition(1, SJ.connectedBody.position);

            LR.startWidth = 0.02f;
            LR.material.color = Color.black;
            
        }
        else
        {
            LR.enabled = false;
        }

    }
    public void rigidBodyJoint(Rigidbody rg)
    {
        SJ.connectedBody = rg;
    }

    public void upPivotPosition(float upPositionY)
    {
        pivot.transform.position += new Vector3(0, upPositionY, 0);
    }

}
