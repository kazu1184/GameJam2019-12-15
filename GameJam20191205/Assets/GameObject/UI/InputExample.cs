using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InputExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetText()
    {
        //InputFieldのTextコンポーネントを取得
        Text inputText = GameObject.Find("InputField/Text").GetComponent<Text>();

        //Text型をstring型に変換
        string name = inputText.text;

        switch(name)
        {
            case "1":
                Debug.Log(name + "player");
                SceneManager.LoadScene("WorkoutScene");
                break;
            case "2":
                Debug.Log(name + "player");
                SceneManager.LoadScene("WorkoutScene");
                break;
            case "3":
                Debug.Log(name + "player");
                SceneManager.LoadScene("WorkoutScene");
                break;
            default:
                Debug.Log("not player");
                SceneManager.LoadScene("Select");
                break;
        }
        InputField form = GameObject.Find("InputField").GetComponent<InputField>();
        form.text = "";
    }
}
