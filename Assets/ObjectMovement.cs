using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ObjectMovement : MonoBehaviour
{

    [SerializeField] private GameObject objecte;
    [SerializeField] private int valorX;
    [SerializeField] private int valorY;
    [SerializeField] private int valorZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           objecte.transform.position = GetPosition(valorX, valorY, valorZ);
        }
        
    }

    public Vector3 GetPosition(float x, float y, float z)
    {
        return new Vector3(x, y, z);
    }
    
}
