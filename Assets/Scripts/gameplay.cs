using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameplay : MonoBehaviour{

    public List<int> numeros;

    void Start(){
        numeros = new List<int>();
        NotificationCenter.DefaultCenter().AddObserver(this, "agregar");
    }

    void agregar(Notification notification) {
        numeros.Add((int)notification.data);
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Keypad0)) {
            if (numeros.Contains(0)) {
                Destroy(GameObject.FindGameObjectWithTag("num0"));
                numeros.Remove(0);
            } else {
                Debug.Break();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad1)) {
            if (numeros.Contains(1)) {
                Destroy(GameObject.FindGameObjectWithTag("num1"));
                numeros.Remove(1);
            } else {
                Debug.Break();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad2)) {
            if (numeros.Contains(2)) {
                Destroy(GameObject.FindGameObjectWithTag("num2"));
                numeros.Remove(2);
            } else {
                Debug.Break();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad3)) {
            if (numeros.Contains(3)) {
                Destroy(GameObject.FindGameObjectWithTag("num3"));
                numeros.Remove(3);
            } else {
                Debug.Break();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad4)) {
            if (numeros.Contains(4)) {
                Destroy(GameObject.FindGameObjectWithTag("num4"));
                numeros.Remove(4);
            } else {
                Debug.Break();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad5)) {
            if (numeros.Contains(5)) {
                Destroy(GameObject.FindGameObjectWithTag("num5"));
                numeros.Remove(5);
            } else {
                Debug.Break();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad6)) {
            if (numeros.Contains(6)) {
                Destroy(GameObject.FindGameObjectWithTag("num6"));
                numeros.Remove(6);
            } else {
                Debug.Break();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad7)) {
            if (numeros.Contains(7)) {
                Destroy(GameObject.FindGameObjectWithTag("num7"));
                numeros.Remove(7);
            } else {
                Debug.Break();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad8)) {
            if (numeros.Contains(8)) {
                Destroy(GameObject.FindGameObjectWithTag("num8"));
                numeros.Remove(8);
            } else {
                Debug.Break();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad9)) {
            if (numeros.Contains(9)) {
                Destroy(GameObject.FindGameObjectWithTag("num9"));
                numeros.Remove(9);
            } else {
                Debug.Break();
            }
        }
    }
}
