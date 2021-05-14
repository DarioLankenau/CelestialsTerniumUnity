using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBoxContainer : MonoBehaviour
{
    //void OnCollisionEnter2D(Collision2D col)
    //{
    //    if (col.gameObject.tag == "Contenedor")
    //    {
    //        Points.numPoints++;
    //        Destroy(gameObject);
    //    }
    //}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag(this.gameObject.tag))
        {
            Points.numPoints++;
            Destroy(gameObject);
        }
        else
        {
            //Points.numPoints--;
            HeartSystem.life--;

        }
    }
}
