using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBaker : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public GameObject bakerStats;
    public int currentCash;
    public static int bakerValue = 10;
    public static bool turnOffButton = false;
    public static int numberOfBakers;
    public static int bakePerSec;

    void Start()
    {
        
    }

    void Update()
    {
        currentCash = GlobalCash.CashCount;
        bakerStats.GetComponent<Text>().text = "Bakers: " + numberOfBakers + " at " + bakePerSec + " per second";
        fakeText.GetComponent<Text>().text = "Hire Baker - $" + bakerValue;
        realText.GetComponent<Text>().text = "Hire Baker - $" + bakerValue;
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
