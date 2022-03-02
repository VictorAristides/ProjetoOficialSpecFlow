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
    public class CT04RegraVeganoSteps
    {
        public IWebDriver driver = Hooks.Hooks.driver;
        Biblioteca biblioteca = new Biblioteca();

        [Given(@"Seleciona o Sexo Masculino")]
        public void GivenSelecionaOSexoMasculino()
        {
            biblioteca.SexoMasculino();
        }
        
        [Given(@"Seleciona Carne e Vegetariano")]
        public void GivenSelecionaCarneEVegetariano()
        {
            biblioteca.FlagComidaCarne();
            biblioteca.FlagComidaVegetariano();
        }
        
        [Then(@"Deve exibir a mensagem ""(.*)""")]
        public void ThenDeveExibirAMensagem(string p0)
        {
            biblioteca.Alerta("Tem certeza que voce eh vegetariano?");
        }
    }
}
