using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    // Start is called before the first frame update
    MeshRenderer rendererComp;
    Rigidbody rigidBodyComp;
    [SerializeField] float timeToWait = 3f;
    void Start()
    {
        rendererComp = GetComponent<MeshRenderer>();
        rigidBodyComp = GetComponent<Rigidbody>();
        rendererComp.enabled = false;
        rigidBodyComp.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        timeCheckerToDrop();
    }
    private void timeCheckerToDrop()
    {
        if (Time.time > timeToWait)
        {
            rendererComp.enabled = true;
            rigidBodyComp.useGravity = true;
        }

    }
}
