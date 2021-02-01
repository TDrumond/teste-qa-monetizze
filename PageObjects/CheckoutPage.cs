using OpenQA.Selenium;
using NUnit.Framework;
using System.Text.RegularExpressions;

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

        public void PreencherEndereco(string rua, string numero, string estadoPais, string cep) {
            Driver.FindElement(By.Id("c_address")).SendKeys(rua);
            Driver.FindElement(By.XPath("/html/body/div[1]/form/div/div/div/div[1]/div/div[5]/input")).SendKeys(numero);
            Driver.FindElement(By.Id("c_state_country")).SendKeys(estadoPais);
            Driver.FindElement(By.Id("c_postal_zip")).SendKeys(cep);
        }

        public void PreencherContatoTelefone( string telefone) {
            Driver.FindElement(By.Id("c_phone")).SendKeys(telefone);

        }public void PreencherContatoEmail(string email) {
            Driver.FindElement(By.Id("c_email_address")).SendKeys(email);
        }

        public void PreencherDetalhesAdicionais(string notes) {
            Driver.FindElement(By.Id("c_order_notes")).SendKeys(notes);
        }

        public void ClicarBtnFinalizarCompra() {
            Driver.FindElement(By.Id("btnSubmit")).Click();
        }

        public void ValidarCamposObrigatoriosPaginaDetalhesCompra() {
            StringAssert.IsMatch("true", (Driver.FindElement(By.Id("c_fname")).GetAttribute("required")), "Campo Nome não está como Obrigatório");
            StringAssert.IsMatch("true", (Driver.FindElement(By.Id("c_lname")).GetAttribute("required")), "Campo Sobrenome não está como Obrigatório");
            StringAssert.IsMatch("true", (Driver.FindElement(By.Id("c_address")).GetAttribute("required")), "Campo Endereço não está como Obrigatório");
            StringAssert.IsMatch("true", (Driver.FindElement(By.Id("c_state_country")).GetAttribute("required")), "Campo Estado não está como Obrigatório");
            StringAssert.IsMatch("true", (Driver.FindElement(By.Id("c_postal_zip")).GetAttribute("required")), "Campo CEP não está como Obrigatório");
            StringAssert.IsMatch("true", (Driver.FindElement(By.Id("c_email_address")).GetAttribute("required")), "Campo E-Mail não está como Obrigatório");
            StringAssert.IsMatch("true", (Driver.FindElement(By.Id("c_phone")).GetAttribute("required")), "Campo Telefone não está como Obrigatório");
            StringAssert.IsMatch("true", (Driver.FindElement(By.XPath($"//*[@id=\"c_country\"]/option[4]")).GetAttribute("required")), "Campo País não está como Obrigatório");
        }

        public bool VerificarSeHaTextoNoCampoTelefone() {
            //string telefone = Driver.FindElement(By.Id("c_phone")).Text;
            string telefone = Driver.FindElement(By.Id("c_phone")).GetAttribute("value");
            Regex VerificarSeHaTexto = new Regex(@".[A-z]");

            if (VerificarSeHaTexto.IsMatch(telefone)) {
                return true;
            } else if (telefone == "") {
                return true;
            } else { return false; }
        }
    }
}
