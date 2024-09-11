using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class S7_DestroyOnCollision : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txtKillCount;
    int killCount;

    private void OnCollisionEnter(Collision other)
    {
        GameObject obj = other.gameObject;
        if (obj.CompareTag("TypeEnemy"))
        {
            Destroy(obj);
            killCount++;
            txtKillCount.text = "Kills: " + killCount;
        }
    }
}
