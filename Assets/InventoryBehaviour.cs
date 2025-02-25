using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class InventoryBehaviour : MonoBehaviour
{
    public bool isHandFull;
    public object itemInHand;

    public InventoryObject[] Inventory = new InventoryObject[14];

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(Inventory[1].Amount);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) == true && !isHandFull)
        {
            {
                //itemInHand = ;
            }
        }
    }
}
