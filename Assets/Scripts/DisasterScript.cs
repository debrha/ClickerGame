using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisasterScript : MonoBehaviour
{
    public GameObject statusBox;
    private float cookieCheck;
    public int genChance;
    public bool disasterActive = false;
    public int cookieLoss;
    public GameObject fireAnim;

    void Update()
    {
        cookieCheck = GlobalCookies.CookieCount / 5;
        if (disasterActive == false)
        {
            StartCoroutine(StartDisaster());
        }
    }
    IEnumerator StartDisaster()
    {
        disasterActive = true;
        genChance = Random.Range(1, 20);
        Debug.Log("Checking for Disaster " + cookieCheck + " vs " + genChance);
        if (cookieCheck >= genChance)
        {
            Debug.Log("Starting Disaster");
            fireAnim.SetActive(true);

            cookieLoss = Mathf.RoundToInt(GlobalCookies.CookieCount * 0.25f);
            statusBox.GetComponent<Text>().text = "You lost " + cookieLoss + " cookies in a factory fire!";
            GlobalCookies.CookieCount -= cookieLoss;
            yield return new WaitForSeconds(3);
            statusBox.GetComponent<Animation>().Play("StatusAnim");
            yield return new WaitForSeconds(1);
            statusBox.SetActive(false);
            fireAnim.SetActive(false);
            statusBox.SetActive(true);
            Debug.Log("Stopping Disaster");

        }
        yield return new WaitForSeconds(10);
        disasterActive = false;
    }
}
