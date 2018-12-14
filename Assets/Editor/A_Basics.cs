using NUnit.Framework;

namespace UnityTest
{
    [TestFixture]
    internal class A_Basics
    {
        [Test]
        public void Name_Empty_When_Created()
        {
            // Arrange
            MagicCharacter m = new MagicCharacter();
            string expectedResult = "";

            // Act
            string result = m.GetName();

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Name_Changed_With_Valid_String()
        {
            // Arrange
            MagicCharacter m = new MagicCharacter();
            string expectedResult = "Matt";

            // Act
            m.SetName("Matt");
            string result = m.GetName();

            // Assert
            Assert.AreEqual(expectedResult, result);
        }


        [Test]
        public void Level_Novice_When_Created()
        {
            // Arrange
            MagicCharacter m = new MagicCharacter();
            MagicCharacter.WizardLevelType expectedResult = MagicCharacter.WizardLevelType.NOVICE;

            // Act
            MagicCharacter.WizardLevelType result = m.GetWizardLevel();

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Magic_Meter_One_When_Created()
        {
            // Arrange
            MagicCharacter m = new MagicCharacter();
            float expectedResult = 1;

            // Act
            float result = m.GetMagicMeter();

            // Assert
            Assert.AreEqual(expectedResult, result);
        }


        [Test]
        public void No_Last_Error_When_Created()
        {
            // Arrange
            MagicCharacter m = new MagicCharacter();
            string expectedResult = "(none)";

            // Act
            string result = m.GetLastError();

            // Assert
            Assert.AreEqual(expectedResult, result);
        }


        [Test]
        public void Can_Cast_Meter_Over_Point_Five()
        {
            // Arrange
            MagicCharacter m = new MagicCharacter();

            // Act
            bool result = m.CanCastSpell();

            // Assert
            Assert.IsTrue(result);
        }


        [Test]
        public void Magic_Meter_Multiplier_Is_Active_Meter_At_Maximum()
        {
            // Arrange
            MagicCharacter m = new MagicCharacter();

            // Act
            bool result = m.IsActiveMaxMeterMultiplier();

            // Assert
            Assert.IsTrue(result);
        }




    }

}