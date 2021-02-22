O codigo de Testes foi elaborado em C# .net

A Execução deste Projeto depende dos seguintes pacotes NuGet:
 - Selenium.WebDriver na versão 3.141.0 
 - Selenium.Support na versão 3.141.0 (precisa ser a mesma versão do Selenium WebDriver)
 - Selenium.Webdriver.ChromeDriver (A mesma versão do Browser instalado na Máquina,aqui foi usado a versão 88.0.4324.9600)
 - NUnit na versão 3.13
 - NUnit3Adapter na versão 3.17

Todos já incorporados no Projeto. Caso algum dos pacotes apresente açertas ou erros, é necessário que os mesmos sejam restaurados.
Basta clicar com o botão de Menu de contexto do mouse( normalmente o botão direito do mouse) sobre a solução exibida na janela "Gerenciador de Soluções", e escolher a opção "Restaurar pacotes NuGet".

Para a execução dos testes, basta abrir o painel "Gerenciador de Testes" (Exibir > Gerenciador de Teste).
Neste painel será exibido todos os testes disponíveis na solução. Pode ser executado um a um, atraves da opção "Executar" no menu de contexto do teste. ou executar todos os testes através do botão presente no topo deste painel.

O Visual Studio apresenta os resultados de forma individualizada dos teste. Basta Clicar em cada um dos testes que ele mostrará o registro do teste.

### Considerações:

 - Procurei realizar algumas variações durante o código pra poder melhor mostrar minhas capacidades.
 - Utilizei o modelo PageObjects, para o projeto.
 - Na classe referente a página de contatos, utilizei o Page Factory, que mesmo tendo se tornado obsoleto, muitos projetos ainda adotam esta forma de trabalhar.
 - No método de validação de números de telefone, utilizei um recursos do NUnit que me permite variar dados de entrada para um medmo teste.
 - Para uma melhor leitura, criei os métodos referentes aos passos de testes com nomes mais intuitivos, e realizei os asserts através de métodos, com exceção nos testes do número de telefone digitado, ao qual deixei o assert no final do script de modo a mostrar que também o sei fazer desta forma.
 - Utilizei expressão regular para validar o número do telefone, pois creio que seja uma forma simples e eficiente.
