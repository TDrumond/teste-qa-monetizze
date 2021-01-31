using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using teste_qa_monetizze.PageObjects;

namespace teste_qa_monetizze.Tests {
    class ShopTest {
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

        public void ComprarUmVinho() {

            /*
              Clicar no Menu Loja ( XParth = //*[@id="sticky-wrapper"]/div/div/div/div/nav/ul/li[4]/a )
            Validar se a Página se possui o texto "Nossos Produtos" no elemento ( XPath: /html/body/div[1]/div[3]/div/div[1]/div/h2 )

            Aplicar o estado :hover no elemento ( XPath = /html/body/div[1]/div[3]/div/div[2]/div[1]/div/div[2] )
            
            Clicar no Botão Adicionar do primeiro vinho da lista ( XPath: /html/body/div[1]/div[3]/div/div[2]/div[1]/div/div[2]/a )
            Validar se a Página carregada possui o texto "Meu carrinho" no elemento ( /html/body/div[1]/div[3]/div/div[1]/div/h2 )



             */

        }



    }
}
