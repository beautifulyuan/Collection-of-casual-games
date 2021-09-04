using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame01()
    {
        Rd_obj.level = 0;
        SceneManager.LoadScene("Game01");//加载当前游戏场景下一个编号
        Time.timeScale = 1f;
        
    }

        public void PlayGame02()
    {
        SceneManager.LoadScene("Game02");//加载当前游戏场景下一个编号
        Time.timeScale = 1f;
    }

    public void PlayGame03()
    {
        SceneManager.LoadScene("Game03");//加载当前游戏场景下一个编号
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void Returnback()
    {
        SceneManager.LoadScene("Menu");//加载当前游戏场景下一个编号
    }



}
