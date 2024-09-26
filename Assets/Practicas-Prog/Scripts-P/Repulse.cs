using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repulse : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision");
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collision w/Player");
            Vector3 relativeVelocity = other.relativeVelocity;
            Vector3 direction = relativeVelocity.normalized;
            other.gameObject.GetComponent<Rigidbody>().AddForce(50 * -1 * direction, ForceMode.Impulse);
        }
    }
}
