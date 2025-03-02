using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryObject
{
    private string name;
    private Sprite image;
    private int value; //Rarity or importance of the item - dropping high value items is BAD
    private int amount; //How many of each item are in the stack

    public InventoryObject(string Name, Sprite Image, int Value, int Amount)
    {
        name = Name;
        image = Image;
        value = Value;
        amount = Amount;

    }

    public int Amount
    {
        get { return amount; }
        set { amount = value; }
    }

    public Sprite Image
    {
        get { return image; }
        set { image = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}
