using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
  public GameObject pauseMenuUI;

    void Update()
    {
        // 按下 "P" 鍵來暫停或繼續遊戲
        if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePauseMenu();
        }
    }

    public void TogglePauseMenu()
    {
        if (pauseMenuUI.activeSelf)
        {
            // 如果暫停選單已經顯示，則繼續遊戲
            ResumeGame();
        }
        else
        {
            // 如果暫停選單未顯示，則暫停遊戲
            PauseGame();
        }
    }

    void PauseGame()
    {
        // 暫停遊戲，顯示暫停選單
        Time.timeScale = 0f;
        pauseMenuUI.SetActive(true);
    }

    public void ResumeGame()
    {
        // 取消暫停，隱藏暫停選單
        Time.timeScale = 1f;
        pauseMenuUI.SetActive(false);
    }
}

