using System;
using UnityEngine;

public class CollisionsBlocks : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.position.x + collision.gameObject.transform.localScale.x / 2 > gameObject.transform.position.x - gameObject.transform.localScale.x / 2 &&
            collision.transform.position.x - collision.gameObject.transform.localScale.x / 2 < gameObject.transform.position.x + gameObject.transform.localScale.x / 2)
        {
            if (collision.gameObject.layer == 8)
            {

                gameObject.layer = 8;
                collision.gameObject.layer = 6;
                gameObject.transform.position = new Vector3(gameObject.transform.position.x, collision.contacts[0].point.y + gameObject.transform.localScale.y / 2, gameObject.transform.position.z);
                gameObject.transform.rotation = Quaternion.Euler(Vector3.zero);
                gameObject.GetComponent<Rigidbody>().isKinematic = true;


                if (collision.transform.parent != null)
                {
                    transform.SetParent(collision.transform.parent);
                    GameManager.instance.upPositions();
                    GameManager.instance.currentFloorText(collision.transform.parent.childCount);
                    gameObject.GetComponentInParent<FloorChild>().OnNewChild();

                }
                else
                {
                    if (collision.transform.childCount == 0)
                    {
                        transform.SetParent(collision.transform);
                        gameObject.GetComponentInParent<FloorChild>().OnNewChild();
                        GameManager.instance.currentFloorText(1);
                    }
                }
                Destroy(this);
            }
            

        }
        else
        {
            int count = 0;

            //Falta cheequear que colisione solo con 1 objeto

            if (count < 1) //Chequea solo la primera vez en caso de colision
            {
            GameManager.instance.SubtractLife();
            Destroy(gameObject, 3f);
            }
            count++;
        }
    }

}
