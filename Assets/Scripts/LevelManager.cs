using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public float levelDuration = 10.0f;
    public Text timerText;
    public Text gameText;

    public AudioClip gameOverSFX;
    public AudioClip gameBeatSFX;

    public static bool gameOver = false;

    public int winScore;

    public string NextLevel;

    public static float countDown;

    public static int score;

    public bool intro = false;


    void Start()
    {
        if (!intro)
        {
            score = 0;
            gameText.text = "Score to win: " + winScore.ToString();
            gameText.gameObject.SetActive(true);
            gameOver = false;
            countDown = levelDuration;
            SetTimerText();
            timerText.gameObject.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver && !intro)
        {
            if (countDown > 0)
            {
                countDown -= Time.deltaTime;
                if(levelDuration - countDown > 2)
                {
                    gameText.gameObject.SetActive(false);
                }
            }
            else
            {
                countDown = 0.0f;

                LevelLost();
            }
            SetTimerText();
            if (Input.GetKeyDown(KeyCode.R))
            {
                LoadCurrentLevel();
            }
        }
        else if (intro)
        {
            if(Input.GetKeyDown(KeyCode.F))
            {
                LoadNextLevel();
            }
        }
    }

    private void OnGUI()
    {
        //GUI.Box(new Rect(10, 10, 50, 30), countDown.ToString("0.00"));
    }

    public void SetTimerText()
    {
        if((levelDuration - countDown) <= levelDuration / 2)
        {
            timerText.text = "Time: " + countDown.ToString("0.00") + "(2X) Score: " + score.ToString();
        }
        else
        {
            timerText.text = "Time: " + countDown.ToString("0.00") + " Score: " + score.ToString();
        }
    }

    public void LevelLost()
    {
        gameOver = true;
        gameText.text = "Game Over!";
        gameText.gameObject.SetActive(true);
        score = 0;

        AudioSource.PlayClipAtPoint(gameOverSFX, Camera.main.transform.position);
        Camera.main.GetComponent<AudioSource>().pitch = 1f;

        Invoke("LoadCurrentLevel", 3);
    }

    public void LevelBeat()
    {
        SetTimerText();
        gameOver = true;
        gameText.text = "You Win!";
        gameText.gameObject.SetActive(true);


        AudioSource.PlayClipAtPoint(gameBeatSFX, Camera.main.transform.position);
        Camera.main.GetComponent<AudioSource>().pitch = 2f;
        if(!string.IsNullOrEmpty(NextLevel))
        {
            Invoke("LoadNextLevel", 3);
        }
    }

    void LoadNextLevel()
    {
        SceneManager.LoadScene(NextLevel);
    }

    void LoadCurrentLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
