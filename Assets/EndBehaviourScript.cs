using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.ShaderGraph;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndBehaviourScript : MonoBehaviour
{
    public List<GameObject> TMPElems = new List<GameObject>();
    public TMP_Text invAmount; //Inventory amount
    public TMP_Text itemAmount; //Diamond amount

    // Start is called before the first frame update
    void Start()
    {
        if (GameBehaviour.freeInvSquares <= 0)
        {
            itemAmount.text = "With this, you were able to bring home literally nothing! Wow! How did you even manage that?";
        }
        else if (GameBehaviour.freeInvSquares == 1)
        {
            itemAmount.text = $"With this, you were able to bring home one whole diamond! Wow!";
        }
        else
        {
            itemAmount.text = $"With this, you were able to bring home a whole {GameBehaviour.freeInvSquares} cobblestone! Wow!";
        }
        invAmount.text = GameBehaviour.freeInvSquares.ToString();
        TransparentElements();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void TransparentElements()
    {
        foreach (GameObject element in TMPElems)
        {
            TMP_Text currentTMP = element.GetComponent<TMP_Text>();
            currentTMP.faceColor = new Color32(255, 255, 255, 0); // R, G, B, A
        }
        StartCoroutine(DisplayElements());
        StartCoroutine(WaitToSwitchScenes());
    }

    IEnumerator DisplayElements()
    {
        foreach (GameObject element in TMPElems)
        {
            TMP_Text currentTMP = element.GetComponent<TMP_Text>();
            for (int i = 0; i < 255; i += 3)
            {
                //currentTMP.faceColor = new Color32(255, 255, 255, (byte)(i)); //R, G, B, A
                element.GetComponent<TMP_Text>().faceColor = new Color32(255, 255, 255, (byte)(i)); //R, G, B, A
                Debug.Log(i);
                yield return new WaitForSeconds(0.03f);
            }
        }
    }

    IEnumerator WaitToSwitchScenes()
    {
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Return));
        SceneManager.LoadScene("SampleScene");
    }
}
