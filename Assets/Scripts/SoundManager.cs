using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public AudioClip Playbtnsound;
    public AudioClip homebtnsound;
    public AudioClip quitbtnsound;
    public AudioClip scoresound;
    private AudioSource audioSource;
    private AudioClip win;
    private AudioClip gamelose;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Playbtnsound = Resources.Load<AudioClip>("ButtonClick");
        homebtnsound = Resources.Load<AudioClip>("18");
        quitbtnsound = Resources.Load<AudioClip>("19");
        scoresound = Resources.Load<AudioClip>("Catch");
        win = Resources.Load<AudioClip>("Win");
        gamelose = Resources.Load<AudioClip>("GameOver");
    }

    // Update is called once per frame
    public void Playsfx(string clip)
    {
        switch (clip)
        {
            case "ButtonClick":
                audioSource.PlayOneShot(Playbtnsound);
                break;
            case "18":
                audioSource.PlayOneShot(homebtnsound);
                break;
            case "19":
                audioSource.PlayOneShot(quitbtnsound);
                break;
            case "Catch":
                audioSource.PlayOneShot(scoresound);
                break;
            case "Win":
                audioSource.PlayOneShot(win);
                break;
            case "GameOver":
                audioSource.PlayOneShot(gamelose);
                break;
        }

    }
}
