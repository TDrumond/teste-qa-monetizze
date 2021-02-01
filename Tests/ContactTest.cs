using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using teste_qa_monetizze.PageObjects;

namespace teste_qa_monetizze.Tests {
    public class ContatoTest {
        private IWebDriver driver;

        [SetUp]
        public void SetUp() {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown() {
            driver.Close();
        }

        [Test]
        public void PresencaDeCamposPaginaContato() {

            HomePage paginaInicial = new HomePage(driver);
            paginaInicial.AbrirPaginaInicial();
            paginaInicial.IrParaPaginaDeContato();
            ContactPage paginaContato = new ContactPage(driver);

            Assert.IsTrue(paginaContato.ValidarCarregamentoPaginaContato());
        }

        [Test]
        public void CampoTelefoneAceitaTexto() {

            HomePage paginaInicial = new HomePage(driver);
            paginaInicial.AbrirPaginaInicial();
            paginaInicial.IrParaPaginaDeContato();
            ContactPage paginaContato = new ContactPage(driver);
            paginaContato.DigitarTextoNoCampoTelefone("31912341234");

            Assert.IsFalse(paginaContato.VerificarSeHaTextoNoCampoTelefone(),"Campo telefone com dado inválido ou vazio");
        }

        [Test]
        public void EnviarMensagemPelaPaginaContato() {

            HomePage paginaInicial = new HomePage(driver);
            paginaInicial.AbrirPaginaInicial();
            paginaInicial.IrParaPaginaDeContato();
            ContactPage paginaContato = new ContactPage(driver);
            paginaContato.PreencherFormulario("Thiago", "Drumond", "testes@teste.com", "31912341234", "Testes de Mensagem enviada pelo SE");
            paginaContato.EnviarMensagem();
            ThankYouPage paginaAgradecimento = new ThankYouPage(driver);

            paginaAgradecimento.ValidarCarregamentoPaginaThankYou();
        }

    }
}
