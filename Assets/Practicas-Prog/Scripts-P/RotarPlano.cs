using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarPlano : MonoBehaviour
{
    private float _rotateSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        _rotateSpeed = 20f;
    }

    // Update is called once per frame
    void Update()
    {
        float angle = _rotateSpeed * Time.deltaTime;
        //float angleLimit = 10;
        if (Input.GetKey(KeyCode.W)) //Increments towards X axis
        {
            //Debug.Log(transform.rotation.eulerAngles.x);
            transform.Rotate(angle, 0, 0);
        }
        else if (Input.GetKey(KeyCode.S)) //Decrements against X axis
        {
            transform.Rotate(angle * -1, 0, 0);
        }

        if (Input.GetKey(KeyCode.A)) //Increments towards Z axis
        {
            transform.Rotate(0, 0, angle);
        }
        else if (Input.GetKey(KeyCode.D)) //Decrements against Z axis
        {
            transform.Rotate(0, 0, angle * -1);
        }
        
        if (Input.GetKey(KeyCode.Q)) //Izquierda
        {
            transform.Rotate(0, angle * -1, 0);
        }
        else if (Input.GetKey(KeyCode.E)) //Derecha
        {
            transform.Rotate(0, angle, 0);
        }
    }
}
