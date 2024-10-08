using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S4_MovRotCompuesto : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float rotateSpeed = 25f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angulo = 5f * rotateSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.W)) //Adelante
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S)) //Atras
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime * -1;
        }

        if(Input.GetKey(KeyCode.A)) //Izquierda
        {
            transform.position += transform.right * moveSpeed * Time.deltaTime * -1;
        }
        else if (Input.GetKey(KeyCode.D)) //Derecha
        {
            transform.position += transform.right * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Q)) //Izquierda
        {
            transform.Rotate(0, angulo * -1, 0);
        }
        else if (Input.GetKey(KeyCode.E)) //Derecha
        {
            transform.Rotate(0, angulo, 0);
        }
    }
}
