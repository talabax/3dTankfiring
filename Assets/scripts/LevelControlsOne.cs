using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControlsOne : MonoBehaviour
{
    SceneController sceneController;

    // Start is called before the first frame update
    void Awake()
    {
        sceneController = FindObjectOfType<SceneController>();
    }

    // Update is called once per frame
    void Update()
    {
        StartGame();
    }

    void StartGame()
    {
        if ((Input.GetKey(KeyCode.A)))
        {
            sceneController.NextLevel();

        }

    }




}
