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
Neste painel será exibido todos os testes disponíveis na solução. Pode ser executado um a um, atraves da opção "Executar" no menu de contexto do teste. ou executar todos os testes atravez do botão presente no topo deste painel.

O Visual Studio apresenta os resultados de forma individualizada dos teste. Basta Clicar em cada um dos testes que ele mostrará o registro do teste.
