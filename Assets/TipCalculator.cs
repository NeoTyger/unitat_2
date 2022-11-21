using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    
    [SerializeField] private float bill = 20.0f;
    private float tip;

    // Start is called before the first frame update
    void Start()
    {
        tip = bill * 0.2f;
        float totalAmount = bill + tip;
        Debug.Log("Total : " + totalAmount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
