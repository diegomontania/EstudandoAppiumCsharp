using EstudandoAppiumCSharp.Fixtures;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace EstudandoAppiumCSharp.PageObjects
{
    public class CalculadoraPO
    {
        private AppiumDriver<IWebElement> driver;

        public CalculadoraPO(AppiumDriver<IWebElement> driver)
        {
            this.driver = driver;
        }

        public void SomaDeNumerosInteiros(int valor1, int valor2)
        {
            Thread.Sleep(3000);
            driver.FindElementById($"com.android.calculator2:id/digit_{valor1}").Click();
            driver.FindElementByAccessibilityId("plus").Click();
            driver.FindElementById($"com.android.calculator2:id/digit_{valor2}").Click();
        }

        public void SubtracaoDeNumerosInteiros(int valor1, int valor2)
        {
            Thread.Sleep(3000);
            driver.FindElementById($"com.android.calculator2:id/digit_{valor1}").Click();
            driver.FindElementByAccessibilityId("minus").Click();
            driver.FindElementById($"com.android.calculator2:id/digit_{valor2}").Click();
        }

        public int RecebeResultadoCalculo()
        {
            Thread.Sleep(3000);
            var resultado = driver.FindElementById("com.android.calculator2:id/result").Text;
            LimpaCampoDeResultado();
            return Convert.ToInt32(resultado);
        }

        private void LimpaCampoDeResultado()
        {
            driver.FindElementByAccessibilityId("equals").Click();
            Thread.Sleep(2000);
            driver.FindElementByAccessibilityId("clear").Click();
        }
    }
}
