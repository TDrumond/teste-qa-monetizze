using OpenQA.Selenium;
using NUnit.Framework;

namespace teste_qa_monetizze.PageObjects {
    class ShopPage {

        private static IWebDriver Driver;

        public ShopPage(IWebDriver driver) {
            Driver = driver;
        }

        public void ValidarCarregamentoPaginaLoja() {
            string tituloTopoPagina = Driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[1]/div/h2")).Text.ToString().ToLower();
            Assert.IsTrue(tituloTopoPagina.ToString().Equals("nossos produtos"), "Página de Loja não foi carregada!");
        }

        public void VisualizarDetalheProduto() {
            Driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div[1]/div/a")).Click();
        }


    }
}
