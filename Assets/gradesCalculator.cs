using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gradesCalculator : MonoBehaviour

{

    [SerializeField] private float grade1;
    [SerializeField] private float grade2;
    [SerializeField] private float grade3;
    [SerializeField] private float grade4;
    [SerializeField] private float grade5;
    [SerializeField] private float total;
    
    // Start is called before the first frame update
    void Start()
    {
        grade1 = Random.Range(0f, 10f);
        grade2 = Random.Range(0f, 10f);
        grade3 = Random.Range(0f, 10f);
        grade4 = Random.Range(0f, 10f);
        grade5 = Random.Range(0f, 10f);
        total = (grade1 + grade2 + grade3 + grade4 + grade5) / 5;
        Debug.Log("Average : " + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
