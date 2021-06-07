using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Regresa : MonoBehaviour
{
    public Transform destino;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals ("ultima"))
        {
            transform.position = destino.position;
            transform.rotation = destino.rotation;
        }
    }
}
