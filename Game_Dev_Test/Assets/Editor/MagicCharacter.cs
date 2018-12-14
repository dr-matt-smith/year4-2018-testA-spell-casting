namespace UnityTest
{
    internal class MagicCharacter
    {

        private string name = "";
        private float magicMeter = 1;
        private bool canCastSpell = true;
        private bool isActiveMaxMeterMultiplier = true;
        private string lastError = "(none)";
        private int spellStrength;
        private WizardLevelType wizarLevelType;
        private float maximumMagicMeter = 1;

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            if(name == "")
            {
                this.lastError = "SetName: attempt to set name to empty string";
            }
            this.name = name;
        }

        public enum WizardLevelType
        {
            NOVICE,
            SOURCERER,
            MAGE
        };

        public WizardLevelType GetWizardLevel()
        {
            return WizardLevelType.NOVICE;
        }

        public void SetWizardLevel(WizardLevelType wizardLevelType)
        {
            this.wizarLevelType = wizardLevelType;
        }

        public float GetMagicMeter()
        {
            return this.magicMeter;
        }

        public string GetLastError()
        {
            return this.lastError ;
        }

        public bool CanCastSpell()
        {
            if(this.magicMeter <= 0.5)
            {
                this.canCastSpell = false;
            }
            return this.canCastSpell;

        }

        public bool IsActiveMaxMeterMultiplier()
        {
            return this.isActiveMaxMeterMultiplier;
        }

        public void DecreaseMagicMeter(float amount)
        {
            if(amount >= 0)
            {
                this.magicMeter -= amount;
            }
            else
            {
                this.lastError = "DecreaseMagicMeter: value less than zero";
            }
        }

        public void IncreaseMagicMeter(float amount)
        {
            if(amount >= 0)
            {
                this.magicMeter += amount;
            }
            else
            {
                this.lastError = "IncreaseMagicMeter: value less than zero";
            }
        }

        public int CastSpell(int spellStrength)
        {
            this.spellStrength = spellStrength;
            if(this.wizarLevelType==WizardLevelType.SOURCERER)
            {
                if(this.magicMeter == 1)
                {
                    this.spellStrength *= 2;
                }
                else
                {
                    return this.spellStrength /= 2;
                }
            }
            if(this.wizarLevelType == WizardLevelType.MAGE)
            {
                if (this.magicMeter < this.maximumMagicMeter)
                {
                    this.spellStrength /= 2;

                }
                else
                {
                    this.spellStrength *= 10;

                }
                
            }
            if(this.magicMeter < maximumMagicMeter)
            {
                this.spellStrength /= 2;
            }
            return this.spellStrength;
        }
    }
}