using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingClouds : MonoBehaviour
{
    public float speed;

    [SerializeField]
    private Renderer cloudRend;

    // Update is called once per frame
    void Update()
    {
        cloudRend.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}
