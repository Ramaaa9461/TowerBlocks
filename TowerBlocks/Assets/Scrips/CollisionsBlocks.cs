using System;
using UnityEngine;

public class CollisionsBlocks : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        GameManager.instance.InstantiateBlocks();
        gameObject.layer = 6;
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, collision.contacts[0].point.y + gameObject.transform.localScale.y / 2, gameObject.transform.position.z);
        gameObject.transform.rotation = Quaternion.Euler(Vector3.zero);
         gameObject.GetComponent<Rigidbody>().isKinematic = true;
        Destroy(this);
    }

}
