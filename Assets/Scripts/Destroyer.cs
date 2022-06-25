using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Destroy(other.gameObject);
            FindObjectOfType<GameManager>().spawn();
            UiManager.myLife--;
            FindObjectOfType<UiManager>().lifescore.text = ":" + UiManager.myLife;
        }

        if (UiManager.myLife == 0)
        {
            UiManager.myLife = 3;
            UiManager.myScore = 0;
            FindObjectOfType<UiManager>().lifescore.text = ":" + UiManager.myLife;
            FindObjectOfType<UiManager>().score.text = ":" + UiManager.myScore;
            Time.timeScale = 0;
            FindObjectOfType<SoundManager>().Playsfx("GameOver");
            FindObjectOfType<UiManager>().gameoverscreen.SetActive(true);


        }
    }
}
