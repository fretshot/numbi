﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class number_movement : MonoBehaviour{

    public static float speed = 3f;

    private void Start() {
        NotificationCenter.DefaultCenter().AddObserver(this, "increaseSpeed");
    }

    void Update(){
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    void increaseSpeed(Notification notification) {
        speed = speed + (float)notification.data;
    }
}
