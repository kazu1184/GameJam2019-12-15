﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private static float score;
    [SerializeField]
    private Text scoreText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score::"+score.ToString();
    }

    public float pScore
    {
        get { return score; }
        set { score = value; }
    }
}
