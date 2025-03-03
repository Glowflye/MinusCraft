using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehaviour : MonoBehaviour
{
    public AudioClip gameMusic;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource.PlayClipAtPoint(gameMusic, new Vector3(0, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
