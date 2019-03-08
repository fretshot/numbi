using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class number_movement : MonoBehaviour{

    public float speed = 3f;

    void Update(){
        transform.Translate(Vector2.down * speed * Time.deltaTime); 
    }

}
