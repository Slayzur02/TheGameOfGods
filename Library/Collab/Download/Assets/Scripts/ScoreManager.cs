using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    
    public Vector3 ship_position;
    public Text assign_text_1;

    public static int score;

    public static float MaxVal = 0f;

    private float k;

    void Start()
    {
        score = 0;
        SetCountText();
    }
    void Update()
    {
        ship_position = GameObject.Find("Main_character").transform.position;
        k = ship_position.y;
        MaxVal = Mathf.Max(k, MaxVal);
        score = (int) (MaxVal / 3);
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
}
