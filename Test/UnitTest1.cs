using App;

namespace Test
{
    [TestClass]
    public class RomanNumberTest
    {
        [TestMethod]
        public void ParseTest_EmptyString_ReturnsZero()
        {
            RomanNumber rn = RomanNumber.Parse("");
            Assert.IsNotNull(rn);
            Assert.AreEqual(0, rn.Value, "Expected value for empty string is 0.");
        }

        [TestMethod]
        public void ParseTest_SingleDigitRomanNumerals()
        {
            Assert.AreEqual(1, RomanNumber.Parse("I").Value, "Expected value for 'I' is 1.");
            Assert.AreEqual(5, RomanNumber.Parse("V").Value, "Expected value for 'V' is 5.");
            Assert.AreEqual(10, RomanNumber.Parse("X").Value, "Expected value for 'X' is 10.");
            Assert.AreEqual(50, RomanNumber.Parse("L").Value, "Expected value for 'L' is 50.");
            Assert.AreEqual(100, RomanNumber.Parse("C").Value, "Expected value for 'C' is 100.");
            Assert.AreEqual(500, RomanNumber.Parse("D").Value, "Expected value for 'D' is 500.");
            Assert.AreEqual(1000, RomanNumber.Parse("M").Value, "Expected value for 'M' is 1000.");
        }

        [TestMethod]
        public void ParseTest_ComplexRomanNumerals()
        {
            Assert.AreEqual(3, RomanNumber.Parse("III").Value, "Expected value for 'III' is 3.");
            Assert.AreEqual(4, RomanNumber.Parse("IV").Value, "Expected value for 'IV' is 4.");
            Assert.AreEqual(9, RomanNumber.Parse("IX").Value, "Expected value for 'IX' is 9.");
            Assert.AreEqual(58, RomanNumber.Parse("LVIII").Value, "Expected value for 'LVIII' is 58.");
            Assert.AreEqual(1994, RomanNumber.Parse("MCMXCIV").Value, "Expected value for 'MCMXCIV' is 1994.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ParseTest_InvalidCharacter_ThrowsException()
        {
            RomanNumber.Parse("A");
        }
    }
}

// Повторить основы управления програмными проектами.
// Заложить решение (solution) с двумя проектами (App, Test)
// Настроить заупуск тестов
// Реализовать парсер одночных цифр римский чисел, добавить тесты для них
// Формы сдачи:
// - архив с проектом и скриншотами работы
// - ссылка на репозиторий (в репозитории добавить папку со скриншотами
//     работы проекта или разместить их в README, позволяется приложить 
//     скришоты отдельных архивом к ДЗ)
