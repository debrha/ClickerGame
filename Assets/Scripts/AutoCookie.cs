using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCookie : MonoBehaviour
{
    public bool CreatingCookie = false;
    public static int CookieIncrease = 1;
    public int InternalIncrease;
    public GameObject cupcake;
    public Transform spawnPoint;

    void Update()
    {
        CookieIncrease = GlobalBaker.bakePerSec;
        InternalIncrease = CookieIncrease;
        if (CreatingCookie == false)
        {
            CreatingCookie = true;
            StartCoroutine(CreateTheCookie());
        }
    }
    IEnumerator CreateTheCookie ()
    {
        GlobalCookies.CookieCount += InternalIncrease;
        for (int i = 0; i < InternalIncrease; i++)
        {
            Instantiate(cupcake, spawnPoint.position, spawnPoint.rotation);
        }
        yield return new WaitForSeconds(1);
        CreatingCookie = false;
    }
}
