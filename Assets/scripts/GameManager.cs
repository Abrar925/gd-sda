using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject gamrOverPanel;
    public GameObject scoresTablePanel;
    public Text scoreText;
    public TextMeshProUGUI leaderBoardscoreText;
    int score = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameOver()
    {

        ObstacleSpawner.instance.gameOver = true;
        StopScrolling();
        gamrOverPanel.SetActive(true);
        scoresTablePanel.SetActive(true);
    }

    void StopScrolling()
    {
        TextureScroll[] scrollingObjects = FindObjectsOfType<TextureScroll>();

        foreach (TextureScroll t in scrollingObjects)
        {
            t.scroll = false;
        }
    }


    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");

    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("ggg");
    }


    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }


    public void IncrementScore()
    {
        score++;
        scoreText.text = score.ToString();
        leaderBoardscoreText.text = score.ToString();
    }
}
