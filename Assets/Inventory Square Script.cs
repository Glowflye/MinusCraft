using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySquareScript : MonoBehaviour
{
    public InventoryGeneration invGenScript;
    public int inventoryPosition; //Declare in unity editor, 1 through 14
    public InventoryBehaviour inventoryScript;

    public Image invImage;
    private InventoryObject invObj;

    // Start is called before the first frame update
    void Start()
    {
        invObj = invGenScript.invItems[inventoryPosition];
        invImage = GetComponent<Image>();
        if (invObj == null)
        {
            invImage.enabled = false;
        }
        else
        {
            invImage.sprite = invObj.Image;
        }
        inventoryScript.Inventory[inventoryPosition] = invObj;
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (invObj != null) //Change so doesn't update every frame
            {
                inventoryScript.Inventory[inventoryPosition] = invObj;
                Debug.Log(invObj.Amount);
            }
        }
    }
}
