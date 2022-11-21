using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverPermission : MonoBehaviour
{

    [SerializeField] private int age;
    
    
    // Start is called before the first frame update
    void Start()
    {
        if (age >= 18)
        {
            Debug.Log("Edat : " + age + " || Permis : Acceptat");
        }
        else
        {
            Debug.Log("Edat : " + age + " || Permis : No acceptat");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
