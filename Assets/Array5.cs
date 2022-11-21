using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Array5 : MonoBehaviour
{

    [SerializeField] private string[] names;
    [SerializeField] private int[] ages;
    [SerializeField] private string[] cars;
    
    // Start is called before the first frame update
    void Start()
    {
        
        foreach (string name in names)
        {

            if (name == "Barry")
            {
                Debug.Log(name);
            }
        }
        
        
        
        /*foreach (string name in names)
        {
            Debug.Log(name);
        }
        
        foreach (int age in ages)
        {
            Debug.Log(age);
        }
        
        foreach (string car in cars)
        {
            Debug.Log(car);
        }*/
        
        /*int number = Random.Range(0, names.Length);

        Debug.Log(names[number]);
        Debug.Log(ages[number]);
        Debug.Log(cars[number]);*/

        //Debug.Log(names[4]);
        //Debug.Log(ages[4]);
        //Debug.Log(cars[cars.Length-1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
