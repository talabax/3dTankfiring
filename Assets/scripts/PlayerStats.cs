using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] int playerHealth = 200;
    [SerializeField] int playerArmor= 100;
    [SerializeField] int firePower = 100;
    CombatContoller combatContoller;


    void Awake()
    {
        combatContoller = FindObjectOfType<CombatContoller>();
        
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "projectile2")
        {
            Debug.Log(other + " just hit us ! Trigger check1111111111111111");
            //combatContoller.DealDamage();
            Destroy(other.gameObject);

        }
        else if (other.gameObject.tag == "projectile1")
        {
            Debug.Log(other + " just hit us ! Trigger check 22222222222222222222");
            //combatContoller.DealDamage();
            Destroy(other.gameObject);

        }

    }





}
