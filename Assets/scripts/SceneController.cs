using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    int currentScene;
    void Awake()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("awake");

    }



    public void NextLevel()
    {

        SceneManager.LoadScene(currentScene + 1);


    }
    public void EndGame()
    {
        SceneManager.LoadScene(2);


    }

    public void WinGame()
    {
        SceneManager.LoadScene(3);


    }
    public void RestartGame()
    {
        SceneManager.LoadScene(1);


    }
    public void Menu()
    {
        SceneManager.LoadScene(0);


    }






}
