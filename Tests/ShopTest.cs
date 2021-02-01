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
        public void ComprarDuasUnidades() {
            HomePage paginaInicial = new HomePage(driver);
            paginaInicial.AbrirPaginaInicial();
            paginaInicial.IrParaPaginaDeLoja();
            ShopPage paginaLoja = new ShopPage(driver);
            paginaLoja.ValidarCarregamentoPaginaLoja();
            paginaLoja.VisualizarDetalheProduto();
            ShopSinglePage paginaDetalhesProduto = new ShopSinglePage(driver);
            paginaDetalhesProduto.ValidarCarregamentoPaginaDetalhesProduto();
            paginaDetalhesProduto.AdicionarUmaUnidadeDoProduto();
            paginaDetalhesProduto.CkicarBtnComprar();
            CartPage paginaCarrinho = new CartPage(driver);
            paginaCarrinho.ValidarCarregamentoPaginaCarrinho();
            paginaCarrinho.AumentarQuantidadePrimeiroItemListaCarrinho();
            paginaCarrinho.ClicarBtnProsseguirNaPaginaCarrinho();
            CheckoutPage paginaDetalheCompra = new CheckoutPage(driver);
            paginaDetalheCompra.ValidarCarregamentoPaginaCheckout();
            paginaDetalheCompra.SelecionarPaisBrasil();
            paginaDetalheCompra.PreencherNomeCliente("Nome", "Sobrenome Cliente Teste");
            paginaDetalheCompra.PreencherEndereco("Rua 1", "386 casa A", "MG", "31100-200");
            paginaDetalheCompra.PreencherContatoTelefone("(31)3333-3333");
            paginaDetalheCompra.PreencherContatoEmail("teste@teste.com.br");
            paginaDetalheCompra.PreencherDetalhesAdicionais("Aqui se ficam detalhes adicionais da compra");
            paginaDetalheCompra.PreencherNomeEmpresa("Nome da Empresa");
            paginaDetalheCompra.ClicarBtnFinalizarCompra();
            ThankYouPage paginaAgradecimento = new ThankYouPage(driver);
            paginaAgradecimento.ValidarCarregamentoPaginaThankYou();
        }

        [Test]
        public void ValidarCamposObrigatorios() {
            HomePage paginaInicial = new HomePage(driver);
            paginaInicial.AbrirPaginaInicial();
            ShopPage paginaLoja = paginaInicial.IrParaPaginaDeLoja();
            paginaLoja.ValidarCarregamentoPaginaLoja();
            paginaLoja.VisualizarDetalheProduto();
            ShopSinglePage paginaDetalhesProduto = new ShopSinglePage(driver);
            paginaDetalhesProduto.AdicionarUmaUnidadeDoProduto();
            paginaDetalhesProduto.CkicarBtnComprar();
            CartPage paginaCarrinho = new CartPage(driver);
            paginaCarrinho.ValidarCarregamentoPaginaCarrinho();
            paginaCarrinho.ClicarBtnProsseguirNaPaginaCarrinho();
            CheckoutPage paginaDetalheCompra = new CheckoutPage(driver);
            paginaDetalheCompra.ValidarCarregamentoPaginaCheckout();

            paginaDetalheCompra.ValidarCamposObrigatoriosPaginaDetalhesCompra();
        }

        [Test]
        public void ExcluirItemCarrinho() {

            HomePage paginaInicial = new HomePage(driver);
            paginaInicial.AbrirPaginaInicial();
            paginaInicial.IrParaPaginaDeLoja();
            ShopPage paginaLoja = new ShopPage(driver);
            paginaLoja.ValidarCarregamentoPaginaLoja();
            paginaLoja.VisualizarDetalheProduto();
            ShopSinglePage paginaDetalhesProduto = new ShopSinglePage(driver);
            paginaDetalhesProduto.ValidarCarregamentoPaginaDetalhesProduto();
            paginaDetalhesProduto.AdicionarUmaUnidadeDoProduto();
            paginaDetalhesProduto.CkicarBtnComprar();
            CartPage paginaCarrinho = new CartPage(driver);
            paginaCarrinho.ValidarCarregamentoPaginaCarrinho();
            paginaCarrinho.RemoverItemCarrinho();
        }

        [Test]
        [TestCase("31993432242")]
        [TestCase("ABC")]
        public void ValidarCampoTelefoneTelaCheckout(string telefone) {
            HomePage paginaInicial = new HomePage(driver);
            paginaInicial.AbrirPaginaInicial();
            paginaInicial.IrParaPaginaDeLoja();
            ShopPage paginaLoja = new ShopPage(driver);
            paginaLoja.ValidarCarregamentoPaginaLoja();
            paginaLoja.VisualizarDetalheProduto();
            ShopSinglePage paginaDetalhesProduto = new ShopSinglePage(driver);
            paginaDetalhesProduto.ValidarCarregamentoPaginaDetalhesProduto();
            paginaDetalhesProduto.AdicionarUmaUnidadeDoProduto();
            paginaDetalhesProduto.CkicarBtnComprar();
            CartPage paginaCarrinho = new CartPage(driver);
            paginaCarrinho.ValidarCarregamentoPaginaCarrinho();
            paginaCarrinho.AumentarQuantidadePrimeiroItemListaCarrinho();
            paginaCarrinho.ClicarBtnProsseguirNaPaginaCarrinho();
            CheckoutPage paginaDetalheCompra = new CheckoutPage(driver);
            paginaDetalheCompra.ValidarCarregamentoPaginaCheckout();
            paginaDetalheCompra.PreencherContatoTelefone(telefone);
            Assert.IsFalse(paginaDetalheCompra.VerificarSeHaTextoNoCampoTelefone());

        }
    }
}
