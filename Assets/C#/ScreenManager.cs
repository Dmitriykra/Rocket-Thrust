using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenManager : MonoBehaviour
{
    public GameObject loding;
    public GameObject gameMenu;
    public GameObject playGame;
    public GameObject pauseGame;
    public GameObject exitDialog;
    void Awake()
    {
        if(PlayerPrefs.GetInt("isPlaeyd").Equals(1))
        {
            GameMenu();
            PlayerPrefs.SetInt("isPlaeyd", 0);
        }
        else
        {
            StartCoroutine(EndLoading());
        }
    }

    IEnumerator EndLoading()
    {
        yield return new WaitForSeconds(1f);
        loding.SetActive(false);
        gameMenu.SetActive(true);
    }

    public void GameMenu()
    {
        gameMenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void PlayGameOrReload()
    {
        Time.timeScale = 1;
        //TODO create play mode loading screen with logic
        SceneManager.LoadScene(1);
    }
    public void ReturnToGame()
    {
        Time.timeScale = 1;
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void ExitDialog()
    {
        exitDialog.SetActive(true);
    }
    public void CloseExitDialog()
    {
        exitDialog.SetActive(false);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
