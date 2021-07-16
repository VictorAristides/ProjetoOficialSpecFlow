using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using ProjectSpecflow.Hooks;

namespace ProjectSpecflow.PageObjects
{
    class Biblioteca
    {
        public IWebDriver driver;
        private By BotaoCadastrar = By.Id("elementosForm:cadastrar");

        public Biblioteca()
        {
            driver = Hooks.Hooks.driver;
        }
        public void BtnCadastrar()
        {
            driver.FindElement(BotaoCadastrar).Click();
        }


        public string ObterAlerta()
        {

            return driver.SwitchTo().Alert().Text;
        }

        public void Alerta(string textoaviso)
        {
            Assert.AreEqual(textoaviso, ObterAlerta());

        }

    }
}
