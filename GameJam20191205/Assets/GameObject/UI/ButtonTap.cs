using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTap : MonoBehaviour
{
    [SerializeField]
    GameObject scoreObject;
    Score score;

    private void Start()
    {
        score = scoreObject.GetComponent<Score>();
    }

    public void TapWarkOut()
    {
        score.pScore += 1;
    }
}
