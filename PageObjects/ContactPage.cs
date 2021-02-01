using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Text.RegularExpressions;

namespace teste_qa_monetizze.PageObjects {
    class ContactPage {

        private IWebDriver Driver;

        public ContactPage(IWebDriver driver) {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.Id, Using = "fname")]
        private IWebElement nome;

        [FindsBy(How = How.Id, Using = "lname")]
        private IWebElement sobrenome;

        [FindsBy(How = How.Id, Using = "eaddress")]
        private IWebElement email;

        [FindsBy(How = How.Id, Using = "tel")]
        private IWebElement tel;

        [FindsBy(How = How.Id, Using = "message")]
        private IWebElement mensagem;

        [FindsBy(How = How.CssSelector, Using = "body>div.site-wrap>div.site-section.bg-light>div>div>div>form>div:nth-child(4)>div>input")]
        private IWebElement botaoEnviar;

        public bool ValidarCarregamentoPaginaContato() {
            string nomeCampo = Driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div/div/div/div/h2")).Text.ToString().ToLower();
            return (nomeCampo.ToString().Equals("contato"));
        }

        public void PreencherFormulario(string nome = "", string sobrenome = "", string email = "", string tel = "", string mensagem = "") {
            this.nome.SendKeys(nome);
            this.sobrenome.SendKeys(sobrenome);
            this.email.SendKeys(email);
            this.tel.SendKeys(tel);
            this.mensagem.SendKeys(mensagem);
        }

        public void EnviarMensagem() {
            botaoEnviar.Click();
        }

        public void DigitarTextoNoCampoTelefone(string tel) {
            this.tel.SendKeys(tel);
            this.tel.SendKeys(Keys.Tab);
        }

        public bool VerificarSeHaTextoNoCampoTelefone() {
            string telefone = Driver.FindElement(By.Id("tel")).Text;
            Regex VerificarSeHaTexto = new Regex(@".[A-z]");

            if (VerificarSeHaTexto.IsMatch(telefone)) {
                return true;
            } else if (telefone == "") {
                return true;
            } else { return false; }
        }

    }
}

