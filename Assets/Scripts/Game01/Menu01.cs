using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Menu01 : MonoBehaviour
{

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
        Rd_obj.level = 0;
        SceneManager.LoadScene("Game01");
        Time.timeScale = 1f;
    }


    public void Returnback()
    {
        SceneManager.LoadScene("Menu");//���ص�ǰ��Ϸ������һ�����
    }

   
    public void Nextpage()
    {
        
        SceneManager.LoadScene("Game01");
        Time.timeScale = 1f;

    }
}
