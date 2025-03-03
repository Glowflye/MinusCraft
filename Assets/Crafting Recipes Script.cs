using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingRecipesScript : MonoBehaviour
{
    //ALL Crafting Recipes

    //COMPONENT OBJECTS --> change to be static later
    public static InventoryObject wood;
    public static InventoryObject sticks;
    public static InventoryObject coal;
    public static InventoryObject torch;
    public static InventoryObject glass;
    public static InventoryObject fallenStar;
    public static InventoryObject morningStar;
    public static InventoryObject paper;
    public static InventoryObject writtenPaper;
    public static InventoryObject woodenPickaxe;
    public static InventoryObject hammer;

    //RECIPE DICTIONARY
    public Dictionary<string, InventoryObject[]> craftingRecipes = new Dictionary<string, InventoryObject[]>();

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
        glass = new InventoryObject("glass", Resources.Load<Sprite>("Glass"), 1, 4);
        fallenStar = new InventoryObject("fallenStar", Resources.Load<Sprite>("FallenStar"), 1, 1);
        morningStar = new InventoryObject("morningStar", Resources.Load<Sprite>("MorningStar"), 1, 1);
        paper = new InventoryObject("paper", Resources.Load<Sprite>("Paper"), 1, 1);
        writtenPaper = new InventoryObject("writtenPaper", Resources.Load<Sprite>("WrittenPaper"), 1, 1);
        woodenPickaxe = new InventoryObject("woodenPickaxe", Resources.Load<Sprite>("WoodenPickaxe"), 1, 1);
        hammer = new InventoryObject("hammer", Resources.Load<Sprite>("Hammer"), 1, 1);

        //ADD COMPONENT OBJECTS TO COMPONENT DICTIONARY
        componentDictionary.Add("torch", torch);
        componentDictionary.Add("morningStar", morningStar);
        componentDictionary.Add("writtenPaper", writtenPaper);
        componentDictionary.Add("woodenPickaxe", woodenPickaxe);
        componentDictionary.Add("hammer", hammer);

        //DON'T GENERATE ITEMS ABOVE (start generating inventory from this position)
        componentDictionary.Add("sticks", sticks);
        componentDictionary.Add("wood", wood);
        componentDictionary.Add("fallenStar", fallenStar);
        componentDictionary.Add("paper", paper);
        componentDictionary.Add("glass", glass);
        componentDictionary.Add("coal", coal);

        //ADD ITEMS TO RECIPE DICTIONARY --> only add items that have a crafting recipe
        craftingRecipes.Add("sticks", new InventoryObject[] { null, wood, null, null, wood, null, null, wood, null });
        craftingRecipes.Add("wood", new InventoryObject[] { sticks, sticks, null, sticks, sticks, null, null, null, null });
        craftingRecipes.Add("torch", new InventoryObject[] { coal, null, null, sticks, null, null, null, null, null });
        craftingRecipes.Add("morningStar", new InventoryObject[] { fallenStar, glass, null, glass, sticks, null, null, null, sticks });
        craftingRecipes.Add("writtenPaper", new InventoryObject[] { paper, coal, null, null, null, null, null, null, null } );
        craftingRecipes.Add("woodenPickaxe", new InventoryObject[] { wood, wood, wood, null, sticks, null, null, sticks, null });
        craftingRecipes.Add("hammer", new InventoryObject[] { wood, null, null, null, sticks, null, null, null, sticks });
    }
}
