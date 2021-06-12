using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "projectile1" || other.gameObject.tag == "projectile2" )
        {
            //Debug.Log(other + " is here!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Destroy(other.gameObject);
            
        }


    }



}
