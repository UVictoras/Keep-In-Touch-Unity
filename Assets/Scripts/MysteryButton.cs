using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MysteryButton : MonoBehaviour
{
    private KeyCode[] possibleKeys = {KeyCode.E, KeyCode.Y, KeyCode.L, KeyCode.W};
    public Sprite turnedOn, turnedOff;
    private int keyChoice;
    private bool state = true;
    public GameObject qte;
    public bool activated = false;
    private void Start()
    {
        keyChoice = Random.Range(0,4);
    }

    private void Update()
    {
        if (Input.GetKey(possibleKeys[keyChoice]) && activated)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = turnedOff;
            qte.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0f);
            state = false;
        }
        else if (activated == false)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = turnedOff;
            qte.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0f);
            state = false;
        }
    }
}
