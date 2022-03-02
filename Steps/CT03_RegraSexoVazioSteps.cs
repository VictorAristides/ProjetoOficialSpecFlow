using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using ProjetoDeCadastroNivelBasico.Hooks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Remote;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using ProjetoDeCadastroNivelBasico.PageObjects;

namespace ProjetoDeCadastroNivelBasico.Steps
{
    [Binding]
    public class CT03RegraSexoVazioSteps
    {
        public IWebDriver driver = Hooks.Hooks.driver;
        Biblioteca biblioteca = new Biblioteca();

        [Given(@"preenche o sobrenome")]
        public void GivenPreencheOSobrenome()
        {
            biblioteca.CampoSobrenome("Aristides");
        }
        
        [Then(@"Erro Solicitando Sexo obrigatorio")]
        public void ThenErroSolicitandoSexoObrigatorio()
        {
            biblioteca.Alerta("Sexo eh obrigatorio");
        }
    }
}
