using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerFalse : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        Collider collider;
        collider = gameObject.GetComponent<Collider>();
        collider.isTrigger = false;
    }
}
