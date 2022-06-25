using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollector : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            FindObjectOfType<SoundManager>().Playsfx("Catch");
            Destroy(other.gameObject);
            FindObjectOfType<GameManager>().spawn();
            UiManager.myScore++;
            FindObjectOfType<UiManager>().score.text = ":" + UiManager.myScore;
        }
        if (UiManager.myScore >3)
        {
            // UiManager.highScore=UiManager.myScore;
            // UiManager.myLife = 3;
            // UiManager.myScore = 0;
            // FindObjectOfType<UiManager>().score.text = ":" + UiManager.myScore;
            // FindObjectOfType<UiManager>().lifescore.text = ":" + UiManager.myLife;
            // Time.timeScale = 0;
            // FindObjectOfType<SoundManager>().Playsfx("Win");
            // FindObjectOfType<UiManager>().winscreens.SetActive(true);
        }
    }
}
