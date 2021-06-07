using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtravezarPoster : MonoBehaviour
{
    public GameObject jugador;
    public GameObject pared;
    CharacterController controlJugador;
    Collider colliderPared;
    private void Start()
    {
        controlJugador = jugador.GetComponent<CharacterController>();
        colliderPared = pared.GetComponent<Collider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("entra");
            colliderPared.isTrigger = true;
            //controlJugador.Move(new Vector3(-2, 0, 0));
        }
    }
}
