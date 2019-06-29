using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Base2.Paginas
{
    class PaginaSummary
    {
        public PaginaSummary()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "body > table:nth-child(8) > tbody > tr:nth-child(1) > td")]
        public IWebElement headerSummary { get; set; }

        

        


    }
}
