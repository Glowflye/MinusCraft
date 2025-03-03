using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.UI;

public class MouseFollowScript : MonoBehaviour
{
    public MouseBehaviourScript mouseBevScript;
    public SpriteRenderer mouseRend;

    Vector3 position;

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        if (mouseBevScript.pickedUpObject != null)
        {
            Vector3 currPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseRend.sprite = mouseBevScript.pickedUpObject.Image;
            position.z = 10;
            transform.position = position;
        }
        else
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseRend.sprite = Resources.Load<Sprite>("TEMP");
        }
    }
}
