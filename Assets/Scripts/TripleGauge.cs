using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleGauge : MonoBehaviour
{
    public Sprite notfilled, filled;

    public void Fill()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = filled;
    }
}
