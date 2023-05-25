using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pressure : MonoBehaviour
{
    public int id;
    public GameObject arrow, qte;
    private int actualState = 0;
    private int nbTurn = 0;
    public TextMeshProUGUI input;
    private void Update()
    {
        if (id == 1 && Input.GetKeyDown(KeyCode.R) && actualState%2 == 0 && nbTurn < 3)
        {
            arrow.transform.rotation =  Quaternion.Euler(Vector3.forward * (-90));
        }
        if (id == 1 && Input.GetKeyUp(KeyCode.R) && actualState%2 == 0 && nbTurn < 3)
        {
            arrow.transform.rotation = Quaternion.Euler(Vector3.forward * (-180));
            actualState++;
        }
        if (id == 1 && Input.GetKeyDown(KeyCode.N) && actualState%2 != 0 && nbTurn < 3)
        {
            arrow.transform.rotation = Quaternion.Euler(Vector3.forward * 90);
        }
        if (id == 1 && Input.GetKeyUp(KeyCode.N) && actualState%2 != 0 && nbTurn < 3)
        {
            arrow.transform.rotation = Quaternion.Euler(Vector3.forward * 0);
            actualState++;
            nbTurn++;
        }

        if (id == 2 && Input.GetKeyDown(KeyCode.O) && actualState%2 == 0 && nbTurn < 3)
        {
            arrow.transform.rotation =  Quaternion.Euler(Vector3.forward * (-90));
        }
        if (id == 2 && Input.GetKeyUp(KeyCode.O) && actualState%2 == 0 && nbTurn < 3)
        {
            arrow.transform.rotation = Quaternion.Euler(Vector3.forward * (-180));
            actualState++;
        }
        if (id == 2 && Input.GetKeyDown(KeyCode.D) && actualState%2 != 0 && nbTurn < 3)
        {
            arrow.transform.rotation = Quaternion.Euler(Vector3.forward * 90);
        }
        if (id == 2 && Input.GetKeyUp(KeyCode.D) && actualState%2 != 0 && nbTurn < 3)
        {
            arrow.transform.rotation = Quaternion.Euler(Vector3.forward * 0);
            actualState++;
            nbTurn++;
        }

        if (nbTurn == 3)
        {
            this.qte.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0f);
            input.enabled = false;
        }
    }
}
