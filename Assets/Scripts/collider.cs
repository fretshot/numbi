using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour{

    public Camera failCamera;
    public Camera mainCamera;

    void OnTriggerEnter2D(Collider2D other){
        Destroy(other.gameObject);
        NotificationCenter.DefaultCenter().PostNotification(this, "stopGenerator");
        NotificationCenter.DefaultCenter().PostNotification(this, "playerLost");
    }

}
