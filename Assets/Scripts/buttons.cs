using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour{

    public void btn_play() {
        SceneManager.LoadScene("01");
    }

    public void btn_mainMenu() {
        SceneManager.LoadScene("00");
    }

    public void btn_resetMaxScore() {
        PlayerPrefs.SetInt("Maxscore", 0);
    }

    public void btn_exit() {
        Application.Quit();
    }

    public void btn_resume() {
        NotificationCenter.DefaultCenter().PostNotification(this, "resumeGameplay");
    }

    public void btn_pause() {
        NotificationCenter.DefaultCenter().PostNotification(this, "pauseGameplay");
    }
}
