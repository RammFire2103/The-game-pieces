using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LvlScript : MonoBehaviour
{
    public Sprite curentBackgroundLvl;
    public static Vector3 curentFigureSizeLvl;
    public bool Ans;
    public float _endPos;
    public GameObject piece1;
    public GameObject piece2;
    public GameObject truePiece;
    public GameObject piece4;
    public Vector3 center;
    public Vector3 size;
    private RectTransform t;
    private RectTransform pt;

    public AudioSource soundMachine;
    public AudioClip falseButtonSound;
    public AudioClip TrueButtonSound;

    GameObject image;
    GameObject PanelForBlock;
    GameObject PanelForShadow;
    GameObject OutlineImage;

    public Vector2 newAnchorsMin;
    public Vector2 newAnchorsMax;

    void Start()
    {
        OutlineImage = GameObject.Find("ImageOutlineFigure");
        GameObject[] arrayOfPieces = {GameObject.Find("Piece 1"), GameObject.Find("Piece 2"), GameObject.Find("Piece3"), GameObject.Find("Piece 4")};
        Vector3[] arrayOfPositions = {arrayOfPieces[0].transform.position, arrayOfPieces[1].transform.position, arrayOfPieces[2].transform.position, arrayOfPieces[3].transform.position};
        System.Random random = new System.Random();
        
        PanelForBlock = GameObject.Find("PanelForBlock");
        PanelForShadow = GameObject.Find("PanelShadow");
        PanelForBlock.SetActive(false);

        


        for (int i = arrayOfPieces.Length - 1; i >= 1; i--)
        {
            int j = random.Next(i + 1);
 
            GameObject tmp = arrayOfPieces[j];
            arrayOfPieces[j] = arrayOfPieces[i];
            arrayOfPieces[i] = tmp;
        }
        arrayOfPieces[0].transform.position = arrayOfPositions[0];
        arrayOfPieces[1].transform.position = arrayOfPositions[1];
        arrayOfPieces[2].transform.position = arrayOfPositions[2];
        arrayOfPieces[3].transform.position = arrayOfPositions[3];

        for (int i = 0; i < 4; i++){
            t = arrayOfPieces[i].GetComponent<RectTransform>();
            pt = arrayOfPieces[i].GetComponent<RectTransform>().parent as RectTransform;

            if(t == null || pt == null) return;

            newAnchorsMin = new Vector2(t.anchorMin.x + t.offsetMin.x / pt.rect.width,
                                            t.anchorMin.y + t.offsetMin.y / pt.rect.height);
            newAnchorsMax = new Vector2(t.anchorMax.x + t.offsetMax.x / pt.rect.width,
                                            t.anchorMax.y + t.offsetMax.y / pt.rect.height);

            t.anchorMin = newAnchorsMin;
            t.anchorMax = newAnchorsMax;
            t.offsetMin = t.offsetMax = new Vector2(0, 0);
        }


        truePiece = GameObject.Find("Piece3");
        _endPos =  GameObject.Find("Figure").transform.position.x;
        if (forChanges.curentBackground1){
            curentBackgroundLvl = forChanges.curentBackground1;
            GameObject.Find("Panel").GetComponent<Image>().sprite = curentBackgroundLvl;
        }
        if (forChanges.curentFigureSize2 != new Vector3(0f, 0f, 0f)){
            curentFigureSizeLvl = forChanges.curentFigureSize2;
            GameObject.Find("Figure").GetComponent<RectTransform>().localScale = curentFigureSizeLvl;
            GameObject.Find("Piece 1").GetComponent<RectTransform>().localScale = curentFigureSizeLvl;
            GameObject.Find("Piece 2").GetComponent<RectTransform>().localScale = curentFigureSizeLvl;
            truePiece.GetComponent<RectTransform>().localScale = curentFigureSizeLvl;
            GameObject.Find("Piece 4").GetComponent<RectTransform>().localScale = curentFigureSizeLvl;
        }
        if (forChanges.curentFigureColor1 != new Vector4(0f,0f,0f,0f)){
            GameObject.Find("Figure").GetComponent<Image>().color = forChanges.curentFigureColor1;
        }
        if (forChanges.curentPicesColor1 != new Vector4(0f,0f,0f,0f)){
            GameObject.Find("Piece 1").GetComponent<Image>().color = forChanges.curentPicesColor1;
            GameObject.Find("Piece 2").GetComponent<Image>().color = forChanges.curentPicesColor1;
            GameObject.Find("Piece3").GetComponent<Image>().color = forChanges.curentPicesColor1;
            GameObject.Find("Piece 4").GetComponent<Image>().color = forChanges.curentPicesColor1;
        }
        int k = forChanges.curentPosition1;
        if (k == 2){
            System.Random rnd = new System.Random();
            k = rnd.Next(0, 2);
        }
        if (k == 1){
            GameObject.Find("PanelWithFigure").transform.position = new Vector3(Screen.width/1.28f,Screen.height/2,0);
            GameObject.Find("PanelWithPieces").transform.position = new Vector3(Screen.width / 3.57382182f,Screen.height/2,0);
            GameObject.Find("backButton").transform.position = new Vector3(Screen.width / 1.09731852f,Screen.height / 12.3534475f,0);
            PanelForShadow.transform.position = new Vector3(Screen.width / 3.57382182f,Screen.height/2,0);
        }
        
        // t = GameObject.Find("PanelWithFigure").GetComponent<RectTransform>();
        // pt = GameObject.Find("PanelWithFigure").GetComponent<RectTransform>().parent as RectTransform;

        // if(t == null || pt == null) return;

        // newAnchorsMin = new Vector2(t.anchorMin.x + t.offsetMin.x / pt.rect.width,
        //                                     t.anchorMin.y + t.offsetMin.y / pt.rect.height);
        // newAnchorsMax = new Vector2(t.anchorMax.x + t.offsetMax.x / pt.rect.width,
        //                                     t.anchorMax.y + t.offsetMax.y / pt.rect.height);

        // t.anchorMin = newAnchorsMin;
        // t.anchorMax = newAnchorsMax;
        // t.offsetMin = t.offsetMax = new Vector2(0, 0);
        

        if (!(forChanges.outlineVar1)){
            OutlineImage.SetActive(false);
        }
        Ans = false;
    }

    public void TrueChoice(){
        Ans = true;
        soundMachine.PlayOneShot(TrueButtonSound);
    }

    public void falceChoice1(){
        Ans = false;
        soundMachine.PlayOneShot(falseButtonSound);
        image = GameObject.Find("Piece 1");
        Color color = image.GetComponent<Image>().color;
        color.a = 1f;
        image.GetComponent<Image>().color = color;
        StartCoroutine("Invisible");
    }

    public void falceChoice2(){
        Ans = false;
        soundMachine.PlayOneShot(falseButtonSound);
        image = GameObject.Find("Piece 2");
        Color color = image.GetComponent<Image>().color;
        color.a = 1f;
        image.GetComponent<Image>().color = color;
        StartCoroutine("Invisible");
    }

    public void falceChoice4(){
        Ans = false;
        soundMachine.PlayOneShot(falseButtonSound);
        image = GameObject.Find("Piece 4");
        Color color = image.GetComponent<Image>().color;
        color.a = 1f;
        image.GetComponent<Image>().color = color;
        StartCoroutine("Invisible");
    }

    IEnumerator Invisible(){
        for (float f = 1f; f >= 0; f -= 0.25f){
            Color color = image.GetComponent<Image>().color;
            color.a = f;
            image.GetComponent<Image>().color = color;
            yield return new WaitForSeconds(0.05f);
            if (f == 0f){
                Destroy(image);
            }
        }
    }

    IEnumerator Visible(){
        for (float f = 0f; f <= 2f; f += 0.05f){
            Color color = image.GetComponent<Image>().color;
            color.a = f;
            image.GetComponent<Image>().color = color;
            color = GameObject.Find("Nice").GetComponent<TextMeshProUGUI>().color;
            color.a = f;
            GameObject.Find("Nice").GetComponent<TextMeshProUGUI>().color = color;
            color = GameObject.Find("backButton").GetComponent<Image>().color;
            color.a = f;
            GameObject.Find("backButton").GetComponent<Image>().color = color;
            yield return new WaitForSeconds(0.001f);
        }
    }

    public void backButton()
    {
        SceneManager.LoadScene(forChanges.pageNum);
    }
    // Update is called once per frame
    void Update()
    {
        if (Ans){
            truePiece.transform.position = Vector3.Lerp(truePiece.transform.position, GameObject.Find("Figure").transform.position, Time.deltaTime *18);
            Debug.Log(truePiece.transform.position + "piece");
            Debug.Log(GameObject.Find("Figure").transform.position + "figure");
            if (Mathf.Round(truePiece.transform.position.x) == Mathf.Round(GameObject.Find("Figure").transform.position.x)){
                Ans = false;
                PanelForBlock.SetActive(true);
                Destroy(GameObject.Find("backButton"));
                image = GameObject.Find("PanelForNext");
                Color color = image.GetComponent<Image>().color;
                color.a = 0f;
                image.GetComponent<Image>().color = color;
                StartCoroutine("Visible");
            }
        }
    }
}
