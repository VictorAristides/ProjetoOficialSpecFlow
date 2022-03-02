using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
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
    public class CT02_RegraSobreNomeVazioSteps
    {
        public IWebDriver driver = Hooks.Hooks.driver;
        Biblioteca biblioteca = new Biblioteca();

        [Given(@"Preenche Nome do cadastro")]
        public void GivenPreencheNomeDoCadastro()
        {
            biblioteca.CampoNome("Raphael");
        }
        
        [Then(@"Erro Solicitando SobreNome Obrigatorio")]
        public void ThenErroSolicitandoSobreNomeObrigatorio()
        {
            biblioteca.Alerta("Sobrenome eh obrigatorio");
        }
    }
}
