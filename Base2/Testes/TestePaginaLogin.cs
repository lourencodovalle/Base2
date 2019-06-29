﻿using OpenQA.Selenium;
using NUnit.Framework;
using System.Threading;
using Base2.Paginas;
using OpenQA.Selenium.Chrome;

namespace Base2.Testes
{
    public class TestePaginaLogin
    {

        public TestePaginaLogin()
        {

        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Driver.InitializeDriver("https://mantis-prova.base2.com.br/login_page.php", 5);
        }


        [Test]
        public void LoginCamposVazios()
        {
            PaginaLogin Login = new PaginaLogin();

            Login.BotaoLogin.Click();
            Thread.Sleep(1000);
            Assert.AreEqual(Login.MensagemErro.Text, "Your account may be disabled or blocked or the username/password you entered is incorrect.");
            Login.CampoUsuario.Clear();
        }

        [Test]
        public void LoginInvalidoSenhaVazio()
        {
            PaginaLogin Login = new PaginaLogin();

            Login.CampoUsuario.SendKeys("loginInvalido");
            Login.BotaoLogin.Click();
            Thread.Sleep(1000);
            Assert.AreEqual(Login.MensagemErro.Text, "Your account may be disabled or blocked or the username/password you entered is incorrect.");
            Login.CampoUsuario.Clear();
        }

        [Test]
        public void LoginInvalidoUsuarioVazio()
        {
            PaginaLogin Login = new PaginaLogin();

            Login.CampoSenha.SendKeys("loginInvalido");
            Login.BotaoLogin.Click();
            Thread.Sleep(1000);
            Assert.AreEqual(Login.MensagemErro.Text, "Your account may be disabled or blocked or the username/password you entered is incorrect.");
            Login.CampoSenha.Clear();
        }

        [Test]
        public void LinkPerdiMinhaSenha()
        {
            PaginaLogin Login = new PaginaLogin();
            PaginaPerdiMinhaSenha perdiSenha = new PaginaPerdiMinhaSenha();

            Login.LinkLostPassword.Click();
            Thread.Sleep(1000);
            Assert.AreEqual(perdiSenha.header.Text, "Password Reset");
            perdiSenha.LinkLogin.Click();
            
        }


        [Test]
        public void LoginValido()
        {
            PaginaLogin Login = new PaginaLogin();
            PaginaMyView view = new PaginaMyView();

            Login.CampoUsuario.SendKeys("lourenco.moreira");
            Login.CampoSenha.SendKeys("lomoreira");
            Login.BotaoLogin.Click();
            Thread.Sleep(1000);
            Assert.AreEqual(view.Menu.Enabled,true);
            
        }

        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}