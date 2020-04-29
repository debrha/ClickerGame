using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonClick : MonoBehaviour
{
    public GameObject textBox;
    public AudioSource cookieSound;
    public GameObject cupcake;
    public Transform spawnPoint;

    public void clickTheButton ()
    {
        cookieSound.Play();
        GlobalCookies.CookieCount += 1;
        Instantiate (cupcake, spawnPoint.position, spawnPoint.rotation);
    }


}
