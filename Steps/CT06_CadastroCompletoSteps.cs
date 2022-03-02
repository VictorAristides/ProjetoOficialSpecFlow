using NUnit.Framework;
using OpenQA.Selenium;
using ProjetoDeCadastroNivelBasico.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace ProjetoDeCadastroNivelBasico.Steps
{
    [Binding]
    public class CT06_CadastroCompletoSteps
    {
        public IWebDriver driver = Hooks.Hooks.driver;
        Biblioteca biblioteca = new Biblioteca();


        [Given(@"Seleciona Escolaridade Mestrado")]
        public void GivenSelecionaEscolaridadeMestrado()
        {
            biblioteca.Mestrado();
        }
        
        [Then(@"Deve ser exibida a Mensagem ""(.*)"" e Validar os demais campos")]
        public void ThenDeveSerExibidaAMensagemEValidarOsDemaisCampos(string p0)
        {
            Assert.AreEqual("Cadastrado!", biblioteca.ObterResultadoCadastro());
            Assert.AreEqual("Raphael", biblioteca.ObterResultadoNome());
            Assert.AreEqual("Aristides", biblioteca.ObterResultadoSobreNome());
            Assert.AreEqual("mestrado", biblioteca.ObterResultadoEscolaridade());
            Assert.AreEqual("Carne", biblioteca.ObterResultadoComidas());
            Assert.AreEqual("Natacao", biblioteca.ObterResultadoEsportes());

        }
    }
}
