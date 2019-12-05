using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private static float score;
    [SerializeField]
    private Text scoreText;
    int showScore;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        showScore = (int)score;
        scoreText.text = "Score::"+ showScore.ToString();
    }

    public float pScore
    {
        get { return score; }
        set { score = value; }
    }
}
