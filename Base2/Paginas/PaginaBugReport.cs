
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Base2.Paginas
{
    class PaginaBugReport
    {

        public PaginaBugReport()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "body > div:nth-child(5) > form > table > tbody > tr:nth-child(1) > td")]
        public IWebElement headerReportIssue { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div:nth-child(5) > form > table > tbody > tr:nth-child(16) > td.center > input")]
        public IWebElement botaoSubmit { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div:nth-child(5) > table > tbody > tr:nth-child(2) > td > p")]
        public IWebElement errorMessage11 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div:nth-child(5) > form > table > tbody > tr:nth-child(4) > td > input")]
        public IWebElement botaoSelectProject { get; set; }

        [FindsBy(How = How.Name, Using = "summary")]
        public IWebElement campoSummary { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div:nth-child(5) > table > tbody > tr:nth-child(2) > td > p")]
        public IWebElement errorMessage12 { get; set; }

        [FindsBy(How = How.Name, Using = "description")]
        public IWebElement campoDescription { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div:nth-child(5) > table > tbody > tr:nth-child(2) > td > p")]
        public IWebElement errorMessage13 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div:nth-child(7) > form > table > tbody > tr:nth-child(1) > td")]
        public IWebElement headerSelectProject { get; set; }

        [FindsBy(How = How.Name, Using = "category_id")]
        public IWebElement selectBoxCategoria { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#buglist > tbody > tr:nth-child(4) > td:nth-child(7)")]
        public IWebElement operationSucessful { get; set; }


        [FindsBy(How = How.CssSelector, Using = "body > div:nth-child(6) > form > table > tbody > tr:nth-child(16) > td.center > input")]
        public IWebElement botaoSubmit2 { get; set; }

        [FindsBy(How = How.ClassName, Using = "form-title")]
        public IWebElement headerEnterReport { get; set; }

        

    }
}
