using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using ProjectSpecflow.Hooks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Remote;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using ProjectSpecflow.PageObjects;




namespace ProjectSpecflow.Steps
{
    

    [Binding]
    public class CT01_CadastroSemNomeSteps
    {
        public IWebDriver driver = Hooks.Hooks.driver;
        Biblioteca biblioteca = new Biblioteca();

        [Given(@"usuario acessa paginaprincipal")]
        public void GivenUsuarioAcessaPaginaprincipal()
        {
            driver.Navigate().GoToUrl("http://wcaquino.me/selenium/componentes.html");
        }
        
        [When(@"Clicar no botao cadastrar")]
        public void WhenClicarNoBotaoCadastrar()
        {
            biblioteca.BtnCadastrar();
        }
        
        [Then(@"Erro Solicitando Nome Obrigatorio")]
        public void ThenErroSolicitandoNomeObrigatorio()
        {
            biblioteca.Alerta("Nome eh obrigatorio");
        }
    }
}
