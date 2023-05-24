using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ColorGauge : MonoBehaviour
{
    public int id;
    public GameObject[] gaugeTier;
    public TextMeshProUGUI keyBind;
    private int useKey;
    private int currentTier = 1;
    private int keyPressedNb = 0;
    private void Start()
    {
        useKey = Random.Range(0,3);
    }

    private void Update()
    {
        if (currentTier <= 5)
        {
            if (useKey == 1) // Mash the key
            {
                if (Input.GetKeyUp(KeyCode.P) && id == 1)
                    keyPressedNb++;
                else if (Input.GetKeyUp(KeyCode.H) && id == 2)
                    keyPressedNb++;
                else if (Input.GetKeyUp(KeyCode.X) && id == 3)
                    keyPressedNb++;

                if (keyPressedNb == 5)
                {
                    keyPressedNb = 0;
                    gaugeTier[currentTier-1].GetComponent<TripleGauge>().Fill();
                    currentTier++;
                }
            }
            else if (useKey == 2) //Hold the key
            {
                if (Input.GetKeyDown(KeyCode.P) && id == 1)
                    keyPressedNb++;
                else if (Input.GetKeyDown(KeyCode.H) && id == 2)
                    keyPressedNb++;
                else if (Input.GetKeyDown(KeyCode.X) && id == 3)
                    keyPressedNb++;
                if (keyPressedNb == 5)
                {
                    keyPressedNb = 0;
                    gaugeTier[currentTier-1].GetComponent<TripleGauge>().Fill();
                    currentTier++;
                    StartCoroutine(Wait());
                }
            }
        }
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
    }
}
