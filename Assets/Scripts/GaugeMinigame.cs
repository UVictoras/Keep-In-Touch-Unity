using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GaugeMinigame : MonoBehaviour
{
    public GameObject qte;
    public GameObject[] gauges;
    public TextMeshProUGUI inputP, inputH, inputX;
    private void Update()
    {
        if (gauges[0].GetComponent<ColorGauge>().activated == false && gauges[1].GetComponent<ColorGauge>().activated == false && gauges[2].GetComponent<ColorGauge>().activated == false)
        {
            qte.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0f);
            inputP.enabled = false;
            inputH.enabled = false;
            inputX.enabled = false;
        }
    }
}
