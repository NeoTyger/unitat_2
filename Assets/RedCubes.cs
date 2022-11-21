using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCubes : MonoBehaviour
{

    [SerializeField] private GameObject[] cubes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            /*foreach (GameObject cube in cubes)
            {
                cube.GetComponent<Renderer>().material.color = Color.red;
            }*/

            for (int i = 0; i < cubes.Length; i++)
            {
                cubes[i].GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }
}
