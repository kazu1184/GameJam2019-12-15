using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeController : MonoBehaviour
{
    readonly int OneSeconds = 60;
    [SerializeField]
    int time;
    int currentTime;
    int initializeTime = 0;
    [SerializeField]
    Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        //initializeTime = time;
    }

    // Update is called once per frame
    void Update()
    {
        if (time <= 0)
            return;

        currentTime++;

        if (currentTime >= OneSeconds)
        {
            time--;
            currentTime = 0;
        }


        timeText.text = "Time:" + time.ToString();

        if (time <= 0)
        {
            // ToDo
            // LoadScene
        }
    }

    public int pTime
    {
        get { return time; }
        set { time = value; }
    }
}
