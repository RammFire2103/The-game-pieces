using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class settings : MonoBehaviour
{
    public bool outlineVar; 

    public Vector3 V3;
    public Vector3 position;
    public Vector3 position1;
    public float y;
    public float x;
    public int sliderValue;
    public GameObject Indicator;
    public float widthDisp;
    public float heightDisp;
    Slider slider;
    public GameObject panelOfFigureSize;
    public GameObject panelOfOutlinepieces;
    public GameObject panelOfPosition;
    public GameObject panelOfFigureColor;
    public GameObject panelOfPicesColor;
    public GameObject panelOfBackground;
    public GameObject outlineImage;
    public Sprite backgroundImg;
    public Sprite background2Img;
    public Sprite background3Img;
    public Sprite background4Img;
    public Sprite background5Img;
    public Sprite background6Img;

    public Sprite curentBackground;
    public float curentFigureSize;
    public Vector3 curentFigureSizeChange;
    public Vector4 curentFigureColor;
    public Vector4 curentPicesColor;
    public int curentPosition;
    
    public Vector4 colorFigure;
    public Vector4 colorPices;

    public AudioClip din;
    public AudioSource audioButton;

    public void backButton(){
        forChanges.curentPosition1 = curentPosition;
        forChanges.curentFigureSize1 = curentFigureSize;
        forChanges.curentFigureSize2 = curentFigureSizeChange;
        forChanges.curentBackground1 = curentBackground;
        forChanges.curentFigureColor1 = curentFigureColor;
        forChanges.curentPicesColor1 = curentPicesColor;
        forChanges.outlineVar1 = outlineVar;
        forChanges.position1 = position;
        forChanges.position11 = position1;
        SceneManager.LoadScene(0);
    }

    public void figureSizeButton(){
        audioButton.PlayOneShot(din);
        if (panelOfFigureColor.activeSelf == true){
            colorFigure = GameObject.Find("exsampleOfFigureColor").GetComponent<Image>().color;
        }
        panelOfFigureSize.SetActive(true);
        panelOfBackground.SetActive(false);
        panelOfPicesColor.SetActive(false);
        panelOfFigureColor.SetActive(false);
        panelOfPosition.SetActive(false);
        panelOfOutlinepieces.SetActive(false);
        GameObject.Find("exsampleOfFigure").GetComponent<Image>().color = colorFigure;
        if (forChanges.curentFigureColor1 != new Vector4(0f,0f,0f,0f)){
            GameObject.Find("exsampleOfFigure").GetComponent<Image>().color = colorFigure;
        }
        y = GameObject.Find("figureSizeButton").transform.position.y;
        x = GameObject.Find("figureSizeButton").transform.position.x + Screen.width / 5.4857f;
        Indicator.transform.position = new Vector3(x, y, 90);
    }

    public void positionButton(){
        audioButton.PlayOneShot(din);
        panelOfPosition.SetActive(true);
        panelOfFigureSize.SetActive(false);
        panelOfBackground.SetActive(false);
        panelOfPicesColor.SetActive(false);
        panelOfFigureColor.SetActive(false);
        panelOfOutlinepieces.SetActive(false);
        y = GameObject.Find("positionButton").transform.position.y;
        x = GameObject.Find("positionButton").transform.position.x + Screen.width / 5.4857f;
        Indicator.transform.position = new Vector3(x, y, 90);
        y = GameObject.Find("figureLeft").transform.position.y;
        x = GameObject.Find("figureLeft").transform.position.x + Screen.width / 5.4857f;
        if (position1 != new Vector3(0, 0, 0)){
            GameObject.Find("indicatorPosition").transform.position = position1;
        }
        else{
            GameObject.Find("indicatorPosition").transform.position = new Vector3(x, y, 90);
        }
    }

    public void Right(){
        audioButton.PlayOneShot(din);
        curentPosition = 1;
        y = GameObject.Find("figureRight").transform.position.y;
        x = GameObject.Find("figureRight").transform.position.x + Screen.width / 5.4857f;
        GameObject.Find("indicatorPosition").transform.position = new Vector3(x, y, 90);
        position1 =new Vector3(x, y, 90);
    }
    public void Left(){
        audioButton.PlayOneShot(din);
        curentPosition = 0;
        y = GameObject.Find("figureLeft").transform.position.y;
        x = GameObject.Find("figureLeft").transform.position.x + Screen.width / 5.4857f;
        GameObject.Find("indicatorPosition").transform.position = new Vector3(x, y, 90);
        position1 =new Vector3(x, y, 90);
    }
    public void Random(){
        audioButton.PlayOneShot(din);
        curentPosition = 2;
        y = GameObject.Find("figureRandom").transform.position.y;
        x = GameObject.Find("figureRandom").transform.position.x + Screen.width / 5.4857f;
        GameObject.Find("indicatorPosition").transform.position = new Vector3(x, y, 90);
        position1 =new Vector3(x, y, 90);
    }




    public void figureColorButton(){
        audioButton.PlayOneShot(din);
        panelOfFigureSize.SetActive(false);
        panelOfBackground.SetActive(false);
        panelOfPicesColor.SetActive(false);
        panelOfFigureColor.SetActive(true);
        panelOfPosition.SetActive(false);
        panelOfOutlinepieces.SetActive(false);
        if (slider.value == 1){
                GameObject.Find("exsampleOfFigureColor").GetComponent<RectTransform>().localScale = new Vector3(1f, 1f, 1f);
            }
            if (slider.value == 2){
                GameObject.Find("exsampleOfFigureColor").GetComponent<RectTransform>().localScale = new Vector3(1.25f,1.25f,1.25f);
            }
            if (slider.value == 3){
                GameObject.Find("exsampleOfFigureColor").GetComponent<RectTransform>().localScale = new Vector3(1.5f,1.5f,1.5f);
            }
            if (slider.value == 4){
                GameObject.Find("exsampleOfFigureColor").GetComponent<RectTransform>().localScale = new Vector3(2f,2f,2f);
        }
        y = GameObject.Find("figureColorButton").transform.position.y;
        if (forChanges.curentFigureColor1 != new Vector4(0f,0f,0f,0f)){
            GameObject.Find("exsampleOfFigureColor").GetComponent<Image>().color = colorFigure;
        }
        x = GameObject.Find("figureSizeButton").transform.position.x + Screen.width / 5.4857f;
        Indicator.transform.position = new Vector3(x, y, 90);
    }

    public void picesColorButton(){
        audioButton.PlayOneShot(din);
        panelOfFigureSize.SetActive(false);
        panelOfBackground.SetActive(false);
        panelOfPosition.SetActive(false);
        panelOfFigureColor.SetActive(false);
        panelOfPicesColor.SetActive(true);
        panelOfOutlinepieces.SetActive(false);
        if (slider.value == 1){
                GameObject.Find("exsampleOfPicesColor").GetComponent<RectTransform>().localScale = new Vector3(1f, 1f, 1f);
            }
            if (slider.value == 2){
                GameObject.Find("exsampleOfPicesColor").GetComponent<RectTransform>().localScale = new Vector3(1.25f,1.25f,1.25f);
            }
            if (slider.value == 3){
                GameObject.Find("exsampleOfPicesColor").GetComponent<RectTransform>().localScale = new Vector3(1.5f,1.5f,1.5f);
            }
            if (slider.value == 4){
                GameObject.Find("exsampleOfPicesColor").GetComponent<RectTransform>().localScale = new Vector3(2f,2f,2f);
        }
        if (forChanges.curentPicesColor1 != new Vector4(0f,0f,0f,0f)){
            GameObject.Find("exsampleOfPicesColor").GetComponent<Image>().color = colorPices;
        }
        y = GameObject.Find("picesColorButton").transform.position.y;
        x = GameObject.Find("figureSizeButton").transform.position.x + Screen.width / 5.4857f;
        Indicator.transform.position = new Vector3(x, y, 90);
    }

    public void backgroundButton(){
        audioButton.PlayOneShot(din);
        panelOfBackground.SetActive(true);
        panelOfFigureSize.SetActive(false);
        panelOfPosition.SetActive(false);
        panelOfFigureColor.SetActive(false);
        panelOfPicesColor.SetActive(false);
        panelOfOutlinepieces.SetActive(false);
        y = GameObject.Find("backgroundButton").transform.position.y;
        x = GameObject.Find("figureSizeButton").transform.position.x + Screen.width / 5.4857f;
        Indicator.transform.position = new Vector3(x, y, 90);
        if (position != new Vector3(0, 0, 0)){
            GameObject.Find("indicatorBackgrund").transform.position = position;
        }
    }

    

    public void background(){
        audioButton.PlayOneShot(din);
        y = GameObject.Find("backgrundMini").transform.position.y - Screen.height / 5.3f;
        x = GameObject.Find("backgrundMini").transform.position.x;
        GameObject.Find("indicatorBackgrund").transform.position = new Vector3(x, y, 90);
        position = new Vector3(x, y, 90);
        GameObject.Find("backgroundPanel").GetComponent<Image>().sprite = backgroundImg;
        curentBackground = backgroundImg;
    }
    public void background2(){
        audioButton.PlayOneShot(din);
        y = GameObject.Find("backgrundMini2").transform.position.y - Screen.height / 5.3f;
        x = GameObject.Find("backgrundMini2").transform.position.x;
        GameObject.Find("indicatorBackgrund").transform.position = new Vector3(x, y, 90);
        position = new Vector3(x, y, 90);
        GameObject.Find("backgroundPanel").GetComponent<Image>().sprite = background2Img;
        curentBackground = background2Img;
    }
    public void background3(){
        audioButton.PlayOneShot(din);
        y = GameObject.Find("backgrundMini3").transform.position.y - Screen.height / 5.3f;
        x = GameObject.Find("backgrundMini3").transform.position.x;
        GameObject.Find("indicatorBackgrund").transform.position = new Vector3(x, y, 90);
        position = new Vector3(x, y, 90);
        GameObject.Find("backgroundPanel").GetComponent<Image>().sprite = background3Img;
        curentBackground = background3Img;
    }
    public void background4(){
        audioButton.PlayOneShot(din);
        y = GameObject.Find("backgrundMini4").transform.position.y - Screen.height / 5.3f;
        x = GameObject.Find("backgrundMini4").transform.position.x;
        GameObject.Find("indicatorBackgrund").transform.position = new Vector3(x, y, 90);
        position = new Vector3(x, y, 90);
        GameObject.Find("backgroundPanel").GetComponent<Image>().sprite = background4Img;
        curentBackground = background4Img;
    }
    public void background5(){
        audioButton.PlayOneShot(din);
        y = GameObject.Find("backgrundMini5").transform.position.y - Screen.height / 5.3f;
        x = GameObject.Find("backgrundMini5").transform.position.x;
        GameObject.Find("indicatorBackgrund").transform.position = new Vector3(x, y, 90);
        position = new Vector3(x, y, 90);
        GameObject.Find("backgroundPanel").GetComponent<Image>().sprite = background5Img;
        curentBackground = background5Img;
    }
    public void background6(){
        audioButton.PlayOneShot(din);
        y = GameObject.Find("backgrundMini6").transform.position.y - Screen.height / 5.3f;
        x = GameObject.Find("backgrundMini6").transform.position.x;
        GameObject.Find("indicatorBackgrund").transform.position = new Vector3(x, y, 90);
        position = new Vector3(x, y, 90);
        GameObject.Find("backgroundPanel").GetComponent<Image>().sprite = background6Img;
        curentBackground = background6Img;
    }

    public void color1(){
        audioButton.PlayOneShot(din);
        if (panelOfFigureColor.activeSelf == true) {
            colorFigure = GameObject.Find("color1Button").GetComponent<Image>().color;
            GameObject.Find("exsampleOfFigureColor").GetComponent<Image>().color = colorFigure;
            curentFigureColor = colorFigure;
        }
        if (panelOfPicesColor.activeSelf == true) {
            colorPices = GameObject.Find("color1Button").GetComponent<Image>().color;
            GameObject.Find("exsampleOfPicesColor").GetComponent<Image>().color = colorPices;
            curentPicesColor = colorPices;
        }
    }
    public void color2(){
        audioButton.PlayOneShot(din);
        if (panelOfFigureColor.activeSelf == true) {
            colorFigure = GameObject.Find("color2Button").GetComponent<Image>().color;
            GameObject.Find("exsampleOfFigureColor").GetComponent<Image>().color = colorFigure;
            curentFigureColor = colorFigure;
        }
        if (panelOfPicesColor.activeSelf == true) {
            colorPices = GameObject.Find("color2Button").GetComponent<Image>().color;
            GameObject.Find("exsampleOfPicesColor").GetComponent<Image>().color = colorPices;
            curentPicesColor = colorPices;
        }
    }
    public void color3(){
        audioButton.PlayOneShot(din);
        if (panelOfFigureColor.activeSelf == true) {
            colorFigure = GameObject.Find("color3Button").GetComponent<Image>().color;
            GameObject.Find("exsampleOfFigureColor").GetComponent<Image>().color = colorFigure;
            curentFigureColor = colorFigure;
        }
        if (panelOfPicesColor.activeSelf == true) {
            colorPices = GameObject.Find("color3Button").GetComponent<Image>().color;
            GameObject.Find("exsampleOfPicesColor").GetComponent<Image>().color = colorPices;
            curentPicesColor = colorPices;
        }
            
    }
    public void color4(){
        audioButton.PlayOneShot(din);
        if (panelOfFigureColor.activeSelf == true) {
            colorFigure = GameObject.Find("color4Button").GetComponent<Image>().color;
            GameObject.Find("exsampleOfFigureColor").GetComponent<Image>().color = colorFigure;
            curentFigureColor = colorFigure;
        }
        if (panelOfPicesColor.activeSelf == true) {
            colorPices = GameObject.Find("color4Button").GetComponent<Image>().color;
            GameObject.Find("exsampleOfPicesColor").GetComponent<Image>().color = colorPices;
            curentPicesColor = colorPices;
        }
    }
    public void color5(){
        audioButton.PlayOneShot(din);
        if (panelOfFigureColor.activeSelf == true) {
            colorFigure = GameObject.Find("color5Button").GetComponent<Image>().color;
            GameObject.Find("exsampleOfFigureColor").GetComponent<Image>().color = colorFigure;
            curentFigureColor = colorFigure;
        }
        if (panelOfPicesColor.activeSelf == true) {
            colorPices = GameObject.Find("color5Button").GetComponent<Image>().color;
            GameObject.Find("exsampleOfPicesColor").GetComponent<Image>().color = colorPices;
            curentPicesColor = colorPices;
        }
    }
    public void color6(){
        audioButton.PlayOneShot(din);
        if (panelOfFigureColor.activeSelf == true) {
            colorFigure = GameObject.Find("color6Button").GetComponent<Image>().color;
            GameObject.Find("exsampleOfFigureColor").GetComponent<Image>().color = colorFigure;
            curentFigureColor = colorFigure;
        }
        if (panelOfPicesColor.activeSelf == true) {
            colorPices = GameObject.Find("color6Button").GetComponent<Image>().color;
            GameObject.Find("exsampleOfPicesColor").GetComponent<Image>().color = colorPices;
            curentPicesColor = colorPices;
        }
    }

    public void outlineButton(){
        audioButton.PlayOneShot(din);
        panelOfBackground.SetActive(false);
        panelOfFigureSize.SetActive(false);
        panelOfPosition.SetActive(false);
        panelOfFigureColor.SetActive(false);
        panelOfPicesColor.SetActive(false);
        panelOfOutlinepieces.SetActive(true);
        Debug.Log(x);
        y = GameObject.Find("outlineButton").transform.position.y;
        x = GameObject.Find("figureSizeButton").transform.position.x + Screen.width / 5.4857f;
        Debug.Log(x);
        Indicator.transform.position = new Vector3(x, y, 90);
        if (position != new Vector3(0, 0, 0)){
            GameObject.Find("indicator").transform.position = position;
        }
        if (outlineVar){
            outlineImage.SetActive(true);
        }
        else{
            outlineImage.SetActive(false);
        }
    }

    public void outlineTrue(){
        audioButton.PlayOneShot(din);
        outlineVar = true;
        outlineImage.SetActive(true);
    }

    public void outlineFalse(){
        audioButton.PlayOneShot(din);
        outlineVar = false;
        outlineImage.SetActive(false);
    }



    // Start is called before the first frame update
    void Start() {
        curentPosition = 0;
        Debug.Log(x);
        y = GameObject.Find("figureSizeButton").transform.position.y;
        x = GameObject.Find("figureSizeButton").transform.position.x + Screen.width / 5.4857f;
        Debug.Log(x);
        Indicator.transform.position = new Vector3(x, y, 90);
        y = GameObject.Find("backgrundMini").transform.position.y - Screen.height / 5.3f;
        x = GameObject.Find("backgrundMini").transform.position.x;
        GameObject.Find("indicatorBackgrund").transform.position = new Vector3(x, y, 90);
        slider = GameObject.Find("Slider").GetComponent<Slider>();
        panelOfPosition = GameObject.Find("settingsPositionPanel");
        panelOfFigureSize = GameObject.Find("settingsFigureSizePanel");
        panelOfBackground = GameObject.Find("settingsBackgroundPanel");
        panelOfFigureColor = GameObject.Find("settingsFigureColorPanel");
        panelOfPicesColor = GameObject.Find("settingsPicesColorPanel");
        panelOfOutlinepieces = GameObject.Find("settingsPicesOutlinePanel");
        outlineImage = GameObject.Find("outlineImage");
        panelOfFigureSize.SetActive(true);
        panelOfPosition.SetActive(false);
        panelOfBackground.SetActive(false);
        panelOfFigureColor.SetActive(false);
        panelOfPicesColor.SetActive(false);
        panelOfOutlinepieces.SetActive(false);
        colorFigure =  new Vector4(78/255.0f, 56/255.0f, 48/255.0f, 1);
        GameObject.Find("exsampleOfFigure").GetComponent<Image>().color = colorFigure;
        if (forChanges.curentBackground1){
            curentBackground = forChanges.curentBackground1;    
            GameObject.Find("backgroundPanel").GetComponent<Image>().sprite = curentBackground;;
        }
        if (forChanges.curentFigureColor1 != new Vector4(0f,0f,0f,0f)){
            colorFigure = forChanges.curentFigureColor1;
            curentFigureColor = forChanges.curentFigureColor1;
            GameObject.Find("exsampleOfFigure").GetComponent<Image>().color = colorFigure;
        }
        if (forChanges.curentFigureSize1 != 0f){
            curentFigureSize = forChanges.curentFigureSize1;
            slider.value = curentFigureSize;
        }
        if (forChanges.curentPicesColor1  != new Vector4(0f,0f,0f,0f)){
            colorPices = forChanges.curentPicesColor1;
            curentPicesColor = forChanges.curentPicesColor1;
        }
        if (panelOfFigureColor.activeSelf == true) {
            GameObject.Find("exsampleOfFigureColor").GetComponent<Image>().color = colorFigure;
        }
        outlineVar = forChanges.outlineVar1;
        position = forChanges.position1;
        position1 = forChanges.position11;
        curentPosition = forChanges.curentPosition1;
    }

    // Update is called once per frame
    void Update() {
        if (panelOfFigureSize.activeSelf == true){
            curentFigureSize = slider.value;
            if (curentFigureSize == 1){
                GameObject.Find("exsampleOfFigure").GetComponent<RectTransform>().localScale = new Vector3(1.5f, 1.5f, 1.5f);
                curentFigureSizeChange = new Vector3(1.5f, 1.5f, 1.5f);
            }
            if (curentFigureSize == 2){
                GameObject.Find("exsampleOfFigure").GetComponent<RectTransform>().localScale = new Vector3(1.88f,1.8f,1.8f);
                curentFigureSizeChange = new Vector3(1.88f,1.88f,1.88f);
            }
            if (curentFigureSize == 3){
                GameObject.Find("exsampleOfFigure").GetComponent<RectTransform>().localScale = new Vector3(2.2f,2.2f,2.2f);
                curentFigureSizeChange = new Vector3(2.2f,2.2f,2.2f);
            }
            if (curentFigureSize == 4){
                GameObject.Find("exsampleOfFigure").GetComponent<RectTransform>().localScale = new Vector3(2.5f,2.5f,2.5f);
                curentFigureSizeChange = new Vector3(2.5f,2.5f,2.5f);
            }
        }
    }
}


    