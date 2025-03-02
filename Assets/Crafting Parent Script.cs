using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingParentScript : MonoBehaviour
{
    public CraftingOutputSquareScript craftOutputScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (craftOutputScript.clearCraftTable == true)
        //{
        //    foreach (Transform child in transform)
        //    {
        //        child.gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("[TEMP] Transparent");
        //    }
        //    craftOutputScript.clearCraftTable = false;
        //}
    }
}
