using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalMovement : MonoBehaviour
{
    private float _moveSpeed;
    private float _rotateSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        _moveSpeed = 10f;
        _rotateSpeed = 30f;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("CurrentPlayer"))
        {
            float angulo = 5f * _rotateSpeed * Time.deltaTime;
            if (Input.GetKey(KeyCode.W)) //Adelante
            {
                transform.position += _moveSpeed * Time.deltaTime * transform.forward;
            }
            else if (Input.GetKey(KeyCode.S)) //Atras
            {
                transform.position += _moveSpeed * Time.deltaTime * -1 * transform.forward;
            }

            if(Input.GetKey(KeyCode.D)) //Izquierda
            {
                transform.position += _moveSpeed * Time.deltaTime * transform.right;
            }
            else if (Input.GetKey(KeyCode.A)) //Derecha
            {
                transform.position += _moveSpeed * Time.deltaTime * -1 * transform.right;
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
}
