using EstudandoAppiumCSharp.Fixtures;
using EstudandoAppiumCSharp.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using Xunit;

namespace EstudandoAppiumCSharp
{
    [Collection ("AppiumDriver")]
    public class AoAbrirCalculadora
    {
        private AndroidDriver<IWebElement> driver { get; set; }

        public AoAbrirCalculadora(TesteFixtures fixtures)
        {
            this.driver = fixtures.driver;
        }

        [Fact]
        public void DadoASomaDeDoisNumeros()
        {
            //arrange
            var calculadora = new CalculadoraPO(driver);

            //act
            calculadora.SomaDeNumerosInteiros(5, 9);

            //assert
            var resultadoCalculo = calculadora.RecebeResultadoCalculo();
            Assert.Equal(14, resultadoCalculo);
        }

        [Fact]
        public void DadoASubtracaoDeDoisNumeros()
        {
            //arrange
            var calculadora = new CalculadoraPO(driver);

            //act
            calculadora.SubtracaoDeNumerosInteiros(9, 5);

            //assert
            var resultadoCalculo = calculadora.RecebeResultadoCalculo();
            Assert.Equal(4, resultadoCalculo);
        }
    }
}
