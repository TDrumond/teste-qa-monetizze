using OpenQA.Selenium;
using NUnit.Framework;

namespace teste_qa_monetizze.PageObjects {
    class CartPage {

        private static IWebDriver Driver;

        public CartPage(IWebDriver driver) {
            Driver = driver;
        }

        public void ValidarCarregamentoPaginaCarrinho() {
            string tituloTopoPagina = Driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[1]/div/h2")).Text.ToString().ToLower();
            Assert.IsTrue(tituloTopoPagina.ToString().Equals("meu carrinho"), "Página do Carrinho de Compras não foi carregada!");
        }

        public void RemoverItemCarrinho() {
            string nomePrimeiroElementoLista = Driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/form/div/table/tbody/tr[1]/td[2]/h2")).Text;
            Driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/form/div/table/tbody/tr[1]/td[6]/a")).Click();
            string nomePrimeiroElementoListaAposExclusao = Driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/form/div/table/tbody/tr[1]/td[2]/h2")).Text;
            Assert.IsTrue(nomePrimeiroElementoLista.Equals(nomePrimeiroElementoListaAposExclusao));
        }

        public void AumentarQuantidadePrimeiroItemListaCarrinho() {
            Driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/form/div/table/tbody/tr[1]/td[4]/div/div[2]/button")).Click();
        }

        public void ClicarBtnProsseguirNaPaginaCarrinho() {
            Driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div/div/div[2]/div/div/div[4]/div/button")).Click();
        }
    }
}
