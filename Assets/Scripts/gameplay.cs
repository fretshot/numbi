using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameplay : MonoBehaviour {

    public GameObject[] uiLives;

    private List<int> numeros;

    private int score = 0;
    private int maxScore = 0;

    public TextMeshProUGUI txt_score;
    public TextMeshProUGUI txt_yourScore;
    public TextMeshProUGUI txt_maxScore;
    public TextMeshProUGUI txt_newRecord;

    private AudioSource sourceMusic;
    public AudioSource lostSound;
    public AudioSource getPointsSound;
    public AudioSource lostLiveSound;
    public AudioSource newRecordSound;

    float time;
    private int lives;
    private bool playerIsDead = false;

    public Camera failCamera;
    public Camera mainCamera;
    public GameObject lostLiveCamera;

    void Start(){

        playerIsDead = false;
        lives = 3;
        sourceMusic = GetComponent<AudioSource>();

        if (PlayerPrefs.HasKey("MusicVolume")) {
            sourceMusic.volume = PlayerPrefs.GetFloat("MusicVolume");
        } else {
            sourceMusic.volume = 1f;
        }

        mainCamera.enabled = true;
        lostLiveCamera.SetActive(false);
        failCamera.enabled = false;
        txt_newRecord.enabled = false;

        numeros = new List<int>();
        NotificationCenter.DefaultCenter().AddObserver(this, "agregar");
        NotificationCenter.DefaultCenter().AddObserver(this, "playerLost");

        if (PlayerPrefs.HasKey("Maxscore")) {
            maxScore = PlayerPrefs.GetInt("Maxscore");
        }
    }

    private void Update() {

        stopWatch();

        if (Input.GetKeyDown(KeyCode.Keypad0) || Input.GetKeyDown(KeyCode.Alpha0)) {
            if (numeros.Contains(0)) {
                Destroy(GameObject.FindGameObjectWithTag("num0"));
                numeros.Remove(0);
                score += 1;
                txt_score.text = score.ToString();
                getPointsSound.Play();
            } else {
                playerLost();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) {
            if (numeros.Contains(1)) {
                Destroy(GameObject.FindGameObjectWithTag("num1"));
                numeros.Remove(1);
                score += 1;
                txt_score.text = score.ToString();
                getPointsSound.Play();
            } else {
                playerLost();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) {
            if (numeros.Contains(2)) {
                Destroy(GameObject.FindGameObjectWithTag("num2"));
                numeros.Remove(2);
                score += 1;
                txt_score.text = score.ToString();
                getPointsSound.Play();
            } else {
                playerLost();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) {
            if (numeros.Contains(3)) {
                Destroy(GameObject.FindGameObjectWithTag("num3"));
                numeros.Remove(3);
                score += 1;
                txt_score.text = score.ToString();
                getPointsSound.Play();
            } else {
                playerLost();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) {
            if (numeros.Contains(4)) {
                Destroy(GameObject.FindGameObjectWithTag("num4"));
                numeros.Remove(4);
                score += 1;
                txt_score.text = score.ToString();
                getPointsSound.Play();
            } else {
                playerLost();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) {
            if (numeros.Contains(5)) {
                Destroy(GameObject.FindGameObjectWithTag("num5"));
                numeros.Remove(5);
                score += 1;
                txt_score.text = score.ToString();
                getPointsSound.Play();
            } else {
                playerLost();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) {
            if (numeros.Contains(6)) {
                Destroy(GameObject.FindGameObjectWithTag("num6"));
                numeros.Remove(6);
                score += 1;
                txt_score.text = score.ToString();
                getPointsSound.Play();
            } else {
                playerLost();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7)) {
            if (numeros.Contains(7)) {
                Destroy(GameObject.FindGameObjectWithTag("num7"));
                numeros.Remove(7);
                score += 1;
                txt_score.text = score.ToString();
                getPointsSound.Play();
            } else {
                playerLost();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad8) || Input.GetKeyDown(KeyCode.Alpha8)) {
            if (numeros.Contains(8)) {
                Destroy(GameObject.FindGameObjectWithTag("num8"));
                numeros.Remove(8);
                score += 1;
                txt_score.text = score.ToString();
                getPointsSound.Play();
            } else {
                playerLost();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad9) || Input.GetKeyDown(KeyCode.Alpha9)) {
            if (numeros.Contains(9)) {
                Destroy(GameObject.FindGameObjectWithTag("num9"));
                numeros.Remove(9);
                score += 1;
                txt_score.text = score.ToString();
                getPointsSound.Play();
            } else {
                playerLost();
            }
        }

        if (Input.GetKeyDown(KeyCode.KeypadEnter)){
            if (playerIsDead == true) {
                SceneManager.LoadScene("01");
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (playerIsDead == true) {
                SceneManager.LoadScene("00");
            }
        }
    }

    private void stopWatch() {
        time += Time.deltaTime;
        time = time * 0.01f;
        string hours = Mathf.Floor((time % 216000) / 3600).ToString("00");
        string minutes = Mathf.Floor((time % 3600) / 60).ToString("00");
        string seconds = (time % 60).ToString("00");
        string text = hours + ":" + minutes + ":" + seconds;
        if (!numeros.Count.Equals(0)) { //Check if list is empty
            NotificationCenter.DefaultCenter().PostNotification(this, "increaseSpeed", time);
        }
    }

    void agregar(Notification notification) {
        numeros.Add((int)notification.data);
    }


    public void DeleteAll() {
        foreach (GameObject o in FindObjectsOfType<GameObject>()) {
            Destroy(o);
        }
    }

    public void playerLost() {

        lives = lives - 1;
        playerIsDead = true;

        switch (lives) {
            case 0:
                failCamera.enabled = true;
                mainCamera.enabled = false;
                if (score > maxScore) {
                    PlayerPrefs.SetInt("Maxscore", score); // Guardamos la puntuacion maxima
                    txt_newRecord.enabled = true;
                    newRecordSound.Play();
                } else {
                    txt_newRecord.enabled = false;
                }
                NotificationCenter.DefaultCenter().PostNotification(this, "stopGenerator");
                //Debug.Log("Puntuación: " + score + " --- Record: " + maxScore);
                txt_maxScore.text = "Max Score: " + maxScore.ToString();
                txt_yourScore.text = "Your Score: " + score.ToString();
                number_movement.speed = 4f;
                sourceMusic.volume = 0.0f;
                lostSound.Play();
                lostLiveSound.Play();
                lostLiveCamera.SetActive(true);
                Invoke("disableLostLiveCamera", 0.5f);
                break;
            case 1:
                uiLives[1].SetActive(false);
                lostLiveSound.Play();
                lostLiveCamera.SetActive(true);
                Invoke("disableLostLiveCamera", 0.5f);
                break;
            case 2:
                uiLives[2].SetActive(false);
                lostLiveSound.Play();
                lostLiveCamera.SetActive(true);
                Invoke("disableLostLiveCamera", 0.25f);
                break;
        }
    }

    public void disableLostLiveCamera() {
        lostLiveCamera.SetActive(false);
    }
}
