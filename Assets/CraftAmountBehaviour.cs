using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CraftAmountBehaviour : MonoBehaviour
{
    public TMP_Text thisText;
    public CraftingOutputSquareScript craftOutputScript;

    // Start is called before the first frame update
    void Start()
    {
        thisText.text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        if (craftOutputScript.outputObj != null)
        {
            thisText.text = craftOutputScript.outputObj.Amount.ToString();
        }
        else
        {
            thisText.text = string.Empty;
        }
    }
}
