using NUnit.Framework;

namespace UnityTest
{
    [TestFixture]
    internal class C_Errors
    {
        [Test]
        public void No_Error_When_Name_Changed_With_Valid_String()
        {
            // Arrange
            MagicCharacter m = new MagicCharacter();
            string expectedResult = "(none)";

            // Act
            m.SetName("Matt");
            string result = m.GetLastError();

            // Assert
            Assert.AreEqual(expectedResult, result);
        }


        [Test]
        public void Error_Set_Name_With_Empty_String()
        {
            // Arrange
            MagicCharacter m = new MagicCharacter();
            string expectedResult = "SetName: attempt to set name to empty string";

            // Act
            m.SetName("");
            string result = m.GetLastError();

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Error_Decrease_With_Negative_Amount()
        {
            // Arrange
            MagicCharacter m = new MagicCharacter();
            string expectedResult = "DecreaseMagicMeter: value less than zero";

            // Act
            m.DecreaseMagicMeter(-0.5f);
            string result = m.GetLastError();

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Error_Increase_With_Negative_Amount()
        {
            // Arrange
            MagicCharacter m = new MagicCharacter();
            string expectedResult = "IncreaseMagicMeter: value less than zero";

            // Act
            m.DecreaseMagicMeter(1.0f);
            m.IncreaseMagicMeter(-0.1f);
            string result = m.GetLastError();

            // Assert
            Assert.AreEqual(expectedResult, result);
        }



    }
}