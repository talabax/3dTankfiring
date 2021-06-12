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

    bool loadTimeStart = false;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(loadTime());
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();
        Rotate();
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
                transform.Rotate(0, -15 * Time.fixedDeltaTime, 0);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(0, 15 * Time.fixedDeltaTime, 0);
            }



        }



    }



    void Fire()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           ball = Instantiate(projectile, projectileSpawnPoint.transform.position, transform.rotation);
            ball.transform.SetParent(gameObject.transform);
           Destroy(ball, 2f);

        }
    }


    IEnumerator loadTime()
    {
        yield return new WaitForSeconds(1.5f);
        loadTimeStart = true;

    }




}
