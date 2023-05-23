using UnityEngine;

public class LoseScreen : MonoBehaviour
{
    void Update()
    {
        this.gameObject.GetComponent<AudioSource>().Play();
    }
}
