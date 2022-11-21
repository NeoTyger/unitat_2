using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedRegulator : MonoBehaviour
{

    [SerializeField] private int speed = 1;
    [SerializeField] private bool hasSaidMessage1 = false;
    [SerializeField] private bool hasSaidMessage2 = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            speed++;
        }
        
        if (speed > 20 && (hasSaidMessage1 == false))
        {
            hasSaidMessage1 = true;
            Debug.Log("Slow Down");
        }

        if (speed <= 20 && (hasSaidMessage1 == true))
        {
            hasSaidMessage1 = false;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            speed--;
        }
        
        if (speed == 0  && (hasSaidMessage2 == false))
        {
            hasSaidMessage2 = true;
            Debug.Log("Speed Up");
        }
        
        if (speed >0 && (hasSaidMessage2 == true))
        {
            hasSaidMessage2 = false;
        }
    }
}
