using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_qa_monetizze.PageObjects {
    class ShopSinglePage {
        private static IWebDriver Driver;

        public ShopSinglePage(IWebDriver driver) {
            Driver = driver;
        }

        public void ValidarCarregamentoPaginaDetalhesProduto() {
            string tituloNaPagina = Driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div/div/div[2]/h2")).Text.ToString().ToLower();
            Assert.IsTrue(tituloNaPagina.ToString().Equals("detalhes"), "Página de Detalhes do Produto não foi carregada!");
        }

        public void AdicionarUmaUnidadeDoProduto() {
            Driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div/div/div[2]/div/div/div[2]/button")).Click();
        }
        public void CkicarBtnComprar() {
            Driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div/div/div[2]/p[2]/a")).Click();
        }
    }
}
