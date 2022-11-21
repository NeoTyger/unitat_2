using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PairNumbers : MonoBehaviour
{
    [SerializeField] private int numberMax = 100;
    // Start is called before the first frame update
    void Start()
    {
        /*for (int count = 0; count <= 100; count++)
        {
            int total = count % 2;

            if (total == 0)
            {
                Debug.Log(count);
            }
            
            if (count == 50)
            {
                Debug.Log("Ja ets a la meitat!");
            }
            
        }*/

        /*int count = 0;
        do
        {
            int total = count % 2;

            if (total == 0)
            {
                Debug.Log(count);
            }
            
            if (count == 50)
            {
                Debug.Log("Ja ets a la meitat!");
            }
            
            count++;
        } while (count <= 100);*/

        int count = 0;
        while (count <= 100)
        {
            int total = count % 2;

            if (total == 0)
            {
                Debug.Log(count);
            }
            
            if (count == 50)
            {
                Debug.Log("Ja ets a la meitat!");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
