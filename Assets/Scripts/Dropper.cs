using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    // Start is called before the first frame update
    MeshRenderer rendererComp;
    Rigidbody rigidBodyComp;
    void Start()
    {
        rendererComp = GetComponent<MeshRenderer>();
        rigidBodyComp = GetComponent<Rigidbody>();
        rendererComp.enabled = false;
        rigidBodyComp.useGravity = false;
    }

    // Update is called once per frame

    public IEnumerator timeCheckerToDrop(float timeToDrop)
    {
        yield return new WaitForSeconds(timeToDrop);
        rendererComp.enabled = true;
        rigidBodyComp.useGravity = true;
    }
}
