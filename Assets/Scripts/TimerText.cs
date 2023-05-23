using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerText : MonoBehaviour
{
    public Text counterText;
    public float counter;
    public bool timerOn = false;

    public void Start()
    {
        timerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerOn == true)
        {
            //StartCoroutine(updateCounter(&counter));
        }
    }
    /*
    public IEnumerator updateTimer(float currentTime)
    {
        currentTime++;

        float minutes = Mathf.FloorToInt(currentTime/60);
        float seconds = Mathf.FloorToInt(currentTime%60);

        counterText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
    /*
    public IEnumerator updateCounter()
    {
        yield return new WaitForSeconds(1);

        if (counter > 0)
        {
            counter--;
            updateTimer(counter);
        }
        else
        {
            timerOn = false;
            SceneManager.LoadScene("LooseScreen",LoadSceneMode.Single);
            this.gameObject.GetComponent<AudioSource>().Play();
        }
    }
    */
}
