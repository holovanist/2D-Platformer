using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinCount : MonoBehaviour
{
    public int CoinAmount { get; set; }
    public TextMeshProUGUI MyText;
    public int Score { get; set; }
    public int MoneyAmount;

    // Use this for initialization
    void Start()
    {

        MyText.text = "";
        Score = 0;
    }


    // Update is called once per frame
    void Update()
    {

        MyText.text = "money " + Score;

    }

    void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.CompareTag("Coin"))
        {
            Score = Score + MoneyAmount;
        }

        if (coll.CompareTag("Coin"))
        {
            coll.gameObject.SetActive(false);
        }

    }
}
