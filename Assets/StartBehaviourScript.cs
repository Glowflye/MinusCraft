using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.Rendering.DebugUI.Table;
using static UnityEngine.Rendering.DebugUI;

public class StartBehaviourScript : MonoBehaviour
{
    public List<GameObject> TMPElems = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        TransparentElements();
    }

    void TransparentElements()
    {
        foreach (GameObject element in TMPElems)
        {
            TMP_Text currentTMP = element.GetComponent<TMP_Text>();
            currentTMP.faceColor = new Color32(255, 255, 255, 0); // R, G, B, A
        }
        StartCoroutine(DisplayElements());
    }

    IEnumerator DisplayElements()
    {
        foreach (GameObject element in TMPElems)
        {
            TMP_Text currentTMP = element.GetComponent<TMP_Text>();
            for (int i = 0; i < 255; i += 3)
            {
                element.GetComponent<TMP_Text>().faceColor = new Color32(255, 255, 255, (byte)(i)); // R, G, B, A
                Debug.Log(i);
                yield return new WaitForSeconds(0.03f);
            }
        }
        yield return new WaitForSeconds(3);
        for (int i = 0; i < 256; i += 5)
        {
            int decrease = 255;
            foreach (GameObject element in TMPElems)
            {
                element.GetComponent<TMP_Text>().faceColor = new Color32(255, 255, 255, (byte)(decrease - i)); // R, G, B, A
                yield return new WaitForSeconds(0.015f);
            }
        }
        yield return new WaitForSeconds(30);
        SceneManager.LoadScene("SampleScene");
    }
}
