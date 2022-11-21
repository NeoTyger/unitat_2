using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpacePoints : MonoBehaviour
{

    [SerializeField] private int points = 0;
    [SerializeField] private bool hasSaidMessage = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            points = points+10;
            Debug.Log("Puntuació : " + points);
        }

        if (points > 50&&(hasSaidMessage == false))
        {
            hasSaidMessage = true;
            Debug.Log("Ets genial!");
        }
    }
}
