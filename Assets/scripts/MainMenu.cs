using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Sprite curentBackgroundMain;

    void Start() {
        if (forChanges.curentBackground1){
            curentBackgroundMain = forChanges.curentBackground1;
            GameObject.Find("Panel").GetComponent<Image>().sprite = curentBackgroundMain;
        }
        forChanges.pageNum = 2;
    }
    public void Play()
    {
        SceneManager.LoadScene(2);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Settings()
    {
        forChanges.curentBackground1 = GameObject.Find("Panel").GetComponent<Image>().sprite;
        SceneManager.LoadScene(1);
    }
}
