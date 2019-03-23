using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class settings : MonoBehaviour{


    public Slider sliderMusic;
    private AudioSource sourceMusic;

    void Start(){
        sourceMusic = GetComponent<AudioSource>();

        if (PlayerPrefs.HasKey("MusicVolume")) {
            sliderMusic.value = PlayerPrefs.GetFloat("MusicVolume");
            sourceMusic.volume = PlayerPrefs.GetFloat("MusicVolume");
        }
    }

    public void SliderMusic() {
        sourceMusic.volume = sliderMusic.value;
        PlayerPrefs.SetFloat("MusicVolume", sliderMusic.value);
    }
}
