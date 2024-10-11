using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeChecker : MonoBehaviour
{
    public bool LightningSpells { get; private set; }
    public bool LightningSpellsUpgrade { get; private set; }
    public bool FireballUpgrade { get; private set; }
    public bool MaxManaIncrease { get; private set; }
    public bool MaxHealthIncrease { get; private set; }

    private Shop shop;
    // Start is called before the first frame update
    void Start()
    {
     
     
    }

    // Update is called once per frame
    void Update()
    {
        if (shop.LightningSpells == true)
        {
            LightningSpells = true;
        }
        if (shop.LightningSpellsUpgrade == true)
        {
            LightningSpellsUpgrade = true;
        }
        if (shop.FireballUpgrade == true)
        {
            FireballUpgrade = true;
        }
        if(shop.MaxManaIncrease == true) 
        {
            MaxManaIncrease = true; 
        }
        if(shop.MaxHealthIncrease == true)
        {
            MaxHealthIncrease = true;
        }
    }
}
