using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameplay : MonoBehaviour{

    private List<int> numeros;
    private int score = 0;
    //private int maxScore = 0;
    public Text text_score;
    //public Text text_maxScore;
    float time;

    void Start(){
        
        numeros = new List<int>();
        NotificationCenter.DefaultCenter().AddObserver(this, "agregar");
        
        if (PlayerPrefs.HasKey("Maxscore")) {
            //maxScore = PlayerPrefs.GetInt("Maxscore");
            //text_maxScore.text = maxScore.ToString();
        }
    }

    private void Update() {

        stopWatch();

        if (Input.GetKeyDown(KeyCode.Keypad0) || Input.GetKeyDown(KeyCode.Alpha0)) {
            if (numeros.Contains(0)) {
                Destroy(GameObject.FindGameObjectWithTag("num0"));
                numeros.Remove(0);
                score += 1;
                text_score.text = score.ToString();
                
            } else {
                PlayerPrefs.SetInt("Maxscore", score);
                Debug.Break();
                // Usuario preciona una tecla cuando no hay instancia. Pierde
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) {
            if (numeros.Contains(1)) {
                Destroy(GameObject.FindGameObjectWithTag("num1"));
                numeros.Remove(1);
                score += 1;
                text_score.text = score.ToString();
            } else {
                PlayerPrefs.SetInt("Maxscore", score);
                Debug.Break();
               
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) {
            if (numeros.Contains(2)) {
                Destroy(GameObject.FindGameObjectWithTag("num2"));
                numeros.Remove(2);
                score += 1;
                text_score.text = score.ToString();
            } else {
                PlayerPrefs.SetInt("Maxscore", score);
                Debug.Break();
                
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) {
            if (numeros.Contains(3)) {
                Destroy(GameObject.FindGameObjectWithTag("num3"));
                numeros.Remove(3);
                score += 1;
                text_score.text = score.ToString();
            } else {
                Debug.Break();
                PlayerPrefs.SetInt("Maxscore", score);
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) {
            if (numeros.Contains(4)) {
                Destroy(GameObject.FindGameObjectWithTag("num4"));
                numeros.Remove(4);
                score += 1;
                text_score.text = score.ToString();
            } else {
                Debug.Break();
                PlayerPrefs.SetInt("Maxscore", score);
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) {
            if (numeros.Contains(5)) {
                Destroy(GameObject.FindGameObjectWithTag("num5"));
                numeros.Remove(5);
                score += 1;
                text_score.text = score.ToString();
            } else {
                PlayerPrefs.SetInt("Maxscore", score);
                Debug.Break();
                
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) {
            if (numeros.Contains(6)) {
                Destroy(GameObject.FindGameObjectWithTag("num6"));
                numeros.Remove(6);
                score += 1;
                text_score.text = score.ToString();
            } else {
                PlayerPrefs.SetInt("Maxscore", score);
                Debug.Break();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7)) {
            if (numeros.Contains(7)) {
                Destroy(GameObject.FindGameObjectWithTag("num7"));
                numeros.Remove(7);
                score += 1;
                text_score.text = score.ToString();
            } else {
                PlayerPrefs.SetInt("Maxscore", score);
                Debug.Break();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad8) || Input.GetKeyDown(KeyCode.Alpha8)) {
            if (numeros.Contains(8)) {
                Destroy(GameObject.FindGameObjectWithTag("num8"));
                numeros.Remove(8);
                score += 1;
                text_score.text = score.ToString();
            } else {
                PlayerPrefs.SetInt("Maxscore", score);
                Debug.Break();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad9) || Input.GetKeyDown(KeyCode.Alpha9)) {
            if (numeros.Contains(9)) {
                Destroy(GameObject.FindGameObjectWithTag("num9"));
                numeros.Remove(9);
                score += 1;
                text_score.text = score.ToString();
            } else {
                PlayerPrefs.SetInt("Maxscore", score);
                Debug.Break();
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
        if (numeros.Count!=0) { //Check if list is empty
            NotificationCenter.DefaultCenter().PostNotification(this, "increaseSpeed", time);
        }
    }

    void agregar(Notification notification) {
        numeros.Add((int)notification.data);
    }
}
