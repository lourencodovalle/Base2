using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base2.Paginas
{
    public class PaginaLogin
    {

        public PaginaLogin()
        {
            PageFactory.InitElements(Driver.driver, this);
        }


        [FindsBy(How = How.Name, Using = "username")]
        public IWebElement CampoUsuario { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement CampoSenha { get; set; }

        [FindsBy(How = How.ClassName, Using = "button")]
        public IWebElement BotaoLogin { get; set; }

        [FindsBy(How = How.Name, Using = "secure_session")]
        public IWebElement RadioSecure { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div:nth-child(3)")]
        public IWebElement MensagemErro { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div:nth-child(7) > span > a")]
        public IWebElement LinkLostPassword { get; set; }

        
    }
}
