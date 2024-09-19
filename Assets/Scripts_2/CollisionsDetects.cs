using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionsDetects : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision Enter - " + other.gameObject.name);
    }

    private void OnCollisionStay(Collision other)
    {
        Debug.Log("Collision Stay - " + other.gameObject.name);
    }

    private void OnCollisionExit(Collision other)
    {
        Debug.Log("Collision Exit - " + other.gameObject.name);
    }
}
