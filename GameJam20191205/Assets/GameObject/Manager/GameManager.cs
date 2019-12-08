using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    new GameObject[] gameObjectArray;
    [SerializeField]
    GameObject[] modelArray = new GameObject[3];

    [SerializeField]
    GameObject timeObj;
    TimeController time;
    int random = 0;
    Data data;
    // Start is called before the first frame update
    void Start()
    {
        data = Data.instance;
        time = timeObj.GetComponent<TimeController>();
        //random = Random.Range(0, 3);
        random = 1;
        Debug.Log(random);
        MenuSelection();
    }

    // Update is called once per frame
    void Update()
    {
        if(time.pTime <= 0)
        {
            data.Times--;
            if(data.Times > 0)
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

            if (random == i)
                modelArray[i].SetActive(true);
            else
                modelArray[i].SetActive(false);

        }
    }

    public int Phase
    {
        set { data.Times = value; }
        get { return data.Times; }
    }

    public int WorkoutMenu
    {
        get { return random; }
    }
}
