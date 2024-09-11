using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class S8_ControlTiempoConUpdate : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI TextoTiempo;
    float contadorTiempo;
    float contadorSegundos;

    // Start is called before the first frame update
    void Start()
    {
        contadorTiempo = 0;
        contadorSegundos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        contadorTiempo += Time.deltaTime;
        if (contadorTiempo > 1.0) 
        {
            TextoTiempo.text = contadorSegundos++.ToString();
            contadorTiempo = 0;
        }
    }
}
