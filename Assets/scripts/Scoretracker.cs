using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Scoretracker : MonoBehaviour
{
    SceneController sceneController;
    [SerializeField] PlayerStats player1;
    [SerializeField] PlayerStats player2;
    [SerializeField] TMP_Text player1LifeText;
    [SerializeField] TMP_Text player2LifeText;
    [SerializeField] int player1Lives;
    int player2Lives = 3;

    [SerializeField] int playerHealth1;
    int playerHealth2;
    bool gameactive = true;

    private void Awake()
    {
        player1Lives = LivesHolder.GetLife();
        player2Lives = LivesHolder.GetLife2();
        playerHealth1 = player1.Playerhealth();
        playerHealth2 = player2.Playerhealth();
        sceneController = FindObjectOfType<SceneController>();



    }


    void Start()
    {
        player1LifeText.text = player1Lives.ToString();
        player2LifeText.text = player2Lives.ToString();
    }


    void Update()
    {
        PlayerHealth1Compare();
        PlayerHealth2Compare();
    }


    void PlayerHealth1Compare()
    {


        if (gameactive)
        {
            if (player1.Playerhealth() <= 0)
            {
                if (player1Lives > 0)
                {
                    player1Lives = LivesHolder.Lifelower();
                    player1LifeText.text = player1Lives.ToString();
                    sceneController.RestartGame();
                    Debug.Log(player1Lives);
                }
                else if (player1Lives <= 0)
                {
                    Debug.Log("Game Over");
                    sceneController.Menu();

                }


            }
        }



    }


    void PlayerHealth2Compare()
    {


        if (gameactive)
        {
            if (player2.Playerhealth() <= 0)
            {
                if (player2Lives > 0)
                {
                    player2Lives = LivesHolder.Lifelower2();
                    player2LifeText.text = player2Lives.ToString();
                    sceneController.RestartGame();
                    Debug.Log(player2Lives);
                }
                else if (player2Lives <= 0)
                {
                    Debug.Log("Game Over");
                    sceneController.Menu();

                }


            }
        }















    }


}
