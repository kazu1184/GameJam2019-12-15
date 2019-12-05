using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTap : MonoBehaviour
{
    [SerializeField]
    GameObject scoreObject;
    [SerializeField]
    GameObject timeObject;
    Score score;
    TimeController time;

    private void Start()
    {
        score = scoreObject.GetComponent<Score>();
        time = timeObject.GetComponent<TimeController>();
    }

    public void TapWarkOut()
    {
        if (time.pTime <= 0)
            return;
        score.pScore += 1;
    }
}
