

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Base2.Paginas
{
    class PaginaMyView
    {
        public PaginaMyView()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "body > table.width100 > tbody > tr > td:nth-child(1)")]
        public IWebElement Menu { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > table.width100 > tbody > tr > td:nth-child(1) > a:nth-child(1)")]
        public IWebElement MenuMyView { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > table.width100 > tbody > tr > td:nth-child(1) > a:nth-child(2)")]
        public IWebElement MenuViewIssues { get; set; }

        [FindsBy(How = How.CssSelector, Using = "  body > table.width100 > tbody > tr > td:nth-child(1) > a:nth-child(3)")]
        public IWebElement MenuRportIssues { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > table.width100 > tbody > tr > td:nth-child(1) > a:nth-child(4)")]
        public IWebElement MenuChangeLog { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > table.width100 > tbody > tr > td:nth-child(1) > a:nth-child(5)")]
        public IWebElement MenuRoadMap { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > table.width100 > tbody > tr > td:nth-child(1) > a:nth-child(6)")]
        public IWebElement MenuSumary { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > table.width100 > tbody > tr > td:nth-child(1) > a:nth-child(7)")]
        public IWebElement MenuManage { get; set; }





    }
}
