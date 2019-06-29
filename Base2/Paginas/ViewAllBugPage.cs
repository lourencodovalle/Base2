using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Base2.Paginas
{
    class ViewAllBugPage
    {

        public ViewAllBugPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#buglist > tbody > tr:nth-child(1) > td > span:nth-child(1)")]
        public IWebElement headerViewIssues { get; set; }


        
        


    }
}
