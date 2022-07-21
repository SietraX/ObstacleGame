using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hitCounter = 0;
    private void OnCollisionEnter(Collision other)
    {
        hitCounter++;
        Debug.Log("You've bumped into the obstacles " + hitCounter + " times.");

    }
}
