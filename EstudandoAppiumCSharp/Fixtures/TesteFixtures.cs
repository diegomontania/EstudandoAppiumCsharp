using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;

namespace EstudandoAppiumCSharp.Fixtures
{
    //classe responsavel pelo setup antes da execução, 
    //e limpeza de recursos (teardown) dos testes
    public class TesteFixtures : IDisposable
    {
        public AndroidDriver<IWebElement> driver { get; set; }
        public AppiumOptions appiumOptions = new AppiumOptions();

        public TesteFixtures()
        {
            //setup - antes de iniciar o teste
            appiumOptions.AddAdditionalCapability("platformName", "Android");
            appiumOptions.AddAdditionalCapability("platformVersion", "5.0");
            appiumOptions.AddAdditionalCapability("deviceName", "meuCelular");
            appiumOptions.AddAdditionalCapability("automationName", "UiAutomator2");

            //app e main activity da aplicação
            appiumOptions.AddAdditionalCapability("appPackage", "com.android.calculator2");
            appiumOptions.AddAdditionalCapability("appActivity", ".Calculator");

            //não reseta aplicacao ao iniciar
            appiumOptions.AddAdditionalCapability("noReset", "true");

            driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), appiumOptions);
        }

        public void Dispose()
        {
            driver.Quit();
        }
    }
}
