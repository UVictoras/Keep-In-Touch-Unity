using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricPanel : MonoBehaviour
{
    public GameObject[] lockedPanel;

    private bool blueWireOn = false, pinkWireOn = false, purpleWireOn = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            foreach (GameObject el in lockedPanel)
            {
                el.GetComponent<SpriteRenderer>().color = new Color(1,1,1, 1f);
            }
            this.gameObject.GetComponent<AudioSource>().Play();
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            foreach (GameObject el in lockedPanel)
            {
                el.GetComponent<SpriteRenderer>().color = new Color(1,1,1, 0f);
            }
            this.gameObject.GetComponent<AudioSource>().Stop();
        }
    }
}
