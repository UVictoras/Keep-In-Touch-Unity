using UnityEngine;

public class SwitchInteraction : MonoBehaviour
{
    public Sprite turnedOn;
    public Sprite turnedOff;
    public GameObject[] switches;  
    public int id;
    private int selectedSwitch;
    private string state = "Off";
    private int num;
    private string[] solution = {"On","Off","On","On","Off"};
    private string[] switchesState = {"On","On","On","On","On"};
    private void Start()
    {
        selectedSwitch = 1;

        Randomize();

        if (switches.Length > 1)
        {
            for (int i = 0; i < 5; i++)
                switchesState[i] = switches[i].GetComponent<SwitchInteraction>().state;
        }

        while (solution == switchesState)
        {
            Randomize();
        }
    }

    private void Randomize()
    {
        foreach (GameObject switch_ in switches)
        {
            num = Random.Range(1,3);
            if (num == 1)
                switch_.GetComponent<SwitchInteraction>().state = "On";
            else if (num == 2)
                switch_.GetComponent<SwitchInteraction>().state = "Off";
        }
    }

    private void Update()
    {   
        if (solution == switchesState)
            Debug.Log("Good sequence");

        if (Input.GetKeyUp(KeyCode.U))
        {
            if (selectedSwitch < 5)
                selectedSwitch++;
            else if (selectedSwitch == 5)
                selectedSwitch = 1;
        }

        if (Input.GetKeyUp(KeyCode.Z))
        {
            if (this.id == selectedSwitch)
            {
                if (this.state != "On")
                    this.state = "On";
                else 
                    this.state = "Off";
                this.gameObject.GetComponent<AudioSource>().Play();
            }
        }

        if (this.state == "On")
            this.gameObject.GetComponent<SpriteRenderer>().sprite = turnedOn;
        else
            this.gameObject.GetComponent<SpriteRenderer>().sprite = turnedOff;

        if (switches.Length > 1)
        {
            for (int i = 0; i < 5; i++)
                switchesState[i] = switches[i].GetComponent<SwitchInteraction>().state;
        }
    }
}
