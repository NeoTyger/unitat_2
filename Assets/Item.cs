using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Item : MonoBehaviour
{

    // Els valors s'inicialitzen des de l'inspector
    [SerializeField] private string itemName;
    [SerializeField] private string itemDescription;
    [SerializeField] private Sprite itemIcon;
    [SerializeField] private float attackStrenght;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Nom : " + itemName + " || Descripció : " + itemDescription + " || Icono : " + itemIcon + " || Força : " + attackStrenght);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
