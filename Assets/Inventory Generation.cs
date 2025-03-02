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
    public CraftingRecipesScript craftScript;

    //public Sprite tempImg;

    //private string[] inventoryImages = { "Stick", "Coal", "TEMP", "TEMP" };
    //private string[] inventoryNames = { "sticks", "coal", "torch", "wood" }; //Add unique items later
    //private int[] inventoryValue = { 1, 1, 2, 1 };

    public static InventoryObject wood;
    public static InventoryObject sticks;
    public static InventoryObject coal;

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
        //for (int i = 0; i < inventoryNames.Length; i++) //Name, Image, Value, Amount
        //{
        //    //int amount = random.Next(1, 32); //Not all objects can stack to 32 so change later --> move later
        //    InventoryObject invObj = new InventoryObject(inventoryNames[i], Resources.Load<Sprite>(inventoryImages[i]), inventoryValue[i], 0); //0 should be set to value later
        //    Debug.Log(invObj.Amount);
        //    possibleItems[i] = invObj; //PROBLEM
        //    Debug.Log(possibleItems[i].Amount);
        //}

        //List <InventoryObject> temp = new List<InventoryObject>();
        //wood = new InventoryObject("wood", Resources.Load<Sprite>("TEMP"), 1, 4);
        //temp.Add(wood);
        //sticks = new InventoryObject("sticks", Resources.Load<Sprite>("Stick"), 1, 6);
        //temp.Add(sticks);
        //coal = new InventoryObject("coal", Resources.Load<Sprite>("Coal"), 1, 6);
        //temp.Add(coal);
        
        possibleItems[0] = craftScript.wood;
        possibleItems[1] = craftScript.sticks;
        possibleItems[2] = craftScript.coal;


        //CREATE OBJECTS FOR USE IN INV
        for (int i = 0; i < 14; i++)
        {
            System.Random random = new System.Random();
            int genTrue = random.Next(0, 4);
            if (genTrue < 3) //CHANGE
            {
                InventoryObject tempInvObj = new InventoryObject ( string.Empty, null, 0, 0 );
                Debug.Log(possibleItems[0]); //FIX
                tempInvObj = possibleItems[random.Next(0, 3)];//[random.Next(0);//0, possibleItems.Length - 1)]; //May need to change to Length - 1 later
                //tempInvObj.Amount = random.Next(1, 32); //Amount of inventory item generated here
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
