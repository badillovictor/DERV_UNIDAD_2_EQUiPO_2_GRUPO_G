using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlerTrampa : MonoBehaviour
{
    private float tiempoEnTrigger;

    private float tiempoParaNuevoEnemigo;

    private Transform spawnpoint;
    
    [SerializeField] private List<GameObject> listaEnemigo;

    private int contadorEnemigoActual;

    void Awake()
    {
        spawnpoint = GameObject.Find("SpawnEnemigos").transform;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        tiempoParaNuevoEnemigo = 1.5f;
        contadorEnemigoActual = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        tiempoEnTrigger += Time.deltaTime;
        if (tiempoEnTrigger > tiempoParaNuevoEnemigo)
        {
            //'genera' enemigo
            listaEnemigo[contadorEnemigoActual].transform.position = spawnpoint.position;
            //fuerzas
            listaEnemigo[contadorEnemigoActual].GetComponent<Rigidbody>().AddForce(10f * -1 * transform.up, ForceMode.Impulse);
            contadorEnemigoActual++;
            contadorEnemigoActual %= listaEnemigo.Count;
            tiempoEnTrigger = 0.0f;
        }
    }
}
