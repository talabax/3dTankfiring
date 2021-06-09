using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2MOvement : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField] GameObject projectile;
    [SerializeField] GameObject projectileSpawnPoint;
    GameObject ball;
    [SerializeField] bool isPlayer1;
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
            if (Input.GetKey(KeyCode.I))
            {
                rb.velocity = transform.forward * Time.deltaTime * 5000;

            }
            if (Input.GetKey(KeyCode.K))
            {
                rb.velocity = transform.forward * Time.deltaTime * -5000;

            }

        }






    }

    void Rotate()
    {

        if (loadTimeStart)
        {
            if (Input.GetKey(KeyCode.J))
            {
                transform.Rotate(0, -200 * Time.deltaTime, 0);
            }
            else if (Input.GetKey(KeyCode.L))
            {
                transform.Rotate(0, 200 * Time.deltaTime, 0);
            }



        }



    }



    void Fire()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ball = Instantiate(projectile, projectileSpawnPoint.transform.position, transform.rotation);

            Destroy(ball, 2f);

        }
    }


    IEnumerator loadTime()
    {
        yield return new WaitForSeconds(3);
        loadTimeStart = true;

    }
}
