using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class UpgradeChecker : MonoBehaviour
{

    public bool LightningSpells { get; set; }
    public bool LightningSpellsUpgrade { get; set; }
    public bool FireballUpgrade { get; set; }
    public bool MaxManaIncrease { get;  set; }
    public bool MaxHealthIncrease { get;  set; }

    Shop shop;
    GameObject Store;
    
    // Update is called once per frame
    private void Start()
    {

        GameObject shop1 = GameObject.FindWithTag("Store");
        //Store = GameObject.FindGameObjectWithTag("Store");
        //GetComponent<Shop>();
        if (shop1 != null)
        {
            shop = shop1.GetComponent<Shop>();
        }
    }
    void Update()
    {
        if (shop.LightningSpells == true)
        {
            LightningSpells = true;
        }
        else
        {

        }
        if (shop.LightningSpellsUpgrade == true)
        {
            LightningSpellsUpgrade = true;
        }
        else
        {

        }
        if (shop.FireballUpgrade == true)
        {
            FireballUpgrade = true;
        }
        else
        {

        }
        if(shop.MaxManaIncrease == true) 
        {
            MaxManaIncrease = true;
        }
        else
        {

        }
        if(shop.MaxHealthIncrease == true)
        {
            MaxHealthIncrease = true;
        }
        else if (shop.MaxHealthIncrease == false) 
        {

        }
    }
}
