using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayers : MonoBehaviour
{
    private Vector3 _spawnOtherPlayerPosition;
    private bool _allowSwap;
    private int _swapCooldown;
    private void Awake()
    {
        _spawnOtherPlayerPosition = GameObject.Find("SpawnOtherPlayer").transform.position;
    }

    private void Start()
    {
        _allowSwap = true;
        _swapCooldown = 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (_allowSwap)
        {
            if (other.gameObject == GameObject.Find("HappyCube"))
            {
                Debug.Log("HappyCube");
                Vector3 currentPlayerPosition = other.transform.position;
                other.transform.position = _spawnOtherPlayerPosition;
                other.tag = "Player";
                GameObject newPlayer = GameObject.Find("SadCube");
                newPlayer.transform.position = currentPlayerPosition;
                newPlayer.tag = "CurrentPlayer";
                _allowSwap = false;
                StartCoroutine("PlayerSwapCooldown");
            }
            else if (other.gameObject == GameObject.Find("SadCube"))
            {
                Debug.Log("SadCube");
                Vector3 currentPlayerPosition = other.transform.position;
                other.transform.position = _spawnOtherPlayerPosition;
                other.tag = "Player";
                GameObject newPlayer = GameObject.Find("HappyCube");
                newPlayer.transform.position = currentPlayerPosition;
                newPlayer.tag = "CurrentPlayer";
                _allowSwap = false;
                StartCoroutine("PlayerSwapCooldown");
            }
        }
    }

    IEnumerator PlayerSwapCooldown()
    {
        while (_swapCooldown >= 0)
        {
            _swapCooldown--;
            yield return new WaitForSeconds(1f);
        }
        _swapCooldown = 1;
        _allowSwap = true;
    }
}
