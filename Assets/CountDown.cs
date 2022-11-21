using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    
    [SerializeField] private int totalCount = 10;
    // Start is called before the first frame update
    void Start()
    {
        for (int count = totalCount; count >= 0; count--)
        {
            Debug.Log(count);
            
            if (count == 0)
            {
                Debug.Log("RUN!");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
