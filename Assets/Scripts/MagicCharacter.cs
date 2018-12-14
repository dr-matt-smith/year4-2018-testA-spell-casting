using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicCharacter {

    private string name;
    private WizardLevelType wizardLevelType;
    private string lastError;
    private float magicMeter;


	public enum WizardLevelType
    {
        NOVICE,
        SOURCERER,
        MAGE
    }

    public MagicCharacter()
    {
        name = string.Empty;
        wizardLevelType = WizardLevelType.NOVICE;
        lastError = "(none)";
        magicMeter = 1f;
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string v)
    {
        if (string.IsNullOrEmpty(v))
        {
            lastError = "SetName: attempt to set name to empty string";
            return;
        }

        name = v;
    }

    public WizardLevelType GetWizardLevel()
    {
        return wizardLevelType;
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
        return magicMeter > .5f;
    }

    public bool IsActiveMaxMeterMultiplier()
    {
        return magicMeter >= 1f;
    }

    public void DecreaseMagicMeter(float v)
    {
        if (v < 0f)
        {
            lastError = "DecreaseMagicMeter: value less than zero";
            return;
        }

        magicMeter -= v;
    }

    public void IncreaseMagicMeter(float v)
    {
        if (v < 0f)
        {
            lastError = "IncreaseMagicMeter: value less than zero";
            return;
        }

        magicMeter += v;
    }

    public void SetWizardLevel(WizardLevelType t)
    {
        wizardLevelType = t;
    }

    public int CastSpell(int spellStrength)
    {
        float mod = 0f;
        if (IsActiveMaxMeterMultiplier())
        {
            switch (wizardLevelType)
            {
                case WizardLevelType.NOVICE:
                    mod = 1f;
                    break;
                case WizardLevelType.SOURCERER:
                    mod = 2f;
                    break;
                case WizardLevelType.MAGE:
                    mod = 10f;
                    break;
            }
        }
        else
            mod = .5f;
        return (int)(spellStrength * mod);
    }
}
