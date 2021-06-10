using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtravezarPoster : MonoBehaviour
{
    public GameObject jugador;
    public GameObject pared;
    CharacterController controlJugador;
    Collider colliderPared;
    videos apagarVideos;
    private void Start()
    {
        controlJugador = jugador.GetComponent<CharacterController>();
        colliderPared = pared.GetComponent<Collider>();
        apagarVideos = GetComponent<videos>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("entra");
            colliderPared.isTrigger = true;
            apagarVideos.Apaga();
        }

    }
}
