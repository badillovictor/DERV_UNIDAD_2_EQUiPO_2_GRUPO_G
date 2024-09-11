using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int escenaActiva = SceneManager.GetActiveScene().buildIndex;
        if(escenaActiva == 0 && Input.GetKeyDown(KeyCode.Space))
        {
            cambioEscena(1);
        }
        else if(escenaActiva == 2)
        {
            textScore.text = PlayerPrefs.GetInt("Score", 0).ToString();
        }
    }

    public void cambioEscena(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void cambioEscena(int index, int score)
    {
        PlayerPrefs.SetInt("Score", score);
        cambioEscena(index);
    }
}
