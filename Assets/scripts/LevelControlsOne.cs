using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControlsOne : MonoBehaviour
{
    SceneController sceneController;
   
    void Awake()
    {
        LivesHolder.SetLife();
        LivesHolder.SetLife2();
        sceneController = FindObjectOfType<SceneController>();
        
        

    }

    // Update is called once per frame
    void Update()
    {
        
        StartGame();
        
    }

    void StartGame()
    {
        //to destroy dont destroyonload game object
        //Destroy(GameObject.Find("persistant_Lives"));
        if ((Input.GetKey(KeyCode.A)))
        {
            sceneController.NextLevel();

        }

    }

   


}
