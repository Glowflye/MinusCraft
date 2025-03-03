using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameBehaviour : MonoBehaviour
{
    public AudioClip gameMusic;
    public static int freeInvSquares;

    public InventoryBehaviour invBehaviourScript;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource.PlayClipAtPoint(gameMusic, new Vector3(0, 0, 0));
        StartCoroutine(WaitToSwitchScenes());
    }

    // Update is called once per frame
    void Update()
    {
        freeInvSquares = 0;
        foreach (InventoryObject item in invBehaviourScript.Inventory)
        {
            if (item == null)
            {
                freeInvSquares++;
            }
        }
        foreach (InventoryObject item in invBehaviourScript.CraftInventory)
        {
            if (item != null)
            {
                freeInvSquares--;
            }
        }
        if (invBehaviourScript.itemInHand != null)
        {
            freeInvSquares--;
        }
    }

    IEnumerator WaitToSwitchScenes()
    {
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        SceneManager.LoadScene("FinalEndScene");
    }
}
