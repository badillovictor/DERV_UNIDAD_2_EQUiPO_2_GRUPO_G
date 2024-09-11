using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class S9_ControlTiempoConConrutina : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TextoTiempo;
    int contadorSegundos;

    // Start is called before the first frame update
    void Start()
    {
        contadorSegundos = 60;
        StartCoroutine("corrutinaTiempo");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator corrutinaTiempo()
    {
        while (true)
        {
            TextoTiempo.text = contadorSegundos++.ToString();
            yield return new WaitForSeconds(0.5f); // Cada X segundos
        }
    }
}
