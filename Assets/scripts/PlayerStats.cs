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
    MusicMain music;
    void Awake()
    {
        music = FindObjectOfType<MusicMain>();
        combatContoller = FindObjectOfType<CombatContoller>();
        uiAccess = FindObjectOfType<UIController>();
    }


    private void Start()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "projectile2")
        {
            music.ShotContact(music.RandomContactFire());
            SetPlayerhealth(combatContoller.DealDamageTest(playerEnemy.GetFirepower(), Playerhealth())); 
            uiAccess.UpdateHealth();
            Destroy(other.gameObject, .06f);

        }
        else if (other.gameObject.tag == "projectile1")
        {
            music.ShotContact(music.RandomContactFire());
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

  




}
