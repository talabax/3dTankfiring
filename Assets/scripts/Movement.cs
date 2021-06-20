using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    
    [SerializeField] GameObject projectile , par;
    [SerializeField] GameObject projectileSpawnPoint;
    GameObject ball;
    [SerializeField] GameObject parent;
    CombatContoller combatController;
    PlayerStats playerStats1;
    
    bool loadTimeStart = false;
    bool fired = true; 

    // Start is called before the first frame update
    void Start()
    {
        playerStats1 = GetComponent<PlayerStats>();
       

        //combatController = FindObjectOfType<CombatContoller>();
        rb = GetComponent<Rigidbody>();
        StartCoroutine(loadTime());
    }


    private void FixedUpdate()
    {
        Rotate();
    }
    // Update is called once per frame
    void Update()
    {
        MoveForward();
        
        Fire();
       
    }


    void MoveForward()
    {

        if (loadTimeStart)
        {
            if (Input.GetKey(KeyCode.W))
            {
                rb.velocity = transform.forward * Time.fixedDeltaTime * 500;

            }
            if (Input.GetKey(KeyCode.S))
            {
                rb.velocity = transform.forward * Time.fixedDeltaTime * -500;

            }

        }

    }

    void Rotate()
    {
        
        if (loadTimeStart)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(0, -100f * Time.fixedDeltaTime, 0);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(0, 100f * Time.fixedDeltaTime, 0);
            }



        }



    }



    void Fire()
    {
        if (fired)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                fired = false;
                ball = Instantiate(projectile, projectileSpawnPoint.transform.position, transform.rotation);
                
                StartCoroutine(FireTime(playerStats1.GetFireRate()));
                
                Destroy(ball, 2f);

            }
        }
    }


    IEnumerator loadTime()
    {
        yield return new WaitForSeconds(1.5f);
        loadTimeStart = true;

    }

    IEnumerator FireTime(float fireRate1)
    {
        yield return new WaitForSeconds(fireRate1);
        fired = true;

    }


}
