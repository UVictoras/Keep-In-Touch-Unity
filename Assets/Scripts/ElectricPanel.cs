using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ElectricPanel : MonoBehaviour
{
    public GameObject[] lockedPanel;
    public TextMeshProUGUI inputS, inputB, inputG;
    public GameObject alert;
    private bool blueWireOn = false, pinkWireOn = false, purpleWireOn = false;
    private int r;
    public bool activated = false;
    private void Update()
    {
        if (activated == true)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                for (int i = 0; i < 2; i++)
                {
                    lockedPanel[i].GetComponent<SpriteRenderer>().color = new Color(1,1,1, 1f);
                }
                this.gameObject.GetComponent<AudioSource>().Play();
                inputS.enabled = true;
                inputB.enabled = true;
                inputG.enabled = true;
                for (int j = 0; j < 3; j++)
                {
                    r = Random.Range(1,3);
                    if (r == 1)
                    {
                        if (j == 0)
                            blueWireOn = true;
                        else if (j == 1)
                            pinkWireOn = true;
                        else if (j == 2)
                            purpleWireOn = true;
                    }
                }
                if (blueWireOn == true)
                    lockedPanel[2].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f);
                else
                    lockedPanel[2].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f);

                if (pinkWireOn == true)
                    lockedPanel[6].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f);
                else
                    lockedPanel[9].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f);
                
                if (purpleWireOn == true)
                    lockedPanel[10].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f);
                else 
                    lockedPanel[13].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f);
            }

            if (Input.GetKeyUp(KeyCode.A))
            {
                foreach (GameObject el in lockedPanel)
                {
                    el.GetComponent<SpriteRenderer>().color = new Color(1,1,1, 0f);
                }
                this.gameObject.GetComponent<AudioSource>().Stop();
                inputS.enabled = false;
                inputB.enabled = false;
                inputG.enabled = false;
            }

            if (Input.GetKey(KeyCode.A) && Input.GetKeyUp(KeyCode.S) && blueWireOn == false)
            {
                lockedPanel[0].GetComponent<AudioSource>().Stop();
                lockedPanel[5].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0f);
                lockedPanel[2].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f);
                lockedPanel[0].GetComponent<AudioSource>().Play();
                blueWireOn = true;
            }

            if (Input.GetKey(KeyCode.A) && Input.GetKeyUp(KeyCode.G) && pinkWireOn == false)
            {
                lockedPanel[0].GetComponent<AudioSource>().Stop();
                lockedPanel[9].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0f);
                lockedPanel[6].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f);
                lockedPanel[0].GetComponent<AudioSource>().Play();
                pinkWireOn = true;
            }

            if (Input.GetKey(KeyCode.A) && Input.GetKeyUp(KeyCode.B) && purpleWireOn == false)
            {
                lockedPanel[0].GetComponent<AudioSource>().Stop();
                lockedPanel[13].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0f);
                lockedPanel[10].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f);
                lockedPanel[0].GetComponent<AudioSource>().Play();
                purpleWireOn = true;
            }
        }
        else
            alert.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0f);
    }
}
