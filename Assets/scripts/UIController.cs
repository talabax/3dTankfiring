using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField] GameObject player1;
    [SerializeField] GameObject player2;
    [SerializeField] TMP_Text player1HealthText;
    [SerializeField] TMP_Text player2HealthText;
    
    PlayerStats player1Health;
    PlayerStats player2Health;

    // Start is called before the first frame update
    void Awake()
    {
        player1Health = player1.GetComponent<PlayerStats>();
        player2Health = player2.GetComponent<PlayerStats>();
        UpdateHealth();


    }
    private void Update()
    {
        
    }



    public void UpdateHealth()
    {
        player1HealthText.text = GetPlayer1Health().ToString();
        player2HealthText.text = GetPlayer2Health().ToString();

        //player1HealthText.text = player1Health.Playerhealth().ToString();
       // player2HealthText.text = player2Health.Playerhealth().ToString();

    }





    public int  GetPlayer1Health()
    {
        return player1Health.Playerhealth();
    }

    public int GetPlayer2Health()
    {
        return player2Health.Playerhealth();
    }

    public int GetPlayer1FirePower()
    {
        return player1Health.GetFirepower() ;
    }

    public int GetPlayer2FirePower()
    {
        return player2Health.GetFirepower();
    }
}
