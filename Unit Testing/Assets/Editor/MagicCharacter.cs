using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicCharacter {

    public enum WizardLevelType {SOURCERER, MAGE, NOVICE};



    public string GetName()
    {
        return "";
       
    }

    public void SetName(string name)
    {

    }

    public float GetMagicMeter()
    {
        return 0;

    }


    public string GetLastError()
    {
        return "";

    }


    public bool CanCastSpell()
    {
        return true;

    }

    public bool IsActiveMaxMeterMultiplier()
    {
        return true;

    }


    public int DecreaseMagicMeter(float meter)
    {
        return 0;

    }


    public float IncreaseMagicMeter(float meter)
    {
        return 0;

    }

    public int CastSpell(int spell)
    {
        return 0;
    }

    public void SetWizardLevel(WizardLevelType l)
    {

    }

    public void GetWizardLevel()
    {
        
    }

}
