using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFalseTodas : MonoBehaviour
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
    void OnTriggerExit (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Salio");
            colliderPared1.isTrigger = false;
            colliderPared2.isTrigger = false;
            colliderPared3.isTrigger = false;
            colliderPared4.isTrigger = false;
            colliderPared5.isTrigger = false;
            colliderPared6.isTrigger = false;

            
        }
    }

}
