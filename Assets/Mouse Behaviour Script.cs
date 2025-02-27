using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseBehaviourScript : MonoBehaviour
{
    public bool mouseFull = false;

    public InventoryObject pickedUpObject;

    public int checkDropPlace;
    public bool drop = false;

    public InventoryGeneration invGen;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0) == true)
        //{
        //    int currentDropPlace = 0;
        //    checkDropPlace = 0;
        //    Debug.Log("DDDDDDDDDD");
        //    if (pickedUpObject != null)
        //    {
        //        mouseFull = false;
        //        while (currentDropPlace == checkDropPlace)
        //        {

        //        }
        //        if (checkDropPlace <= 14 && checkDropPlace >= 0) //CHANGE
        //        {
        //            pickedUpObject = null;
        //        }
        //    }
        //    else
        //    {
        //        mouseFull = true;
        //        pickedUpObject = invGen.invItems[checkDropPlace];
        //    }
        //}
    }

    //public void OnPointerClick(PointerEventData eventData)
    //{
        
    //}
}
