using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class InventoryGeneration : MonoBehaviour
{
    public InventoryObject[] invItems = new InventoryObject[14]; //Length should be 14 as that's the length of inventory
    public Canvas canvas;
    public InventoryObject[] possibleItems = new InventoryObject[14];

    //public Sprite tempImg;

    private Sprite[] inventoryImages;
    private string[] inventoryNames = { "stick", "coal", "torch" }; //Add unique items later
    private int[] inventoryValue = { 1, 1, 2 };

    private Sprite tempSpr;
    public bool generationComplete = false;
    //private Dictionary<string, InventoryObject> InventoryItems = new Dictionary<string, InventoryObject>
    //{
    //    { "stick",  }
    //};

     

    // Start is called before the first frame update
    void Start()
    {
        //ADD TO INV IMAGES
        //for (int i = 0; i < 4; i++)
        //{
        //    tempSpr = Resources.Load<Sprite>("TEMP");
        //    inventoryImages.Append(tempSpr);
        //}


        //CREATE OBJECTS FROM EACH ITEM IN NAMES
        for (int i = 0; i < inventoryNames.Length; i++) //Name, Image, Value, Amount
        {
            //int amount = random.Next(1, 32); //Not all objects can stack to 32 so change later --> move later
            InventoryObject invObj = new InventoryObject(inventoryNames[i], Resources.Load<Sprite>("TEMP"), inventoryValue[i], 0); //0 should be set to value later
            Debug.Log(invObj.Amount);
            possibleItems[i] = invObj; //PROBLEM
            Debug.Log(possibleItems[i].Amount);
        }
        

        //CREATE OBJECTS FOR USE IN INV
        for (int i = 0; i < 14; i++)
        {
            System.Random random = new System.Random();
            int genTrue = random.Next(0, 4);
            if (genTrue < 4) //CHANGE
            {
                InventoryObject tempInvObj = new InventoryObject ( string.Empty, null, 0, 0 );
                Debug.Log(possibleItems[0]); //FIX
                tempInvObj = possibleItems[0];//[random.Next(0);//0, possibleItems.Length - 1)]; //May need to change to Length - 1 later
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
        generationComplete = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
