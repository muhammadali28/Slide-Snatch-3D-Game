using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UiManager : MonoBehaviour
{
    public Image ballImage;
    public Image Life;
    public Image backgroundImage;
    public GameObject Mainmenu;
    public GameObject winscreens;
    public GameObject gameoverscreen;
    public Text score;
    public Text lifescore;
    

    public static int myScore = 0;
    public static int myLife = 3;
    
    void Start()
    {
        Time.timeScale = 0;
    }
    public void Playbtn()
    {
        Time.timeScale = 1;
        myScore = 0;
        myLife = 3;
        ballImage.gameObject.SetActive(true);
        score.gameObject.SetActive(true);
        Life.gameObject.SetActive(true);
        lifescore.gameObject.SetActive(true);
        Mainmenu.SetActive(false);
        winscreens.SetActive(false);
        backgroundImage.gameObject.SetActive(false);
        FindObjectOfType<SoundManager>().Playsfx("ButtonClick");

    }
    public void Quitbtn()
    {
        FindObjectOfType<SoundManager>().Playsfx("19");
        Mainmenu.SetActive(true);
        gameoverscreen.SetActive(false);
        backgroundImage.gameObject.SetActive(true);
        ballImage.gameObject.SetActive(false);
        score.gameObject.SetActive(false);
        Life.gameObject.SetActive(false);
        lifescore.gameObject.SetActive(false);
    }

    public void Homebtn()
    {
        FindObjectOfType<SoundManager>().Playsfx("18");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        winscreens.SetActive(false);
        Mainmenu.SetActive(true);
        ballImage.gameObject.SetActive(false);
        score.gameObject.SetActive(false);
        Life.gameObject.SetActive(false);
        lifescore.gameObject.SetActive(false);
        backgroundImage.gameObject.SetActive(true);
    }
    public void Cancelbtn()
    {
        Application.Quit();
    }

}
