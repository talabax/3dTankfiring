using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    [SerializeField] PlayerStats player1;
    [SerializeField] PlayerStats player2;
    UIController uiAccess;

    private void Awake()
    {
        uiAccess = FindObjectOfType<UIController>();
    }




    private void OnTriggerEnter(Collider other)
    {
        if( other.gameObject.tag == "player1")
        {
            
            player1.SetPlayerhealth(0);
            
            uiAccess.UpdateHealth();
            
            Debug.Log("player 1 has entered");
        }
        else  if (other.gameObject.tag == "player2")
        {
            Debug.Log("player 2 has entered");
            player2.SetPlayerhealth(0);
            uiAccess.UpdateHealth();
        }


    }



    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(1.5f);


    }





}
