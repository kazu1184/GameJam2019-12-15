using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour
{
    Vector3 touchStartPos;
    Vector3 touchEndPos;
    string Direction;

    float lastDirectionY = 0;

    [SerializeField]
    GameObject scoreObject;
    Score score;


    void Start()
    {
        score = scoreObject.GetComponent<Score>();

        touchStartPos = Input.mousePosition;
    }

    void Update()
    {
        Flick();
    }

    void Flick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            touchStartPos = new Vector3(Input.mousePosition.x,
                Input.mousePosition.y,
                Input.mousePosition.z);
        }

        if (Input.GetMouseButton(0))
        {
            touchEndPos = new Vector3(Input.mousePosition.x,
                Input.mousePosition.y,
                Input.mousePosition.z);
                GetDirection();
        }
    }

    void GetDirection()
    {
        float directionX = touchEndPos.x - touchStartPos.x;
        float directionY = touchEndPos.y - touchStartPos.y;
        //xがｙより絶対値が大きい時。
        if (Mathf.Abs(directionY) < Mathf.Abs(directionX))
        {
            if (30 < directionX)
            {
                //右向きにフリック
                Direction = "right";

            }
            if (-30 > directionX)
            {
                //左向きにフリック
                Direction = "left";
            }
            //yがxより絶対値が大きい時。
        }
        else if (Mathf.Abs(directionX) < Mathf.Abs(directionY))
        {
            if (lastDirectionY < directionY)
            {
                //上向きにフリック
                Direction = "up";

                lastDirectionY = directionY;
                lastDirectionY *= 1;
            }
            else if(lastDirectionY > directionY)
            {
                //下向きのフリック
                Direction = "down";

                lastDirectionY = directionY;
                lastDirectionY *= 1;
            }
           else if(lastDirectionY == directionY)
            {
                Direction = "nothing";
            }
        }
        else
        {
            //タッチを検出
            Direction = "touch";
        }
        switch (Direction)
        {
            case "up":
                //上フリックされた時の処理
                Debug.Log("up");
                score.pScore += 0.1f;
                break;

            case "down":
                //下フリックされた時の処理
                Debug.Log("down");
                score.pScore += 0.1f;
                break;

            case "right":
                //右フリックされた時の処理
                break;

            case "left":
                //左フリックされた時の処理
                break;

            case "touch":
                //タッチされた時の処理
                break;
            case "nothing":
                Debug.Log("nothing");
                score.pScore += 0;
                break;
        }

    }
}
