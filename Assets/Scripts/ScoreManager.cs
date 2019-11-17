using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    
    public Vector3 ship_position;
    public TextMeshProUGUI assign_text_1;

    public static int score;

    public float MaxVal = 0f;

    private float k;

    void Start()
    {
        score = 0;
        SetCountText();
    }
    void Update()
    {
        ship_position = GameObject.Find("Main_character").transform.position;
        k = ship_position.y*5;
        MaxVal = Mathf.Max(k, MaxVal);
        score = Mathf.FloorToInt(MaxVal);
        SetCountText();
    }
    void SetCountText()
    {
        assign_text_1.text = score.ToString();
    }
    void OnGUI()
    {
        //GUI.Label (Rect (25, 25, 100, 30), score.ToString);
    }

    public void setHighScore()
    {   
        StartCoroutine(WaitSetHighScore());
    }

    private IEnumerator WaitSetHighScore()
    {
        yield return new WaitForSeconds(0.4f);
        if (Mathf.FloorToInt(MaxVal)>PlayerPrefs.GetInt("HighScore",0))
        {
            PlayerPrefs.SetInt("HighScore", Mathf.FloorToInt(MaxVal));
        }
    }
}
