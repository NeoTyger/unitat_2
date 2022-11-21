using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberColors : MonoBehaviour
{
    
    [SerializeField] private GameObject cube;
    [SerializeField] private int color = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            color = 1;
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            color = 2;
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            color = 3;
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            color = 4;
        }
        
        switch (color)
        {
            case 1:
                cube.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case 2:
                cube.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 3:
                cube.GetComponent<Renderer>().material.color = Color.green;
                break;
            case 4:
                cube.GetComponent<Renderer>().material.color = Color.black;
                break;
        }*/

        string tecla = Input.inputString;
        switch (tecla)
        {
            case "1":
                cube.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case "2":
                cube.GetComponent<Renderer>().material.color = Color.red;
                break;
            case "3":
                cube.GetComponent<Renderer>().material.color = Color.green;
                break;
            case "4":
                cube.GetComponent<Renderer>().material.color = Color.black;
                break;
        }
    }
}
