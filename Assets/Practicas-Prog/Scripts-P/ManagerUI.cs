using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ManagerUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textTiempo;
    [SerializeField] TextMeshProUGUI textEnemigosRestantes;
    [SerializeField] TextMeshProUGUI textFallos;
    [SerializeField] TextMeshProUGUI textScore;
    private int contadorSegundos;
    private int enemigosRestantes;
    private int fallos;
    private int score;
    
    // Start is called before the first frame update
    void Start()
    {
        contadorSegundos = 30;
        textTiempo.text = contadorSegundos.ToString();
        enemigosRestantes = 5;
        textEnemigosRestantes.text = enemigosRestantes.ToString();
        fallos = 0;
        textFallos.text = fallos.ToString();
        score = 0;
        textScore.text = score.ToString();
        StartCoroutine("CorrutinaTiempo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CorrutinaTiempo()
    {
        while (contadorSegundos >= 0 && enemigosRestantes >= 0)
        {
            textTiempo.text = contadorSegundos--.ToString();
            yield return new WaitForSeconds(1.0f);
        }
        score = contadorSegundos * 100 + (5 - enemigosRestantes) * 500 - fallos * 200;
        textScore.text = score.ToString();
    }

    public void ComerEnemigos()
    {
        textEnemigosRestantes.text = enemigosRestantes--.ToString();
        Debug.Log("Se toco un enemigo real");
    }

    public void TocarFantasma()
    {
        textFallos.text = fallos++.ToString();
        Debug.Log("Se toco un enemigo falso");
    }
}
