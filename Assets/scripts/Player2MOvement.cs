using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2MOvement : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField] GameObject projectile;
    [SerializeField] GameObject projectileSpawnPoint;
    GameObject ball;
    [SerializeField] GameObject parent;
    [SerializeField] bool isPlayer1;
    bool loadTimeStart = false;
    bool fired = true;
    PlayerStats playerStats2;

    MusicMain music;

    // Start is called before the first frame update
    void Start()
    {
        playerStats2 = GetComponent<PlayerStats>();
        music = FindObjectOfType<MusicMain>();
        rb = GetComponent<Rigidbody>();
        StartCoroutine(loadTime());
    }

    private void FixedUpdate()
    {
        Rotate();
    }

    void Update()
    {
        MoveForward();
        
        Fire();

    }


    void MoveForward()
    {

        if (loadTimeStart)
        {
            if (Input.GetKey(KeyCode.I))
            {
                rb.velocity = transform.forward * Time.fixedDeltaTime * 500;

            }
            if (Input.GetKey(KeyCode.K))
            {
                rb.velocity = transform.forward * Time.fixedDeltaTime * -500;

            }

        }






    }

    void Rotate()
    {

        if (loadTimeStart)
        {
            if (Input.GetKey(KeyCode.J))
            {
                transform.Rotate(0, -100f * Time.fixedDeltaTime, 0);
            }
            else if (Input.GetKey(KeyCode.L))
            {
                transform.Rotate(0, 100f * Time.fixedDeltaTime, 0);
            }



        }



    }



    void Fire()
    {
        if (fired)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                fired = false;
                ball = Instantiate(projectile, projectileSpawnPoint.transform.position, transform.rotation);
                music.FiredShot(music.RandomFire());
                StartCoroutine(FireTime(playerStats2.GetFireRate()));

                Destroy(ball, 2f);

            }
        }
    }


    IEnumerator loadTime()
    {
        yield return new WaitForSeconds(3);
        loadTimeStart = true;

    }

    IEnumerator FireTime(float fireRate2)
    {
        yield return new WaitForSeconds(fireRate2);
        fired = true;

    }
}
