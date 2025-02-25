using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class InventoryGeneration : MonoBehaviour
{
    public InventoryObject[] invItems; //Length should be 14 as that's the length of inventory
    public Canvas canvas;
    private InventoryObject[] possibleItems;

    public Image tempImg;

    private Image[] inventoryImages;
    private string[] inventoryNames = {"stick", "coal", "torch"}; //Add unique items later
    private int[] inventoryValue = { 1, 1, 2 };

    System.Random random = new System.Random();

    // Start is called before the first frame update
    void Start()
    {

        //ADD TO INV IMAGES
        for (int i = 0; i < 4; i++)
        {
            inventoryImages.Append(tempImg);
        }


        //CREATE OBJECTS FROM EACH ITEM IN NAMES
        for (int i = 0; i < inventoryImages.Length - 1; i++) //Name, Image, Value, Amount
        {
            //int amount = random.Next(1, 32); //Not all objects can stack to 32 so change later --> move later
            InventoryObject invObj = new InventoryObject(inventoryNames[i], inventoryImages[i], inventoryValue[i], 0); //0 should be set to value later
            Debug.Log(i);
            possibleItems.Append(invObj);
        }

        //CREATE OBJECTS FOR USE IN INV
        for (int i = 0; i < 14; i++)
        {
            int genTrue = random.Next(0, 4);
            if (genTrue == 0)
            {
                InventoryObject tempInvObj = possibleItems[random.Next(0, possibleItems.Length)]; //May need to change to Length - 1 later
                tempInvObj.Amount = random.Next(1, 32); //Amount of inventory item generated here
                invItems[i] = tempInvObj;
            }
            else
            {
                InventoryObject tempInvObj = null;
                invItems[i] = tempInvObj;
                //There's only a 1/5 chance an item will generate in the inventory for now (may change later, playtest first)
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
