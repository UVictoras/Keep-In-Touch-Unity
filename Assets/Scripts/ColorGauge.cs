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
                {
                    keyPressedNb++;
                }
                else if (Input.GetKeyUp(KeyCode.H) && id == 2)
                {
                    keyPressedNb++;
                }
                else if (Input.GetKeyUp(KeyCode.X) && id == 3)
                {
                    keyPressedNb++;
                }

                if (keyPressedNb == 5)
                {
                    if (currentTier > 1 && gaugeTier[currentTier-2].GetComponent<AudioSource>().isPlaying)
                        gaugeTier[currentTier-2].GetComponent<AudioSource>().Stop();
                    gaugeTier[currentTier-1].GetComponent<AudioSource>().Play();
                    keyPressedNb = 0;
                    gaugeTier[currentTier-1].GetComponent<TripleGauge>().Fill();
                    currentTier++;
                    if (currentTier == 6)
                        this.gameObject.GetComponent<AudioSource>().Play();
                }
            }
            else if (useKey == 2) //Hold the key
            {
                if (Input.GetKey(KeyCode.P) && id == 1)
                {
                    StartCoroutine(Wait());
                }
                else if (Input.GetKey(KeyCode.B) && id == 2)
                {
                    StartCoroutine(Wait());
                }
                else if (Input.GetKey(KeyCode.X) && id == 3)
                {
                    StartCoroutine(Wait());
                }

                if (Input.GetKeyUp(KeyCode.P) || Input.GetKeyUp(KeyCode.H) || Input.GetKeyUp(KeyCode.X))
                    StopCoroutine(Wait());
            }
        }
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
        if (Input.GetKey(KeyCode.P) && id == 1)
        {
            gaugeTier[currentTier-1].GetComponent<TripleGauge>().Fill();
            currentTier++;
        }
        else if (Input.GetKey(KeyCode.B) && id == 2)
        {
            gaugeTier[currentTier-1].GetComponent<TripleGauge>().Fill();
            currentTier++;
        }
        else if (Input.GetKey(KeyCode.X) && id == 3)
        {
            gaugeTier[currentTier-1].GetComponent<TripleGauge>().Fill();
            currentTier++;
        }
    }
}
