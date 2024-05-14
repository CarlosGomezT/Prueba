
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour
{
    public GameObject UIPause;
    public string levelToLoad = "MenuScreen";

    private void Start()
    {
        //StartCoroutine(EsperarFrames(3));
    }
    public void TogglePause()
    {
        Stats.TogglePauseState();
        UIPause.SetActive(!UIPause.activeSelf);
        if (UIPause.activeSelf)
        {
            PauseAudioInMenu(true);
            FreezeTime();
        }
        else
        {
            UnFreezeTime();
            PauseAudioInMenu(false);
        }
    }
    public void Retry()
    {
        UnFreezeTime();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Menu()
    {
        UnFreezeTime();
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
    public void UnFreezeTime()
    {
            Time.timeScale = 1f;
    }
    public void FreezeTime()
    {
            Time.timeScale = 0f;
    }

    //IEnumerator EsperarFrames(int frames)
    //{
    //    int frameCount = 0;
    //    while (frameCount < frames)
    //    {
    //        yield return null;
    //        frameCount++;
    //    }
    //    FreezeTime();
    //}
}