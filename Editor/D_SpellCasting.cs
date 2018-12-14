using NUnit.Framework;

namespace UnityTest
{
    [TestFixture]
    internal class D_SpellCasting
    {

        [Test]
        public void One_Times_Spell_Strenth_Five_NOVICE_Maximum_Meter()
        {
            // Arrange
            MagicCharacter m = new MagicCharacter();
            int spellStrength = 5;
            int expectedResult = spellStrength;

            // Act
            int result = m.CastSpell(spellStrength);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void One_Times_Spell_Strenth_Two_NOVICE_Maximum_Meter()
        {
            // Arrange
            MagicCharacter m = new MagicCharacter();
            int spellStrength = 2;
            int expectedResult = spellStrength;

            // Act
            int result = m.CastSpell(spellStrength);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }


        [Test]
        public void Two_Times_Spell_Strenth_Five_SOURCERER_Maximum_Meter()
        {
            // Arrange
            MagicCharacter m = new MagicCharacter();
            int spellStrength = 5;
            int expectedResult = 2 * spellStrength;

            // Act
            m.SetWizardLevel(MagicCharacter.WizardLevelType.SOURCERER);
            int result = m.CastSpell(spellStrength);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }


        [Test]
        public void Ten_Times_Spell_Strenth_Five_MAGE_Maximum_Meter()
        {
            // Arrange
            MagicCharacter m = new MagicCharacter();
            int spellStrength = 5;
            int expectedResult = 10 * spellStrength;

            // Act
            m.SetWizardLevel(MagicCharacter.WizardLevelType.MAGE);
            int result = m.CastSpell(spellStrength);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Half_Spell_Strenth_6_NOVICE_NOT_Maximum_Meter()
        {
            // Arrange
            MagicCharacter m = new MagicCharacter();
            int spellStrength = 6;
            int expectedResult = 3;

            // Act
            m.DecreaseMagicMeter(0.1f);
            int result = m.CastSpell(spellStrength);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Half_Spell_Strenth_6_SOURCER_NOT_Maximum_Meter()
        {
            // Arrange
            MagicCharacter m = new MagicCharacter();
            int spellStrength = 6;
            int expectedResult = 3;

            // Act
            m.SetWizardLevel(MagicCharacter.WizardLevelType.SOURCERER);
            m.DecreaseMagicMeter(0.1f);
            int result = m.CastSpell(spellStrength);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }


        [Test]
        public void Half_Spell_Strenth_10_MAGE_NOT_Maximum_Meter()
        {
            // Arrange
            MagicCharacter m = new MagicCharacter();
            int spellStrength = 10;
            int expectedResult = 5;

            // Act
            m.SetWizardLevel(MagicCharacter.WizardLevelType.SOURCERER);
            m.DecreaseMagicMeter(0.1f);
            int result = m.CastSpell(spellStrength);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }




    }
}