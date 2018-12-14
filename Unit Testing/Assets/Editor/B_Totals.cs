using NUnit.Framework;

namespace UnityTest
{
    [TestFixture]
    internal class B_Totals
    {
        [Test]
        public void Magic_Meter_Reduces_Correctly_With_Valid_Amount_Point_Five()
        {
            // Arrange
            MagicCharacter m = new MagicCharacter();
            float expectedResult = 0.5f;

            // Act
            m.DecreaseMagicMeter(0.5f);
            float result = m.GetMagicMeter();

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Magic_Meter_Reduces_Correctly_With_Valid_Amount_Point_One()
        {
            // Arrange
            MagicCharacter m = new MagicCharacter();
            float expectedResult = 0.9f;

            // Act
            m.DecreaseMagicMeter(0.1f);
            float result = m.GetMagicMeter();

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Magic_Meter_Increases_Correctly_With_Valid_Amount_Point_Five()
        {
            // Arrange
            MagicCharacter m = new MagicCharacter();
            float expectedResult = 0.5f;

            // Act
            m.DecreaseMagicMeter(1.0f);
            m.IncreaseMagicMeter(0.5f);
            float result = m.GetMagicMeter();

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Magic_Meter_Increases_Correctly_With_Valid_Amount_Point_Two()
        {
            // Arrange
            MagicCharacter m = new MagicCharacter();
            float expectedResult = 0.2f;

            // Act
            m.DecreaseMagicMeter(1.0f);
            m.IncreaseMagicMeter(0.2f);
            float result = m.GetMagicMeter();

            // Assert
            Assert.AreEqual(expectedResult, result);
        }


        [Test]
        public void Can_NOT_Cast_Meter_At_Point_Five()
        {
            // Arrange
            MagicCharacter m = new MagicCharacter();

            // Act
            m.DecreaseMagicMeter(0.5f);
            bool result = m.CanCastSpell();

            // Assert
            Assert.IsFalse(result);
        }


        [Test]
        public void Can_NOT_Cast_Meter_Below_Point_Five()
        {
            // Arrange
            MagicCharacter m = new MagicCharacter();

            // Act
            m.DecreaseMagicMeter(0.9f);
            bool result = m.CanCastSpell();

            // Assert
            Assert.IsFalse(result);
        }



    }
}