using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
    private void OnCollisionExit(Collision other)
    {
        StartCoroutine(DelayThenChangeColor(0.25f));

    }
    IEnumerator DelayThenChangeColor(float delay)
    {
        yield return new WaitForSeconds(delay);
        GetComponent<MeshRenderer>().material.color = new Color(231, 210, 210, 255);
    }

}
