using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatContoller : MonoBehaviour
{
    [SerializeField] GameObject player1;
    [SerializeField] GameObject Player2;
    private void Awake()
    {
        
    }
    // Start is called before the first frame update


    /*public int DealDamage(int firepower, int health)
    {
        health = health - firepower * 2;
        Debug.Log("you were hit");
        return health;
    }
    */

    public void DealDamage()
    {
        
        Debug.Log("you were hit");
        
    }







}
