using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{

    //  表示するテキスト
    private GameObject ScoreText;

    //　加算される数  
    private int Score = 0;

    //　タグによって変わる数
    private int score;

    // Materialを入れる
    Material myMaterial;

    void Start()
    {

        //　ダグによって加算されるスコアを変える
        if (tag == "SmallStarTag")
        {
            score = 2;
        }
        else if (tag == "LargeStarTag")
        {
            score = 5;
        }
        else if (tag == "SmallCloudTag")
        {
            score = 1;
        }
        else if (tag == "LargeCloudTag")
        {
            score = 3;
        }



        //オブジェクトにアタッチしているMaterialを取得
        this.myMaterial = GetComponent<Renderer>().material;

        //　シーン中のScoreTextオブジェクトを取得
        this.ScoreText = GameObject.Find("ScoreText");

    }

    void Update()
    {
        //　スコア計算
        Score += score;

        // 表示
        this.ScoreText.GetComponent<Text>().text = Score + "点";
    }

    void OnCollisionEnter(Collision other)
    {

        
    }

    }