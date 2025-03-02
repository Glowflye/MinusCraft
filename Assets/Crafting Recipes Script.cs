using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingRecipesScript : MonoBehaviour
{
    //ALL Crafting Recipes

    //COMPONENT OBJECTS
    public InventoryObject wood;
    public InventoryObject sticks;
    public InventoryObject coal;
    public InventoryObject torch;

    //RECIPE DICTIONARY
    public Dictionary<string, InventoryObject[]> craftingRecipes = new Dictionary<string, InventoryObject[]>()
    {
        //{ "sticks", new InventoryObject[] { null, wood, null, null, wood, null, null, wood, null} }, //Stick crafting recipe
        //{ "wood", new InventoryObject[] { sticks, sticks, null, sticks, sticks, null, null, null, null} }, //Wood crafting recipe
        //{ "torch", new InventoryObject[] { coal, null, null, sticks, null, null, null, null, null } }
    };

    //CRAFT AMOUNT DICTIONARY
    //public Dictionary<string, int> craftingRecipeCraftAmount = new Dictionary<string, int>() //Might not need
    //{
    //    { "sticks", 6 },
    //    { "wood", 4 },
    //    { "torch", 6 }
    //};

    //COMPONENT DICTIONARY
    public Dictionary<string, InventoryObject> componentDictionary = new Dictionary<string, InventoryObject>();

    // Start is called before the first frame update
    void Start()
    {
        //DEFINE COMPONENT OBJECTS
        wood = new InventoryObject("wood", Resources.Load<Sprite>("Wood"), 1, 4);
        sticks = new InventoryObject("sticks", Resources.Load<Sprite>("Stick"), 1, 3);
        coal = new InventoryObject("coal", Resources.Load<Sprite>("Coal"), 1, 3);
        torch = new InventoryObject("torch", Resources.Load<Sprite>("Torch"), 1, 1);
            
        //ADD COMPONENT OBJECTS TO COMPONENT DICTIONARY
        componentDictionary.Add("wood", wood);
        componentDictionary.Add("sticks", sticks);
        componentDictionary.Add("coal", coal);
        componentDictionary.Add("torch", torch);

        //ADD ITEMS TO RECIPE DICTIONARY
        craftingRecipes.Add("sticks", new InventoryObject[] { null, wood, null, null, wood, null, null, wood, null } );
        craftingRecipes.Add("wood", new InventoryObject[] { sticks, sticks, null, sticks, sticks, null, null, null, null });
        craftingRecipes.Add("torch", new InventoryObject[] { coal, null, null, sticks, null, null, null, null, null });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
