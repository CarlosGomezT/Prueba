
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour
{
    public GameObject UIPause;
    public string levelToLoad = "MenuScreen";

    public void TogglePause()
    {
        Stats.TogglePauseState();
        UIPause.SetActive(!UIPause.activeSelf);
        if (UIPause.activeSelf)
        {
            PauseAudioInMenu(true);
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
            PauseAudioInMenu(false);
        }
    }
    public void Retry()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(levelToLoad);
    }
    public void PauseAudioInMenu(bool pause)
    {
        AudioSource[] audios = FindObjectsOfType<AudioSource>();

        if (pause == true)
        {
            foreach (AudioSource audio in audios)
            {
                audio.Pause();            
            }
        }
        else
        {
            foreach (AudioSource audio in audios)
            {
                audio.UnPause();
            }
        }
    }
}