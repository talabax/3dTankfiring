using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] GameObject projectile;
    [SerializeField] GameObject projectileSpawnPoint;
    GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();
        Rotate();
        Fire();
        /*if(ball == null)
        {
            return;
        }
        else
        { 
            ball.transform.Translate(transform.forward * 20 * Time.deltaTime);
        }
        */
    }


    void MoveForward()
    {
        if(Input.GetKey(KeyCode.W))
        {
            rb.velocity = transform.forward * Time.deltaTime * 200;
            //rb.velocity = new Vector3(1, 0, 0) * 10 ; 
        }

    }

    void Rotate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 2, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, -2, 0);
        }


       




    }



    void Fire()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           ball = Instantiate(projectile, projectileSpawnPoint.transform.position, transform.rotation);
           
           Destroy(ball, .5f);

        }
    }







}
