using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliveOrDead : MonoBehaviour
{

    [SerializeField] private int lifePoints = 100;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Damage(lifePoints);
            IsDead();
        }
    }

    public int Damage(int damageAmount)
    {
        int damage = Random.Range(1, 50);
        
        damageAmount -= damage;
        
        Debug.Log(damageAmount);

        if (damageAmount <= 0)
        {
            Debug.Log("The player has died!");
        }

        return damageAmount;
    }

    public void IsDead()
    {
        if (lifePoints < 0)
        {
            Debug.Log("NEGATIVE LIFE POINTS");
        }
    }
    
}
