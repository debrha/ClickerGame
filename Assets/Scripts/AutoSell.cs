using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSell : MonoBehaviour
{
    public bool SellingCookie = false;
    public static int CashIncrease = 1;
    public int InternalIncrease;

    void Update()
    {
        CashIncrease = GlobalShop.shopPerSec;
        InternalIncrease = CashIncrease;
        if (SellingCookie == false)
        {
            SellingCookie = true;
            StartCoroutine(SellTheCookie());
        }
    }
    IEnumerator SellTheCookie ()
    {
        if (GlobalCookies.CookieCount == 0)
        {
            //we can't do anything
        }
        else
        {
            GlobalCash.CashCount += InternalIncrease;
            GlobalCookies.CookieCount -= 1;
            yield return new WaitForSeconds(1);
            SellingCookie = false;
        }
    }
}
