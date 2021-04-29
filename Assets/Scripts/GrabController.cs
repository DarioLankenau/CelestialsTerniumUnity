using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabController : MonoBehaviour
{

    public Transform grabDetect;
    public Transform boxHolder;
    public float rayDist;

    void Update()
    {
        RaycastHit2D grabCheck = Physics2D.Raycast(grabDetect.position, Vector2.right * transform.localScale, rayDist);

        if (grabCheck.collider != null && (grabCheck.collider.tag == "Azul" || grabCheck.collider.tag == "Morado" || grabCheck.collider.tag == "Rojo" || grabCheck.collider.tag == "Amarillo"))
        {
            if (Input.GetKey(KeyCode.G))
            {
                grabCheck.collider.gameObject.transform.parent = boxHolder;
                grabCheck.collider.gameObject.transform.position = boxHolder.position;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
            }
            else
            {
                grabCheck.collider.gameObject.transform.parent = null;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
            }
        }
    }
    
//    void OnCollisionEnter2D(Collision2D col)
//    {
//        if (col.gameObject.tag == "Contenedor")
//        {
//            Points.numPoints++;
//            Destroy(col.gameObject);
//        }
//    }

}
