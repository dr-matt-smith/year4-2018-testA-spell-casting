using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class MagicCharacter {

    public enum WizardLevelType
    {
        NOVICE,
        SOURCERER,
        MAGE
    }

    private string name;
    private WizardLevelType lvlType;
    private float magicMeter;
    private string lastError;

    public MagicCharacter()
    {
        name = "";
        magicMeter = 1.0f;
        lastError = "(none)";
    }

    public string GetName()
    {
        return name;
    }
    public void SetName(string value)
    {
        if (value == "")
            lastError = "SetName: attempt to set name to empty string";
        else
            name = value;
    }
    public WizardLevelType GetWizardLevel()
    {
        return lvlType;
    }
    public void SetWizardLevel(WizardLevelType lvl)
    {
        lvlType = lvl;
    }
    public float GetMagicMeter()
    {
        return magicMeter;
    }
    public string GetLastError()
    {
        return lastError;
    }
    public bool CanCastSpell()
    {
        return magicMeter > 0.5f;
    }
    public bool IsActiveMaxMeterMultiplier()
    {
        return true;
    }

    public void DecreaseMagicMeter(float value)
    {
        if(value < 0)
            lastError = "DecreaseMagicMeter: value less than zero";
        else
            magicMeter -= value;
    }

    public void IncreaseMagicMeter(float value)
    {

        if (value < 0)
            lastError = "IncreaseMagicMeter: value less than zero";
        else
            magicMeter += value;
    }

    public int CastSpell(int spellStrength)
    {
        if (magicMeter != 1)
            return spellStrength / 2;

        int multiplicator = 1;
        switch (lvlType)
        {
            case WizardLevelType.NOVICE:
                multiplicator = 1;
                break;
            case WizardLevelType.SOURCERER:
                multiplicator = 2;
                break;
            case WizardLevelType.MAGE:
                multiplicator = 10;
                break;
        }        
        return multiplicator * spellStrength;
    }
}
