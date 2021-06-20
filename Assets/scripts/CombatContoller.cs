using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatContoller : MonoBehaviour
{
    //[SerializeField] GameObject player1;
    //[SerializeField] GameObject Player2;
    //UIController UIAccess;
    
    private void Awake()
    {
         
    }
    


    public int DealDamageTest( int firePower, int health)
    {
        health = health - firePower * 2;
        

        return health;
    }



    






}
