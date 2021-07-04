using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicMain : MonoBehaviour
{
    
    [SerializeField] AudioClip[] firedShots;
    [SerializeField] AudioClip[] contactShots;
    AudioSource audioSource;

    public static MusicMain Instance
    {
        get;

        private set;


    }

    

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(gameObject);

        }
    }














    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        

    }

    // Update is called once per frame
    void Update()
    {   //test fire
        //FiredShot(RandomFire());

    }

    public void FiredShot(int num)
    {
        Instance.audioSource.PlayOneShot(firedShots[num], .25f);


    }

    public void ShotContact(int num)
    {
        Instance.audioSource.PlayOneShot(contactShots[num], .5f);


    }

    public int RandomFire()
    {
        int num = Random.Range(0, firedShots.Length);
        return num;

    }

    public int RandomContactFire()
    {
        int num = Random.Range(0, contactShots.Length);
        return num;

    }


}
