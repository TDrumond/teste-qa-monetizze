using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace teste_qa_monetizze.PageObjects {
    class ThankYouPage {
        private IWebDriver Driver;

        public ThankYouPage(IWebDriver driver) {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[3]/div/div/div/h2")]
        private IWebElement Agradecimento;

        public bool ValidarAgradecimento() {
            try {
                string obrigado = Driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/div/h2")).Text.ToString().ToLower();
                return(obrigado.ToString().Equals("obrigado"));

            } catch (Exception e) {
                throw new AssertionException("A Página de agradecimento não foi carregada.");
            }
        }
    }
}
