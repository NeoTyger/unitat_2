using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifyColor : MonoBehaviour
{

    [SerializeField] private GameObject objecte;
    [SerializeField] private Color variableColor;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            variableColor = Color.green;
            ChangeColor(objecte,variableColor);
        }
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            variableColor = Color.red;
            ChangeColor(objecte,variableColor);
        }
    }

    public void ChangeColor(GameObject gObject, Color color)
    {
        gObject.GetComponent<Renderer>().material.color = color;
    }
}
