using NUnit.Framework;
using OpenQA.Selenium;
using ProjetoDeCadastroNivelBasico.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace ProjetoDeCadastroNivelBasico.Features
{
    [Binding]
    public class CT05_RegraEsporteSteps
    {
        public IWebDriver driver = Hooks.Hooks.driver;
        Biblioteca biblioteca = new Biblioteca();

        [Given(@"Seleciona Comida Favorita Carne")]
        public void GivenSelecionaComidaFavoritaCarne()
        {
            biblioteca.FlagComidaCarne();
        }
        
        [Given(@"Seleciona a opção Natação")]
        public void GivenSelecionaAOpcaoNatacao()
        {
            biblioteca.EsporteNatacao();
        }
        
        [Then(@"Deve ser exibida a mensagem ""(.*)""")]
        public void ThenDeveSerExibidaAMensagem(string p0)
        {
            Assert.AreEqual("Cadastrado!", biblioteca.ObterResultadoCadastro());
        }
    }
}
