using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    private MusicScript music;
    public Button musicToggleButton;
    public Sprite musicOnSprite;
    public Sprite musicOffSprite;

    void Start(){
        music = GameObject.FindObjectOfType<MusicScript>();
        UpdateIcon();
    }

    void Update(){

    }

    public void PauseMusic(){
        music.ToggleSound();
        UpdateIcon();
    }

    void UpdateIcon(){
        if (PlayerPrefs.GetInt("Muted", 0) == 0){
            AudioListener.volume = 1;
            musicToggleButton.GetComponent<Image>().sprite = musicOnSprite;
        }
        else{
            AudioListener.volume = 0;
            musicToggleButton.GetComponent<Image>().sprite = musicOffSprite;
        }
    }
}
