using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionPezReal : MonoBehaviour
{
    [SerializeField] ManagerUI managerUI;
    private void OnCollisionEnter(Collision other)
    {
        managerUI.ComerEnemigos();
        Destroy(this.gameObject);
    }
}
