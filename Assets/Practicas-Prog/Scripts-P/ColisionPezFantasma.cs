using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionPezFantasma : MonoBehaviour
{
    [SerializeField] ManagerUI managerUI;
    private void OnTriggerEnter(Collider other)
    {
        managerUI.TocarFantasma();
    }
}
