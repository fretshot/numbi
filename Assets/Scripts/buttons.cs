using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour{

    public void btn_playAgain() {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void btn_resetMaxScore() {
        PlayerPrefs.SetInt("Maxscore", 0);
    }

    public void btn_exit() {
        Application.Quit();
    }
}
