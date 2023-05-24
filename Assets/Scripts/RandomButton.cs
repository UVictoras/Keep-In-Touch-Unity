using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomButton : MonoBehaviour
{
    public int id;
    public GameObject qte;

    private void Update()
    {
        if (this.id == 1 && Input.GetKeyUp(KeyCode.S))
            this.qte.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0f);
        else if (this.id == 2 && Input.GetKeyUp(KeyCode.G))
            this.qte.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0f);
        else if (this.id == 3 && Input.GetKeyUp(KeyCode.B))
            this.qte.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0f);
    }
}
