using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelInformation : MonoBehaviour
{

    [SerializeField]private int level;

    // Start is called before the first frame update
    void Start()
    {
        level = Random.Range(0, 3);

        switch (level)
        {
            case 0:
                Debug.Log("Nivell fàcil");
                break;
            case 1:
                Debug.Log("Nivell mitjà");
                break;
            case 2:
                Debug.Log("Nivell difícil");
                break;
        }
        
        /*if (level == 0)
        { 
            Debug.Log("Nivell fàcil");
        } 
            
        if (level == 1) 
        { 
            Debug.Log("Nivell mitjà");
        }
            
        if (level == 2) 
        { 
            Debug.Log("Nivell difícil");
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            level = Random.Range(0, 3);
            
            switch (level)
            {
                case 0:
                    Debug.Log("Nivell fàcil");
                    break;
                case 1:
                    Debug.Log("Nivell mitjà");
                    break;
                case 2:
                    Debug.Log("Nivell difícil");
                    break;
            }
            
            /*if (level == 0)
            { 
                Debug.Log("Nivell fàcil");
            } 
            
            if (level == 1) 
            { 
                Debug.Log("Nivell mitjà");
            }
            
            if (level == 2) 
            { 
                Debug.Log("Nivell difícil");
            }*/
        }
        
        
    }
}
