using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 Balbuena Nogues Georva Ivette

     */

public class Persecucion : MonoBehaviour
{
    public Transform playerPosition;
    public float velocidadEnemigo;

    // Start is called before the first frame update
    void Start()
    {
        // me da la referencia del player
        playerPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //El enemigo persigue al jugador 
        Perseguir(playerPosition, this.gameObject.transform);
    }
   public void Perseguir(Transform player, Transform enemigo)
    {
        Vector3 distancia = player.position - enemigo.position;
        // enemigo. Translate funciona como el dueño del perseguidor.
        // la herencia nos va ayudar a no cetear algunos objetos
        enemigo.LookAt(distancia);
        enemigo.Translate(distancia.normalized * velocidadEnemigo * Time.deltaTime);
    }
}
