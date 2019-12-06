using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameJudge : MonoBehaviour
{
    float time = 270;
    [SerializeField]
    GameObject enemyObj;
    EnemyPower enemy;

    // Start is called before the first frame update
    void Start()
    {
        enemy = enemyObj.GetComponent<EnemyPower>();
    }

    // Update is called once per frame
    void Update()
    {
        time--;
        Debug.Log(time);
        if(time <= 0)
        {
            Debug.Log("yes");
            Judge();
        }
    }

    void Judge()
    {
        int pScore = Data.instance.Score;
        Debug.Log(enemy);
        
        if(pScore < enemy.Power)
        {
            SceneManager.LoadScene("GameOverScore");
        }
        else 
        {
            SceneManager.LoadScene("ClearScene");
        }
    }
}
