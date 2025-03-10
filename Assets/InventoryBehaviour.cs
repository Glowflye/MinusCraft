using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class InventoryBehaviour : MonoBehaviour
{
    public bool isHandFull;
    public object itemInHand;

    public InventoryGeneration invGenScript;
    public CraftingRecipesScript craftRecipesScript;
    public InventoryBehaviour invBehaviour;
    public CraftingOutputSquareScript craftOutputSquareScript;

    public bool canCraft = false;

    public InventoryObject completeRecipe;

    public InventoryObject[] Inventory = { null, null, null, null, null, null, null, null, null, null, null, null, null, null };
    public InventoryObject[] CraftInventory = { null, null, null, null, null, null, null, null, null };

    public InventoryGeneration invGen;

    // Start is called before the first frame update
    void Start()
    {
        //
    }

    //Update is called once per frame
    void Update()
    {
        if (craftOutputSquareScript.outputObj == null)
        {
            foreach (KeyValuePair<string, InventoryObject[]> item in craftRecipesScript.craftingRecipes) //Null?
            {
                bool isEqual = Enumerable.SequenceEqual(item.Value, CraftInventory);
                if (isEqual == true)
                {
                    string craftableName = item.Key;
                    Debug.Log(item.Key);
                    completeRecipe = craftRecipesScript.componentDictionary[craftableName];
                    canCraft = true;
                    break;
                }
                else
                {
                    canCraft = false;
                    completeRecipe = null;
                }
            }
        }
    }
}

