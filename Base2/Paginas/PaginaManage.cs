using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;



namespace Base2.Paginas
{
    class PaginaManage
    {

        public PaginaManage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "body > table.width75 > tbody > tr:nth-child(1) > td")]
        public IWebElement headerAthentication { get; set; }
    }
}
