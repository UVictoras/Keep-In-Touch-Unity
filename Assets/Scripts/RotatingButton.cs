using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RotatingButton : MonoBehaviour
{
    public GameObject duo, trio, alert;
    public TextMeshProUGUI[] inputs;
    private int inputsChoice, currentState = 1;
    private int nbTurn = 0;
    public bool activate = false;
    private void Start()
    {
        inputsChoice = Random.Range(1,3);

        if (inputsChoice == 1)
        {
            for (int i = 0; i < 3; i++)
                inputs[i].enabled = true;
        }
        else 
        {
            for (int j = 3; j < 6; j++)
                inputs[j].enabled = true;
        }
    }

    private void Update()
    {
        if (inputsChoice == 1 && nbTurn < 3 && activate == true)
        {
            if (Input.GetKeyUp(KeyCode.I) && currentState == 1)
            {
                duo.transform.rotation = Quaternion.Euler(Vector3.forward * (-120));
                trio.transform.rotation = Quaternion.Euler(Vector3.forward * (-120));
                currentState++;
                this.gameObject.GetComponent<AudioSource>().Play();
            }
            if (Input.GetKeyUp(KeyCode.J) && currentState == 2)
            {
                this.gameObject.GetComponent<AudioSource>().Stop();
                duo.transform.rotation = Quaternion.Euler(Vector3.forward * (-240));
                trio.transform.rotation = Quaternion.Euler(Vector3.forward * (-240));
                currentState++;
                this.gameObject.GetComponent<AudioSource>().Play();
            }
            if (Input.GetKeyUp(KeyCode.K) && currentState == 3)
            {
                this.gameObject.GetComponent<AudioSource>().Stop();
                duo.transform.rotation = Quaternion.Euler(Vector3.forward * 0);
                trio.transform.rotation = Quaternion.Euler(Vector3.forward * 0);
                currentState = 1;
                this.gameObject.GetComponent<AudioSource>().Play();
                nbTurn++;
            }
        }
        else if (inputsChoice == 2 && nbTurn < 3 && activate == true)
        {
            if (Input.GetKeyUp(KeyCode.F) && currentState == 1)
            {
                duo.transform.rotation = Quaternion.Euler(Vector3.forward * (-120));
                trio.transform.rotation = Quaternion.Euler(Vector3.forward * (-120));
                currentState++;
                this.gameObject.GetComponent<AudioSource>().Play();
            }
            if (Input.GetKeyUp(KeyCode.C) && currentState == 2)
            {
                this.gameObject.GetComponent<AudioSource>().Stop();
                duo.transform.rotation = Quaternion.Euler(Vector3.forward * (-240));
                trio.transform.rotation = Quaternion.Euler(Vector3.forward * (-240));
                currentState++;
                this.gameObject.GetComponent<AudioSource>().Play();
            }
            if (Input.GetKeyUp(KeyCode.V) && currentState == 3)
            {
                this.gameObject.GetComponent<AudioSource>().Stop();
                duo.transform.rotation = Quaternion.Euler(Vector3.forward * 0);
                trio.transform.rotation = Quaternion.Euler(Vector3.forward * 0);
                currentState = 1;
                this.gameObject.GetComponent<AudioSource>().Play();
                nbTurn++;
            }
        }

        if (nbTurn == 3 && activate == true)
        {
            alert.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0f);
            for (int k = 0; k < 6; k++)
            {
                if (inputs[k].enabled == true)
                    inputs[k].enabled = false;
            }
        }

        if (activate == false)
        {
            alert.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0f);
            for (int k = 0; k < 6; k++)
            {
                if (inputs[k].enabled == true)
                    inputs[k].enabled = false;
            }
        }
    }
}
