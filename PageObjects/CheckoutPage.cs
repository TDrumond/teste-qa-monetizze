using OpenQA.Selenium;
using NUnit.Framework;

namespace teste_qa_monetizze.PageObjects {
    class CheckoutPage {

        private static IWebDriver Driver;

        public CheckoutPage(IWebDriver driver) {
            Driver = driver;
        }

        public void ValidarCarregamentoPaginaCheckout() {
            string tituloTopoPagina = Driver.FindElement(By.XPath("/html/body/div[1]/form/div/div/div/div[1]/h2")).Text.ToString().ToLower();
            Assert.IsTrue(tituloTopoPagina.ToString().Equals("detalhes da compra"), "Página de Detalhes da Compra não foi carregada!");
        }

        public void SelecionarPaisBrasil() {
            Driver.FindElement(By.XPath($"//*[@id=\"c_country\"]/option[4]")).Click();
        }

        public void PreencherNomeCliente(string nome, string sobrenome) {
            Driver.FindElement(By.Id("c_fname")).SendKeys(nome);
            Driver.FindElement(By.Id("c_lname")).SendKeys(sobrenome);
        }

        public void PreencherNomeEmpresa(string empresa) {
            Driver.FindElement(By.Id("c_companyname")).SendKeys(empresa);
        }

        public void PreencherEndereco(string endereco, string complemento, string estadoPais, string cep) {
            Driver.FindElement(By.Id("c_address")).SendKeys(endereco);
            Driver.FindElement(By.XPath("/html/body/div[1]/form/div/div/div/div[1]/div/div[5]/input")).SendKeys(complemento);
            Driver.FindElement(By.Id("c_state_country")).SendKeys(estadoPais);
            Driver.FindElement(By.Id("c_postal_zip")).SendKeys(cep);
        }

        public void PreencherContatos(string email, string telefone) {
            Driver.FindElement(By.Id("c_email_address")).SendKeys(email);
            Driver.FindElement(By.Id("c_phone")).SendKeys(telefone);
        }

        public void PreencherDetalhesAdicionais(string notes) {
            Driver.FindElement(By.Id("c_order_notes")).SendKeys(notes);
        }

        public void ClicarBtnFinalizarCompra() {
            Driver.FindElement(By.Id("btnSubmit")).Click();
        }

        public void ValidarCamposObrigatorios() {
            // Validar Campos Obrigatórios
            // Validar e colocar assert em cada um dos campos.
        }

    }
}
