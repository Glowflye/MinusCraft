using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using static UnityEditor.PlayerSettings;

public class MouseBehaviourScript : MonoBehaviour
{
    public bool mouseFull = false;
    private InventoryObject mouseFollowObj;
    public Image mouseImg;

    public InventoryObject pickedUpObject;
    public int? pickedUpObjectInitAmount;

    public int checkDropPlace;
    public bool drop = false;

    public InventoryGeneration invGen;

    void Update()
    {
        if (pickedUpObject != null)
        {
            if (pickedUpObjectInitAmount == null)
            {
                pickedUpObjectInitAmount = pickedUpObject.Amount;
            }
            else if (pickedUpObject.Amount == 0)
            {
                pickedUpObjectInitAmount = null;
            }
        }
    }
}
