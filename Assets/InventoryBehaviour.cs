using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class InventoryBehaviour : MonoBehaviour
{
    public bool isHandFull;
    public object itemInHand;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) == true && !isHandFull)
        {
            {
                //itemInHand = ;
            }
        }
    }
}
