using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class InventoryGeneration : MonoBehaviour
{
    public InventoryObject[] invItems = new InventoryObject[14]; //Length should be 14 as that's the length of inventory
    public Canvas canvas;
    public CraftingRecipesScript craftScript;

    public static InventoryObject wood;
    public static InventoryObject sticks;
    public static InventoryObject coal;

    private Sprite tempSpr;
    public bool generationComplete = false;

    // Start is called before the first frame update
    void Start()
    {
        InventoryObject[] possibleItems = new InventoryObject[craftScript.componentDictionary.Count()];

        int position = 0;
        foreach (KeyValuePair<string, InventoryObject> item in craftScript.componentDictionary)
        {
            possibleItems[position] = item.Value;
            position++;
        }

        //CREATE OBJECTS FOR USE IN INV
        for (int i = 0; i < 14; i++)
        {
            //System.Random random = new System.Random();
            int genTrue = Random.Range(0, 5);
            Debug.Log("GEN TRUE = " + genTrue);
            if (genTrue < 5) //CHANGE
            {
                InventoryObject tempInvObj;
                tempInvObj = possibleItems[Random.Range(4, possibleItems.Length)];
                invItems[i] = tempInvObj;
            }
            else
            {
                InventoryObject tempInvObj = null;
                invItems[i] = tempInvObj;
                //There's only a 1/5 chance an item will generate in the inventory for now (may change later, playtest first)
            }
        }
        generationComplete = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
