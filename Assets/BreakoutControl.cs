using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakoutControl : MonoBehaviour
{
    public GameObject Blue,Green,Red,Yellow;
    System.Random random = new System.Random();
    // Start is called before the first frame update
    void Start()
    {
        createBricks();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void createBricks()
    {
        float d = 1.02f;
        float l = 0f;
        float k = 0f;
        int color;

        for (int j = 0; j < 24; j++)
        {
            k++;
            if (j % 8 == 0)
            {
                l++;
                k = 1;
            }
            color = random.Next(0, 4);
            switch(color)
            {
                case 0:
                 Instantiate(Blue, new Vector3(-5.02f + (k * d), 5f - (l * d), 0f), Quaternion.identity);
                 break;
                case 1:
                    Instantiate(Green, new Vector3(-5.02f + (k * d), 5f - (l * d), 0f), Quaternion.identity);
                    break;
                case 2:
                    Instantiate(Red, new Vector3(-5.02f + (k * d), 5f - (l * d), 0f), Quaternion.identity);
                    break;
                case 3:
                    Instantiate(Yellow, new Vector3(-5.02f + (k * d), 5f - (l * d), 0f), Quaternion.identity);
                    break;

            }
           
        }

    }
}
