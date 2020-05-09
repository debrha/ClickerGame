using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    public GameObject coin;
    public Transform spawnPoint;

    void FixedUpdate()
    {
        bool shoot = Input.GetButtonDown("Fire1");

        if (shoot) Instantiate(coin, spawnPoint.position, spawnPoint.rotation);
    }
}
