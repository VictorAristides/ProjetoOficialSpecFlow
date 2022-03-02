using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Remote;

namespace ProjetoDeCadastroNivelBasico.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        
        public static IWebDriver driver;
        


        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public static void BeforeScenario()
        {
            
            driver = new FirefoxDriver();
            //driver = new FirefoxDriver(AppDomain.CurrentDomain.BaseDirectory);

            //TODO: implement logic that has to run before executing each scenario

        }

        [AfterScenario]
        public static void AfterScenario()
        {

            driver.Close();
            
        }
    }
}
