using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopNumbers : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 30; i++)
        {
            if (i <= 10)
            {
                Debug.Log(i);
            }
            
            int total = 0;
            total = i % 2;

            if (i >= 10 && i <= 20 && total == 0)
            {
                Debug.Log(i);
            }

            if (i >= 20 && i <= 30 && total != 0)
            {
                Debug.Log(i);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
