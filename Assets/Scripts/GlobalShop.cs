using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalShop : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public GameObject shopStats;
    public int currentCash;
    public static int shopValue = 10;
    public static bool turnOffButton = false;
    public static int numberOfShops;
    public static int shopPerSec;

    void Start()
    {

    }

    void Update()
    {
        currentCash = GlobalCash.CashCount;
        shopStats.GetComponent<Text>().text = "Shops: " + numberOfShops + " at " + shopPerSec + " per second";
        fakeText.GetComponent<Text>().text = "Buy Shop - $" + shopValue;
        realText.GetComponent<Text>().text = "Buy Shop - $" + shopValue;
        if (currentCash >= 10)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }

        if (turnOffButton == true)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }
}
