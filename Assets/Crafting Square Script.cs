using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CraftingSquareScript : MonoBehaviour, IPointerDownHandler
{
    private InventoryObject craftObj;
    public Image craftImage;
    public int craftPosition;

    public InventoryBehaviour inventoryScript;
    public MouseBehaviourScript mouseBehaviourScript;
    public CraftingOutputSquareScript craftOutputSquareScript;

    public AudioClip popSound;

    // Start is called before the first frame update
    void Start()
    {
        craftImage.sprite = Resources.Load<Sprite>("[TEMP] Transparent");
    }

    // Update is called once per frame
    void Update()
    { 
        if (craftOutputSquareScript.clearCraftTable == true)
        {
            craftObj = null;
        }
        if (craftObj == null) //Change so doesn't update every frame
        {
            craftImage.sprite = Resources.Load<Sprite>("[TEMP] Transparent");
            //inventoryScript.CraftInventory[craftPosition] = null;
        }
        else
        {
            craftImage.enabled = true;
            //inventoryScript.CraftInventory[craftPosition] = craftObj;
            craftImage.sprite = craftObj.Image;
            //Debug.Log(invObj.Amount);
            //Debug.Log("WHAT");
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (mouseBehaviourScript.pickedUpObject == null)
        {
            if (craftObj != null)
            {
                mouseBehaviourScript.pickedUpObject = craftObj; //Need to update inv list
                craftObj = null;
                inventoryScript.CraftInventory[craftPosition] = null;
                Debug.Log(craftObj);
                Debug.Log("this is empty");
                AudioSource.PlayClipAtPoint(popSound, new Vector3(0, 0, 0));
            }
            //Else do nothing
        }
        else if (mouseBehaviourScript.pickedUpObject != null)
        {
            if (craftObj == null)
            {
                //mouseBehaviourScript.checkDropPlace = inventoryPosition;
                craftObj = mouseBehaviourScript.pickedUpObject;
                inventoryScript.CraftInventory[craftPosition] = craftObj;
                mouseBehaviourScript.pickedUpObject = null;
                AudioSource.PlayClipAtPoint(popSound, new Vector3(0, 0, 0));
            }
            //Else do nothing
        }
    }
}
