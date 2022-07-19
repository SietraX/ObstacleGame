using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int bumpCounter = 0;
    private void OnCollisionEnter(Collision other)
    {
        bumpCounter++;
        Debug.Log("You've bumped into a thing " + bumpCounter + " times.");
    }
}
