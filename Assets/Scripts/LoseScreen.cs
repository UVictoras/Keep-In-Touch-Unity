using UnityEngine;

public class LoseScreen : MonoBehaviour
{
    void Start()
    {
        this.gameObject.GetComponent<AudioSource>().Play();
    }
}
