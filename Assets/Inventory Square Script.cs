using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySquareScript : MonoBehaviour
{
    public InventoryGeneration invGenScript;
    public int inventoryPosition; //Declare in unity editor, 1 through 14

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
    }

    // Update is called once per frame
    void Update()
    {
        {
            
        }
    }
}
