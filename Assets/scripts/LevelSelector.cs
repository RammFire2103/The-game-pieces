using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelSelector : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite curentBackgroundLevelSelector;
    void Start()
    {
        if (forChanges.curentBackground1){
            curentBackgroundLevelSelector = forChanges.curentBackground1;
            GameObject.Find("Panel").GetComponent<Image>().sprite = curentBackgroundLevelSelector;
        }
    }

    public void Next()
    {
        forChanges.pageNum = 3;
        SceneManager.LoadScene(3);
    }
    public void Prev()
    {
        forChanges.pageNum = 2;
        SceneManager.LoadScene(2);
    }

    public void backButton()
    {
        SceneManager.LoadScene(0);
    }
    public void lvl1()
    {
        SceneManager.LoadScene(4);
    }
    public void lvl2()
    {
        SceneManager.LoadScene(5);
    }
    public void lvl3()
    {
        SceneManager.LoadScene(6);
    }
    public void lvl4()
    {
        SceneManager.LoadScene(7);
    }
    public void lvl5()
    {
        SceneManager.LoadScene(8);
    }
    public void lvl6()
    {
        SceneManager.LoadScene(9);
    }
    public void lvl7()
    {
        SceneManager.LoadScene(10);
    }
    public void lvl8()
    {
        SceneManager.LoadScene(11);
    }
    public void lvl9()
    {
        SceneManager.LoadScene(12);
    }
    public void lvl10()
    {
        SceneManager.LoadScene(13);
    }
    public void lvl11()
    {
        SceneManager.LoadScene(14);
    }
    public void lvl12()
    {
        SceneManager.LoadScene(15);
    }
    public void lvl13()
    {
        SceneManager.LoadScene(16);
    }
    public void lvl14()
    {
        SceneManager.LoadScene(17);
    }
    public void lvl15()
    {
        SceneManager.LoadScene(18);
    }
    public void lvl16()
    {
        SceneManager.LoadScene(19);
    }
}
