using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CricleC : MonoBehaviour
{
    readonly float max_size = 5.0f;
    readonly float min_size = 0.3f;
    GameObject Cricle;
    Vector3 vel = new Vector3(-0.1f, -0.1f, 0);

    float score = 0;
    float getScore = 0;

    bool inputKey = false;
    float waitTimer = -1;

    Vector3 startScale;

    float bonus = 1;

    public GameObject circle;
    public GameObject circleMask;

    // Start is called before the first frame update
    void Start()
    {
        startScale = gameObject.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        waitTimer -= Time.deltaTime;

        if (waitTimer < 0)
        {
            if (waitTimer > -1)
            {
                gameObject.transform.localScale = startScale;
            }


            if (Input.GetMouseButtonDown(0))
            {
                float X_now = gameObject.transform.localScale.x;

                if(X_now <= 0.8f)
                {
                    bonus = 4f;
                }
                else if(X_now <= 1.7f)
                {
                    bonus = 3f;
                }
                else if (X_now <= 2.5f)
                {
                    bonus = 2f;
                }
                else
                {
                    bonus = 1f;
                }

                getScore = max_size - X_now;
                score += (max_size - X_now) * bonus;
                waitTimer = 3;
            }

            circle.transform.localScale += vel;

            if (circle.transform.localScale.x >= max_size || circle.transform.localScale.y >= max_size)
            {
                vel *= -1;
            }
            if (circle.transform.localScale.x <= min_size || circle.transform.localScale.y <= min_size)
            {
                vel *= -1;
            }

            float differential = circle.transform.localScale.x - 0.5f;
            circleMask.transform.localScale = new Vector3(differential, differential, 1);

        }

    }

    public float GetScore()
    {
        return score;
    }

    public float GetGetScore()
    {
        return getScore;
    }

    public float GetBonus()
    {
        return bonus;
    }
}
