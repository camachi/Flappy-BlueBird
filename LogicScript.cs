using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Security.Cryptography;
using System.Threading;
using TMPro;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameoverscreen;
    public bool dead = false;
    public AudioSource deadSound;
    public int audioplayed = 0;
    public AudioSource ButtomSound;
    public AudioClip ButtomClick;
    public TextMeshProUGUI Best;
    public TextMeshProUGUI Score;
    //public TextMeshProUGUI Coins;
    //coins disable 



    private void Start()
    {
        
    }
    public void addScore(int score)
    {   if (dead == false)
        {
            playerScore += score;
            
            scoreText.text = playerScore.ToString();
          
        }
    }
    public void ReviveGame()
    {
        
        restartGame();
       
    }
    public void restartGame()
    {
        ButtomSound.PlayOneShot(ButtomClick, 1);
        Thread.Sleep(200);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        
        if (PlayerPrefs.GetInt("HighScore", 0) <= playerScore)
        {
            PlayerPrefs.SetInt("HighScore", playerScore);
            int Value = PlayerPrefs.GetInt("HighScore", 0);
            Best.text = Value.ToString();
        }
        else
        {
            int Value = PlayerPrefs.GetInt("HighScore");
            Best.text = Value.ToString();
        }
        Score.text = playerScore.ToString();
        //Coins.text = "+" + playerScore.ToString();

        gameoverscreen.SetActive(true);
        dead = true;
        if(audioplayed == 0)
        {
            deadSound.Play();
        }
        audioplayed = 1;
        
    }

    public void MenuButtom()
    {
        ButtomSound.PlayOneShot(ButtomClick, 1);
        Thread.Sleep(200);
        SceneManager.LoadSceneAsync(0);
        
    }
    public void MenuButtomToGame()
    {
        ButtomSound.PlayOneShot(ButtomClick, 1);
        Thread.Sleep(200);
        SceneManager.LoadSceneAsync(1);

    }
    
}
