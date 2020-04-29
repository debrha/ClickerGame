using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour
{
    public int savedCookies;
    public int savedCash;
    public int savedBakers;
    public int savedShops;
    public int savedValue;

    void Start()
    {
        if (MainMenuOptions.isLoading == true)
        {
            savedCookies = PlayerPrefs.GetInt("SavedCookies");
            GlobalCookies.CookieCount = savedCookies;
            savedCash = PlayerPrefs.GetInt("SavedCash");
            GlobalCash.CashCount = savedCash;
            savedBakers = PlayerPrefs.GetInt("SavedBakers");
            GlobalBaker.bakePerSec = savedBakers;
            savedShops = PlayerPrefs.GetInt("SavedShops");
            GlobalShop.numberOfShops = savedShops;
            savedValue = PlayerPrefs.GetInt("SaveValue");
            SaveGame.saveValue = savedValue;

        }
    }


}
