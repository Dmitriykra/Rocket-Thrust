using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject pauseGame;
    private void Awake()
    {
        pauseGame.SetActive(false);
        Time.timeScale = 1;
    }
    public void PlayGameOrReload()
    {
        pauseGame.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
    public void ReturnToGame()
    {
        Time.timeScale = 1;
        pauseGame.SetActive(false);
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseGame.SetActive(true);
    }
    public void GoToMenue()
    {
        PlayerPrefs.SetInt("isPlaeyd", 1);
        SceneManager.LoadScene(0);
    }
}
