using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class S7_DestroyOnCollisionReporta : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txtKillCount;
    public int killCount;

    // Start is called before the first frame update
    void Start()
    {
        killCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        GameObject obj = other.gameObject;
        if (obj.CompareTag("TypeEnemy"))
        {
            Destroy(obj);
            killCount++;
            txtKillCount.text = killCount.ToString();
        }
    }
}
