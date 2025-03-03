using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CraftingOutputSquareScript : MonoBehaviour, IPointerDownHandler
{
    public InventoryBehaviour invBehaviour;
    public CraftingRecipesScript craftScript;
    public MouseBehaviourScript mouseBehaviourScript;

    public Image outputImg;
    public bool clearCraftTable = false;

    private Sprite tempImg;

    public InventoryObject outputObj;

    private int? loggedAmount = -500;
    public AudioClip popSound;

    // Start is called before the first frame update
    void Start()
    {
        tempImg = Resources.Load<Sprite>("[TEMP] Transparent");
    }

    // Update is called once per frame
    void Update()
    {
        if (outputObj != null)
        {
            if (outputObj.Amount == 0)
            {
                //invBehaviour.canCraft = false;
                //outputObj = null;
            }
        }
        if (invBehaviour.canCraft == true && outputObj == null)
        {
            outputObj = invBehaviour.completeRecipe;
            outputImg.sprite = outputObj.Image;
        }
        else if (invBehaviour.canCraft == true && outputObj != null)
        {
            //Do nothing
        }
        else
        {
            outputObj = null;
            outputImg.sprite = tempImg;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (invBehaviour.canCraft == true)
        {
            if (mouseBehaviourScript.pickedUpObject == null)
            {
                if (outputObj != null && outputObj.Amount > 0)
                {
                    if (loggedAmount == -500)
                    {
                        loggedAmount = outputObj.Amount;
                        Debug.Log("LOGGED: " + loggedAmount);
                    }
                    mouseBehaviourScript.pickedUpObject = outputObj; //Need to update inv list
                    if (outputObj.Amount == loggedAmount)
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            invBehaviour.CraftInventory[i] = null;
                        }
                        clearCraftTable = true;
                    }
                    outputObj.Amount -= 1;
                    AudioSource.PlayClipAtPoint(popSound, transform.position);
                    StartCoroutine(WaitForCraftToClear());
                }
                if (outputObj.Amount <= 0)
                {
                    Debug.Log("NONE LEFT");
                    invBehaviour.canCraft = false;
                    outputObj.Amount = Convert.ToInt32(loggedAmount);
                    outputObj = null;
                    loggedAmount = -500;
                }
                //Else do nothing
            }
        }
        else
        {
            Debug.Log("DO");
            outputObj = null;
            outputImg.sprite = tempImg;
        }
    }

    IEnumerator WaitForCraftToClear()
    {
        yield return new WaitForSeconds(1);
        clearCraftTable = false;
    }
}
