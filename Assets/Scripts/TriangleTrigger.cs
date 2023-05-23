using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleTrigger : MonoBehaviour
{
    public bool collide;

    public void OnTriggerEnter2d(Collider2D other)
    {
        collide = true;
    }

    public void OnTriggerExit2d(Collider2D other)
    {
        collide = false;
    }
}
