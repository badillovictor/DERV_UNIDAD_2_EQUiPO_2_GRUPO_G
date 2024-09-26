using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlerTrampaCorrutina : MonoBehaviour
{
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
        tiempoParaNuevoEnemigo = 2.0f;
        contadorEnemigoActual = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CorrutinaSpawnEnemigos()
    {
        //'genera' enemigo
        listaEnemigo[contadorEnemigoActual].transform.position = spawnpoint.position;
        Debug.Log("Se TPeo un enemigo");
        //fuerzas
        //listaEnemigo[0].GetComponent<Rigidbody>().AddForce(10f * transform.up, ForceMode.Impulse);
        contadorEnemigoActual++;
        contadorEnemigoActual %= listaEnemigo.Count;
        yield return new WaitForSeconds(tiempoParaNuevoEnemigo * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine("CorrutinaSpawnEnemigos");
            Debug.Log("Empezar Spawn Enemigos");
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            StopCoroutine("CorrutinaSpawnEnemigos");
            Debug.Log("Detener Spawn Enemigos");
        }
    }
}
