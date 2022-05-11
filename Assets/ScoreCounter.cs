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


    void Start()
    {

        //　シーン中のScoreTextオブジェクトを取得
        this.ScoreText = GameObject.Find("ScoreText");

    }

    void Update()
    {

        // 表示
        this.ScoreText.GetComponent<Text>().text = Score + "点";
    }

    void OnCollisionEnter(Collision other)
    {
        //　ダグによって加算されるスコアを変える
        
        if (other.gameObject.tag == "SmallStarTag")
        {
            Score += 2;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            Score += 5;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            Score += 1;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            Score += 3;
        }

        

    }

}