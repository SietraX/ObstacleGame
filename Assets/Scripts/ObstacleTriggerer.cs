using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleTriggerer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float minTimeToWait;
    [SerializeField] float maxTimeToWait;
    float timeToDrop = 0f;

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag != "Player")
        {
            return;
        }
        foreach (Transform child in transform)
        {
            timeToDrop = Random.Range(minTimeToWait, maxTimeToWait);
            StartCoroutine(child.GetComponent<Dropper>().timeCheckerToDrop(timeToDrop));
        }
        BoxCollider boxCollider = GetComponent<BoxCollider>();
        boxCollider.enabled = false;
    }
}
