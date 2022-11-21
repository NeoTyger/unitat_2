using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapWeapon : MonoBehaviour
{

    [SerializeField] private int weapon;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            weapon = 1;
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            weapon = 2;
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            weapon = 3;
        }

        switch (weapon)
        {
            case 1:
                Debug.Log("GUN");
                break;
            case 2:
                Debug.Log("KNIFE");
                break;
            case 3:
                Debug.Log("MACHINE GUN");
                break;
        }*/

        string tecla = Input.inputString;
        switch (tecla)
        {
            case "1":
                Debug.Log("GUN");
                break;
            case "2":
                Debug.Log("KNIFE");
                break;
            case "3":
                Debug.Log("MACHINE GUN");
                break;
        }
    }
}
