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

    private InventoryObject outputObj;

    // Start is called before the first frame update
    void Start()
    {
        tempImg = Resources.Load<Sprite>("[TEMP] Transparent");
    }

    // Update is called once per frame
    void Update()
    {
        if (invBehaviour.canCraft == true)
        {
            Debug.Log("YESSIR");
            outputObj = invBehaviour.completeRecipe;
            outputImg.sprite = outputObj.Image;
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
                if (outputObj != null)
                {
                    mouseBehaviourScript.pickedUpObject = outputObj; //Need to update inv list
                    outputObj = null;
                    for (int i = 0; i < 9; i++)
                    {
                        invBehaviour.CraftInventory[i] = null;
                    }
                    clearCraftTable = true;
                    StartCoroutine(WaitForCraftToClear());
                }
                //Else do nothing
            }
        }
    }

    IEnumerator WaitForCraftToClear()
    {
        yield return new WaitForSeconds(1);
        clearCraftTable = false;
    }
}
