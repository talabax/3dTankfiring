using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] int playerHealth = 2000;
    //[SerializeField] int playerArmor= 100;
    [SerializeField] int firePower = 100;
    [SerializeField] float fireRate = 1;
    CombatContoller combatContoller;
    UIController uiAccess;
    [SerializeField] PlayerStats playerEnemy;

    void Awake()
    {
        combatContoller = FindObjectOfType<CombatContoller>();
        uiAccess = FindObjectOfType<UIController>();
    }


    private void Start()
    {
        //Debug.Log("here it is !!!!!!!!!!! " +uiAccess.GetPlayer1FirePower());
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "projectile2")
        {
            
            SetPlayerhealth(combatContoller.DealDamageTest(playerEnemy.GetFirepower(), Playerhealth())); 
            uiAccess.UpdateHealth();
            Destroy(other.gameObject, .06f);

        }
        else if (other.gameObject.tag == "projectile1")
        {
          
            SetPlayerhealth(combatContoller.DealDamageTest(playerEnemy.GetFirepower(), Playerhealth()));
            uiAccess.UpdateHealth();
            Destroy(other.gameObject, .06f);

        }

    }

    public int Playerhealth()
    {
        return playerHealth;

    }

    public void SetPlayerhealth(int health)
    {
        if (health > 0)
        {
            playerHealth = health;
        }
        else if (health <= 0)
        {
            playerHealth = 0;
        }
    }

    public int GetFirepower()
    {
        return firePower;

    }

    public float SetFireRate()
    {
        return fireRate;

    }

    public float GetFireRate()
    {
        return fireRate;

    }

    //old code to set damage
    /*
            //var bullet2 = gameObject.GetComponentInParent<PlayerStats>();
            //Debug.Log(playerEnemy.GetFirepower());
            //Debug.Log(other + " projectile 2 hit player 1");
            //SetPlayerhealth( combatContoller.DealDamageTest(bullet2.GetFirepower(), Playerhealth())  );


            //var bullet1 = gameObject.GetComponentInParent<PlayerStats>();
            //Debug.Log(other.gameObject.GetComponentInParent<PlayerStats>().GetFirepower());
            //Debug.Log(other + " projectile 1 hit player 2");
            //SetPlayerhealth(combatContoller.DealDamageTest(bullet1.GetFirepower(), Playerhealth()));


     */




}
