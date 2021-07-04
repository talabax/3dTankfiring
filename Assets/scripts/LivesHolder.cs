using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesHolder : MonoBehaviour
{
    public static LivesHolder Instance
    {
        get;

        private set;


    }

    static int lives = 3;
    static int lives2 = 3;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(gameObject);

        }
    }

    public static int Lifelower()
    {
        lives--;

        return lives;
    }

    public static int GetLife()
    {
        

        return lives;
    }

    public static void SetLife()
    {


        lives = 3;
    }


    //

    public static int Lifelower2()
    {
        lives2--;

        return lives2;
    }

    public static int GetLife2()
    {


        return lives2;
    }

    public static void SetLife2()
    {


        lives2 = 3;
    }







}
