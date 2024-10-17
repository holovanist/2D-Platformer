using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Shop : MonoBehaviour
{
    GameObject shop1;
    GameObject shop2;
    GameObject shop3;
    GameObject shop4;
    GameObject shop5;


    public bool LightningSpells {  get; set; }
    public bool LightningSpellsUpgrade { get; set; }
    public bool FireballUpgrade { get; set; }
    public bool MaxManaIncrease { get; set; }
    public bool MaxHealthIncrease { get; set; }

    private readonly CoinCount CoinCount;
    private readonly UpgradeChecker UpgradeChecker;

    public int Cost1;
    public int Cost2;
    public int Cost3;
    public int Cost4;
    public int Cost5;
    // Start is called before the first frame update
    void Start()
    {
        
        shop1 = GameObject.FindGameObjectWithTag("Shop 1");
        shop2 = GameObject.FindGameObjectWithTag("Shop 2");
        shop3 = GameObject.FindGameObjectWithTag("Shop 3");
        shop4 = GameObject.FindGameObjectWithTag("Shop 4");
        shop5 = GameObject.FindGameObjectWithTag("Shop 5");
    }

    public void Purchase1()
    {
        if (Cost1 <= CoinCount.CoinAmount)
        {
            LightningSpells = true;
            shop1.SetActive(false);
            CoinCount.CoinAmount -= Cost1;
        }
    }
    public void Purchase2()
    {
        if (Cost2 <= CoinCount.CoinAmount)
        {
            LightningSpellsUpgrade = true;
            shop2.SetActive(false);
            CoinCount.CoinAmount -= Cost2;
        }
    }
    public void Purchase3()
    {
        if (Cost3 <= CoinCount.CoinAmount)
        {
            FireballUpgrade = true;
            shop3.SetActive(false);
            CoinCount.CoinAmount -= Cost3;
        }
    }
    public void Purchase4()
    {
        if (Cost4 <= CoinCount.CoinAmount)
        {
            MaxManaIncrease = true;
            shop4.SetActive(false);
            CoinCount.CoinAmount -= Cost4;
        }
    }
    public void Purchase5()
    {
        if (Cost5 <= CoinCount.CoinAmount)
        {
            MaxHealthIncrease = true;
            shop5.SetActive(false);
            CoinCount.CoinAmount -= Cost5;
        }
    }
    private void OnLevelWasLoaded(int level)
    {
       
        if(UpgradeChecker.LightningSpells == true)
        {
            LightningSpells = true;
            shop1.SetActive(false);
        }
        if (UpgradeChecker.LightningSpellsUpgrade == true)
        {
            LightningSpellsUpgrade = true;
            shop2.SetActive(false);
        }
        if (UpgradeChecker.FireballUpgrade == true)
        {
            FireballUpgrade = true;
            shop3.SetActive(false);
        }
        if (UpgradeChecker.MaxManaIncrease == true)
        {
            MaxManaIncrease = true;
            shop4.SetActive(false);
        }
        if (UpgradeChecker.MaxHealthIncrease == true)
        {
            MaxHealthIncrease = true;
            shop5.SetActive(false);
        }
    }
}