using Base2.Paginas;
using NUnit.Framework;
using OpenQA.Selenium;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Base2.Testes
{
    class TesteMenuPrincipal
    {
           

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
            

        }

        [Test]
        public void LinkMyView()
        {         
            PaginaMyView view = new PaginaMyView();
            view.MenuMyView.Click();
            Assert.AreEqual(view.Menu.Enabled, true);
            Screenshot imagem = ((ITakesScreenshot)Driver.driver).GetScreenshot();
            imagem.SaveAsFile("C:\\Users\\loure\\Desktop\\Base2\\Base2\\Imagens\\LinkMyView.png", ScreenshotImageFormat.Png);

        }


        [Test]
        public void LinkViewIssues()
        {
            PaginaMyView view = new PaginaMyView();
            ViewAllBugPage bugPage = new ViewAllBugPage();

            view.MenuViewIssues.Click();
            Assert.AreEqual(bugPage.headerViewIssues.Enabled, true);
            Screenshot imagem = ((ITakesScreenshot)Driver.driver).GetScreenshot();
            imagem.SaveAsFile("C:\\Users\\loure\\Desktop\\Base2\\Base2\\Imagens\\LinkViewIssues.png", ScreenshotImageFormat.Png);
        }


        [Test]
        public void LinkSummary()
        {
            PaginaMyView view = new PaginaMyView();
            PaginaSummary summary = new PaginaSummary();

            view.MenuSumary.Click();
            Assert.AreEqual(summary.headerSummary.Enabled, true);
            Screenshot imagem = ((ITakesScreenshot)Driver.driver).GetScreenshot();
            imagem.SaveAsFile("C:\\Users\\loure\\Desktop\\Base2\\Base2\\Imagens\\LinkSummary.png", ScreenshotImageFormat.Png);
        }


        [Test]
        public void LinkBugReport()
        {
            PaginaMyView view = new PaginaMyView();
            PaginaBugReport bugReport = new PaginaBugReport();
            
            view.MenuRportIssues.Click();
            Assert.AreEqual(bugReport.headerReportIssue.Enabled, true);
            Screenshot imagem = ((ITakesScreenshot)Driver.driver).GetScreenshot();
            imagem.SaveAsFile("C:\\Users\\loure\\Desktop\\Base2\\Base2\\Imagens\\LinkBugReport.png", ScreenshotImageFormat.Png);
        }


        [Test]
        public void LinkManage()
        {
            PaginaMyView view = new PaginaMyView();
            PaginaManage manage = new PaginaManage();

            view.MenuManage.Click();
            Assert.AreEqual(manage.headerAthentication.Enabled, true);
            Screenshot imagem = ((ITakesScreenshot)Driver.driver).GetScreenshot();
            imagem.SaveAsFile("C:\\Users\\loure\\Desktop\\Base2\\Base2\\Imagens\\LinkManage.png", ScreenshotImageFormat.Png);
        }

        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
