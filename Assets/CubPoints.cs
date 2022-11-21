using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubPoints : MonoBehaviour
{
    
    [SerializeField] private int points = 0;
    [SerializeField] private GameObject cube;
    
    // Start is called before the first frame update
    void Start()
    {
        //Asi se elige el cubo sin usar el inspector --> cube = GameObject.Find("Cube"); (Tambien se podria hacer con Tags)
        cube.GetComponent<Renderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            points = points+10;
            Debug.Log("Puntuació : " + points);
        }

        if (points > 50)
        {
            cube.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
