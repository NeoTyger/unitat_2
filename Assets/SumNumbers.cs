using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumNumbers : MonoBehaviour
{

    [SerializeField] private int total1, total2;
    // Start is called before the first frame update
    void Start()
    {
        //Sum(5, 2);
        //Sum(9, 3);
        
        total1 = Sum(5, 2);
        total2 = Sum(9, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*void Sum(int a, int b)
    {
        Debug.Log(a + b);
    }*/

    int Sum(int a, int b)
    {
        return a + b;
    }

}
