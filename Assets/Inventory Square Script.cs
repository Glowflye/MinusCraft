using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

public class InventorySquareScript : MonoBehaviour, IPointerDownHandler
{
    public InventoryGeneration invGenScript;
    public int inventoryPosition; //Declare in unity editor, 1 through 14
    public InventoryBehaviour inventoryScript;

    public MouseBehaviourScript mouseBehaviourScript;

    public Image invImage;
    private InventoryObject invObj;

    public bool dropPlaceEmpty;

    public AudioClip popSound;

    // Start is called before the first frame update
    void Start()
    {
        invObj = invGenScript.invItems[inventoryPosition];
        invImage = GetComponent<Image>();

        if (invObj == null)
        {
            invImage.sprite = Resources.Load<Sprite>("[TEMP] Transparent");
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
            if (invObj == null) //Change so doesn't update every frame
            {
                invImage.sprite = Resources.Load<Sprite>("[TEMP] Transparent");
                inventoryScript.Inventory[inventoryPosition] = null;
            }
            else
            {
                invImage.enabled = true;
                inventoryScript.Inventory[inventoryPosition] = invObj;
                invImage.sprite = invObj.Image;
            }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("HIIII");
        if (mouseBehaviourScript.pickedUpObject == null)
        {
            if (invObj != null)
            {
                mouseBehaviourScript.pickedUpObject = invObj; //Need to update inv list
                invObj = null;
                Debug.Log(invObj);
                //Debug.Log("this is empty");
                AudioSource.PlayClipAtPoint(popSound, new Vector3(0, 0, 0));
            }
            //Else do nothing
        }
        else if (mouseBehaviourScript.pickedUpObject != null)
        {
            if (invObj == null)
            {
                invObj = mouseBehaviourScript.pickedUpObject;
                mouseBehaviourScript.pickedUpObject = null;
                AudioSource.PlayClipAtPoint(popSound, new Vector3(0, 0, 0));
            }
            //Else do nothing
        }
    }
}
