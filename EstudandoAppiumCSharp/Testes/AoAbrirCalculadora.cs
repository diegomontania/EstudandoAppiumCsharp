using EstudandoAppiumCSharp.Fixtures;
using EstudandoAppiumCSharp.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using System;
using Xunit;

namespace EstudandoAppiumCSharp
{
    [Collection ("ActorAppiumDriver")]
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
            calculadora.SomaDeNumerosInteiro(5, 9);

            //assert
            var resultadoCalculo = calculadora.RecebeResultadoCalculo();
            Assert.Equal("14", resultadoCalculo);
        }

        [Fact]
        public void DadoASubtracaoDeDoisNumeros()
        {
            //arrange
            var calculadora = new CalculadoraPO(driver);

            //act
            calculadora.SubtracaoDeNumerosInteiro(9, 5);

            //assert
            var resultadoCalculo = calculadora.RecebeResultadoCalculo();
            Assert.Equal("4", resultadoCalculo);
        }
    }
}
