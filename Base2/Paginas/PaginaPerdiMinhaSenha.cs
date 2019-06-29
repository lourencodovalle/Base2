using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base2.Paginas
{
    class PaginaPerdiMinhaSenha
    {

        public PaginaPerdiMinhaSenha()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "body > div:nth-child(4) > form > table > tbody > tr:nth-child(1) > td")]
        public IWebElement header { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div:nth-child(6) > span > a")]
        public IWebElement LinkLogin { get; set; }

        


    }
}
