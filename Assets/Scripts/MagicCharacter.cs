using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MagicCharacter
{
    public enum WizardLevelType
    {
        NOVICE,
        SOURCERER,
        MAGE,
    }

    private string name;
    private float magicMeter;
    private WizardLevelType wizardLevelType;
    private bool multiplierMagicIsActive;
    private string lastError;
    private int spellStrength;

    public MagicCharacter()
    {
        this.name = "";
        this.lastError = "(none)";
        this.magicMeter = 1;
        this.wizardLevelType = WizardLevelType.NOVICE;
        this.multiplierMagicIsActive = true;
        if (this.wizardLevelType == WizardLevelType.NOVICE)
            spellStrength = 1;
        if (this.wizardLevelType == WizardLevelType.SOURCERER)
            spellStrength = 2;
        if (this.wizardLevelType == WizardLevelType.MAGE)
            spellStrength = 10;
    }

    public void DecreaseMagicMeter(float v)
    {
        if (v < 0)
            this.lastError = "DecreaseMagicMeter: value less than zero";
        else 
            this.magicMeter = this.magicMeter - v;
    }

    public string GetName()
    {
        return this.name;
    }

    public void SetName(string v)
    {
        if (v == "")
            this.lastError = "SetName: attempt to set name to empty string";
        else
            this.name = v;
    }

    public MagicCharacter.WizardLevelType GetWizardLevel()
    {
        return this.wizardLevelType;
    }

    public float GetMagicMeter()
    {
        return this.magicMeter;
    }

    public string GetLastError()
    {
        return this.lastError;
    }

    public bool CanCastSpell()
    {
        if (this.magicMeter > 0.5)
            return true;
        else
            return false;
    }

    public bool IsActiveMaxMeterMultiplier()
    {
        return this.multiplierMagicIsActive;
    }

    public void IncreaseMagicMeter(float v)
    {
        if (v < 0)
            this.lastError = "IncreaseMagicMeter: value less than zero";
        else
            this.magicMeter = this.magicMeter + v;

        if (this.wizardLevelType == WizardLevelType.NOVICE)
            spellStrength = 1;
        if (this.wizardLevelType == WizardLevelType.SOURCERER)
            spellStrength = 2;
        if (this.wizardLevelType == WizardLevelType.MAGE)
            spellStrength = 10;
    }

    public void SetWizardLevel(MagicCharacter.WizardLevelType value)
    {
        if (value != MagicCharacter.WizardLevelType.NOVICE || value != MagicCharacter.WizardLevelType.SOURCERER || value != MagicCharacter.WizardLevelType.MAGE)
            this.lastError = "SetWizardLevel: paramater is not a wizard level";
        else
            this.wizardLevelType = value;
    }

    public int CastSpell(int spellStrength)
    {
        return this.spellStrength * spellStrength;
    }
}
