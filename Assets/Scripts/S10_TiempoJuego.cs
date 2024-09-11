using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class S10_TiempoJuego : MonoBehaviour
{
    [SerializeField] S7_DestroyOnCollisionReporta scoreSource;
    [SerializeField] SceneChange auxiliar;
    [SerializeField] TextMeshProUGUI TextoTiempo;
    int contadorSegundos;

    // Start is called before the first frame update
    void Start()
    {
        contadorSegundos = 60;
        TextoTiempo.text = contadorSegundos--.ToString();
        StartCoroutine("corrutinaTiempo");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator corrutinaTiempo()
    {
        while (contadorSegundos >= 0)
        {
            TextoTiempo.text = contadorSegundos--.ToString();
            yield return new WaitForSeconds(0.1f); // Cada X segundos
        }
        Debug.Log("Is's ovah");
        int score = scoreSource.killCount;
        auxiliar.cambioEscena(2, score);
    }
}
