using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace teste_qa_monetizze.PageObjects {
    class HomePage {

        private IWebDriver Driver;

        public HomePage(IWebDriver driver) {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#sticky-wrapper>div>div>div>div>nav>ul>li:nth-child(5)>a")]
        private IWebElement PaginaContato;

        [FindsBy(How = How.CssSelector, Using = "#sticky-wrapper>div>div>div>div>nav>ul>li:nth-child(4)>a")]
        private IWebElement PaginaLoja;

        public void AbrirPaginaInicial() {
            Driver.Navigate().GoToUrl("http://monetizzetesteqa.s3-website-us-east-1.amazonaws.com/");
        }

        public ContactPage IrParaPaginaDeContato() {
            PaginaContato.Click();
            return new ContactPage(Driver);
        }
    }
}
