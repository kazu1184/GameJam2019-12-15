using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    new GameObject[] gameObjectArray;

    [SerializeField]
    private int numberOfPeople = 0;
    [SerializeField]
    GameObject timeObj;
    TimeController time;
    int random = 0;
    // Start is called before the first frame update
    void Start()
    {
        time = timeObj.GetComponent<TimeController>();
        random = Random.Range(0, 1);
        MenuSelection();
    }

    // Update is called once per frame
    void Update()
    {
        if(time.pTime <= 0)
        {
            numberOfPeople--;
            if(numberOfPeople > 0)
            {
                SceneManager.LoadScene("WorkoutScene");
            }
            else
            {
                SceneManager.LoadScene("BattleScene");
            }
        }
    }

    private void MenuSelection()
    {
        for (int i = 0; i < gameObjectArray.Length; i++)
        {
            if (random == i)
                gameObjectArray[i].SetActive(true);
            else
                gameObjectArray[i].SetActive(false);
        }
    }

    public int Phase
    {
        set { numberOfPeople = value; }
        get { return numberOfPeople; }
    }

    public int WorkoutMenu
    {
        get { return random; }
    }
}
