using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void LoadStartMenu()
    {
        SceneManager.LoadScene("StartingMenu");
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("Main_Scene");
    }

    public void LoadCredits()
    {
        SceneManager.LoadScene("CreditsScene");
    }

    public void LoadHelp()
    {
        SceneManager.LoadScene("HelpScene");
    }

    public void LoadGameOver()
    {

        StartCoroutine(WaitAndLoad());

    }
    IEnumerator WaitAndLoad()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Gameover");
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
