using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Regresa : MonoBehaviour
{
    public GameObject jugador;
    public GameObject pared1;
    public GameObject pared2;
    public GameObject pared3;
    public GameObject pared4;
    public GameObject pared5;
    public GameObject pared6;
    Collider colliderPared1;
    Collider colliderPared2;
    Collider colliderPared3;
    Collider colliderPared4;
    Collider colliderPared5;
    Collider colliderPared6;

    CharacterController controlJugador;
    private void Start()
    {
        controlJugador = jugador.GetComponent<CharacterController>();
        colliderPared1 = pared1.GetComponent<Collider>();
        colliderPared2 = pared2.GetComponent<Collider>();
        colliderPared3 = pared3.GetComponent<Collider>();
        colliderPared4 = pared4.GetComponent<Collider>();
        colliderPared5 = pared5.GetComponent<Collider>();
        colliderPared6 = pared6.GetComponent<Collider>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("entra");
            colliderPared1.isTrigger = true;
            colliderPared2.isTrigger = true;
            colliderPared3.isTrigger = true;
            colliderPared4.isTrigger = true;
            colliderPared5.isTrigger = true;
            colliderPared6.isTrigger = true;

            controlJugador.Move(new Vector3(58, 0, 0));
        }
    }

}
