using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyedByPlayer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
