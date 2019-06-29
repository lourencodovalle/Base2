

using Base2.Paginas;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace Base2.Testes
{
    public class TestePaginaBugReport
    {
        public TestePaginaBugReport()
        {
                
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Driver.InitializeDriver("https://mantis-prova.base2.com.br/login_page.php", 5);

        }

        [OneTimeSetUp]
        public void LoginValido()
        {
            PaginaLogin Login = new PaginaLogin();
            PaginaMyView view = new PaginaMyView();

            Login.CampoUsuario.SendKeys("lourenco.moreira");
            Login.CampoSenha.SendKeys("lomoreira");
            Login.BotaoLogin.Click();
            Thread.Sleep(1000);
            Assert.AreEqual(view.Menu.Enabled, true);
            
            view.MenuRportIssues.Click();

        }

        [Test]
        public void BotaoSelectProject()
        {
            PaginaBugReport bugRport = new PaginaBugReport();
            PaginaMyView view = new PaginaMyView();

            bugRport.botaoSelectProject.Click();
            Assert.AreEqual(bugRport.headerEnterReport.Enabled, true);
            Screenshot imagem = ((ITakesScreenshot)Driver.driver).GetScreenshot();
            imagem.SaveAsFile("C:\\Users\\loure\\Desktop\\Base2\\Base2\\Imagens\\BotaoSelectProject.png", ScreenshotImageFormat.Png);
            view.MenuRportIssues.Click();
        }

        [Test]
        public void CampoSummaryVazio()
        {
            PaginaBugReport bugRport = new PaginaBugReport();
            PaginaMyView view = new PaginaMyView();

            bugRport.botaoSubmit2.Click();
            Thread.Sleep(2000);
            Assert.AreEqual(bugRport.errorMessage11.Text, "A necessary field \"Summary\" was empty. Please recheck your inputs.");
            Screenshot imagem = ((ITakesScreenshot)Driver.driver).GetScreenshot();
            imagem.SaveAsFile("C:\\Users\\loure\\Desktop\\Base2\\Base2\\Imagens\\CampoSummaryVazio.png", ScreenshotImageFormat.Png);
            view.MenuRportIssues.Click();
        }

        [Test]
        public void CampoDescriptionVazio()
        {
            PaginaBugReport bugRport = new PaginaBugReport();
            PaginaMyView view = new PaginaMyView();


            bugRport.campoSummary.SendKeys("testes");
            bugRport.botaoSubmit2.Click();
            Thread.Sleep(2000);
            Assert.AreEqual(bugRport.errorMessage12.Text, "A necessary field \"Description\" was empty. Please recheck your inputs.");
            Screenshot imagem = ((ITakesScreenshot)Driver.driver).GetScreenshot();
            imagem.SaveAsFile("C:\\Users\\loure\\Desktop\\Base2\\Base2\\Imagens\\CampoDescriptionVazio.png", ScreenshotImageFormat.Png);
            view.MenuRportIssues.Click();
        }

        [Test]
        public void CampoCategoryVazio()
        {
            PaginaBugReport bugRport = new PaginaBugReport();
            PaginaMyView view = new PaginaMyView();


            bugRport.campoDescription.Clear();
            bugRport.campoSummary.Clear();
            bugRport.campoSummary.SendKeys("testes");
            bugRport.campoDescription.SendKeys("descrição");
            bugRport.botaoSubmit2.Click();
            Assert.AreEqual(bugRport.errorMessage13.Text, "A necessary field \"Category\" was empty. Please recheck your inputs.");
            Screenshot imagem = ((ITakesScreenshot)Driver.driver).GetScreenshot();
            imagem.SaveAsFile("C:\\Users\\loure\\Desktop\\Base2\\Base2\\Imagens\\CampoCategoryVazio.png", ScreenshotImageFormat.Png);
            view.MenuRportIssues.Click();
        }

        [Test]
        public void CampoCategoryPreenchido()
        {
            PaginaBugReport bugRport = new PaginaBugReport();
            PaginaMyView view = new PaginaMyView();

            bugRport.campoSummary.SendKeys("testes");
            bugRport.campoDescription.SendKeys("descrição");
            bugRport.selectBoxCategoria.SendKeys("[All Projects] 4rw3rw");

            bugRport.botaoSubmit2.Click();
            Assert.AreEqual(bugRport.operationSucessful.Text, "4rw3rw");
            Screenshot imagem = ((ITakesScreenshot)Driver.driver).GetScreenshot();
            imagem.SaveAsFile("C:\\Users\\loure\\Desktop\\Base2\\Base2\\Imagens\\CampoCategoryPreenchido.png", ScreenshotImageFormat.Png);
            view.MenuRportIssues.Click();
        }
       

    }
}
