using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalanceBlock : MonoBehaviour
{

    [SerializeField] GameObject pivot;
    SpringJoint SJ;
    void Awake()
    {
       SJ = pivot.GetComponent<SpringJoint>();
    }

    public void rigidBodyJoint(Rigidbody rg)
    {
        SJ.connectedBody = rg;
    }

    public void upPivotPosition(Vector3 upPosition)
    {
        pivot.transform.position += upPosition;
    }

}
