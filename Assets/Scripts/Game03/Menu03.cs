using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Menu03 : MonoBehaviour
{
    public Transform Player;
    public Text ScoreText;
    public Text EndText;

    // Update is called once per frame
    void Update()
    {
        float zero = Player.position.y + 4;
        ScoreText.text = "Score:" + zero.ToString("0");

        EndText.text = "Your Score:" + zero.ToString("0");
    }

    public GameObject pauseMenu;
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;

    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;

    }

    public GameObject intro;
    public void introPage()
    {
        intro.SetActive(true);
        Time.timeScale = 0f;

    }
    public void introback()
    {
        intro.SetActive(false);
        Time.timeScale = 1f;

    }
    public void Refresh()
    {
        SceneManager.LoadScene("Game03");
        Time.timeScale = 1f;
    }


    public void Returnback()
    {
        SceneManager.LoadScene("Menu");//加载当前游戏场景下一个编号
    }

  
   

}
