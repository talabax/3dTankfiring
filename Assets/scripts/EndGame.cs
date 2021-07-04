using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    [SerializeField] SceneController sceneController;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadMainMenu());
    }

    

    IEnumerator  LoadMainMenu()
    {


        yield return new WaitForSeconds(4);
        sceneController.Menu();
    }



}
