using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPower : MonoBehaviour
{
    int power;
    int[] range = { 10, 51 };

    // Start is called before the first frame update
    void Start()
    { 
        for(int i=0;i<Data.instance.Times;i++)
        {
            power = Random.Range(range[0], range[1]);
        }
        Debug.Log(power);
    }

    public int Power
    {
        set { power = value; }
        get { return power; }
    }
}
