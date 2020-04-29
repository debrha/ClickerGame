using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupcakeSpawn : MonoBehaviour
{
    public GameObject cupcake;
    public Transform spawnPoint;

    void FixedUpdate()
    {
        bool shoot = Input.GetButtonDown("Fire1");

        if (shoot) Instantiate(cupcake, spawnPoint.position, spawnPoint.rotation);
    }
}
