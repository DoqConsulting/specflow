using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowApresentacao.Utils.Starts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowApresentacao.Navegacao.FormulariodeContato
{
    [Binding]
    public class Formulario
    {
        [Given(@"que eu esteja no site jobmidia")]
        public void DadoQueEuEstejaNoSiteJobmidia()
        {
            new GenericDriver().Wait.Until(web => web.Url = (ConfigurationManager.AppSettings["seleniumBaseUrl"]));
            Browser.Current.Manage().Window.Maximize();
        }
        [When(@"eu clicar no link contato")]
        public void QuandoEuClicarNoLinkContato()
        {
            new GenericDriver().Wait.Until(d => d.FindElement((By.Id("contatomenu")))).Click();
            Thread.Sleep(3000);
        }

        [When(@"para entrar em contato e necessario informar todos os dados obrigatorios do formulario: (.*),(.*),(.*),(.*)")]
        public void DadoParaEntrarEmContatoENecessarioInformarTodosOsDadosObrigatoriosDoFormularioFranklinfranklinjobHotmail_ComTesteDeMensagem(string p0, string p1, string p2, string p3)
        {
            new GenericDriver().Wait.Until(d => d.FindElement((By.Id("name")))).Click();
            new GenericDriver().Wait.Until(d => d.FindElement((By.Id("name")))).Clear();
            new GenericDriver().Wait.Until(d => d.FindElement((By.Id("name")))).SendKeys(p0);
            Thread.Sleep(1000);
            new GenericDriver().Wait.Until(d => d.FindElement((By.Id("email")))).Click();
            new GenericDriver().Wait.Until(d => d.FindElement((By.Id("email")))).Clear();
            new GenericDriver().Wait.Until(d => d.FindElement((By.Id("email")))).SendKeys(p1);
            Thread.Sleep(1000);
            new GenericDriver().Wait.Until(d => d.FindElement((By.Id("phone")))).Click();
            new GenericDriver().Wait.Until(d => d.FindElement((By.Id("phone")))).Clear();
            new GenericDriver().Wait.Until(d => d.FindElement((By.Id("phone")))).SendKeys(p2);
            Thread.Sleep(1000);
            new GenericDriver().Wait.Until(d => d.FindElement((By.Id("message")))).Click();
            new GenericDriver().Wait.Until(d => d.FindElement((By.Id("message")))).Clear();
            new GenericDriver().Wait.Until(d => d.FindElement((By.Id("message")))).SendKeys(p3);
            Thread.Sleep(1000);
        }

        [When(@"para entrar em contato e necessario informar todos os dados obrigatorios corretamente exceto email: (.*),(.*),(.*),(.*)")]
        public void QuandoParaEntrarEmContatoENecessarioInformarTodosOsDadosObrigatoriosCorretamenteExcetoEmailFranklinFranklinjob(string p0, string p1, string p2, string p3)
        {
            new GenericDriver().Wait.Until(d => d.FindElement((By.Id("name")))).Click();
            new GenericDriver().Wait.Until(d => d.FindElement((By.Id("name")))).Clear();
            new GenericDriver().Wait.Until(d => d.FindElement((By.Id("name")))).SendKeys(p0);
            Thread.Sleep(1000);
            new GenericDriver().Wait.Until(d => d.FindElement((By.Id("email")))).Click();
            new GenericDriver().Wait.Until(d => d.FindElement((By.Id("email")))).Clear();
            new GenericDriver().Wait.Until(d => d.FindElement((By.Id("email")))).SendKeys(p1);
            Thread.Sleep(1000);
            new GenericDriver().Wait.Until(d => d.FindElement((By.Id("phone")))).Click();
            new GenericDriver().Wait.Until(d => d.FindElement((By.Id("phone")))).Clear();
            new GenericDriver().Wait.Until(d => d.FindElement((By.Id("phone")))).SendKeys(p2);
            Thread.Sleep(1000);
            new GenericDriver().Wait.Until(d => d.FindElement((By.Id("message")))).Click();
            new GenericDriver().Wait.Until(d => d.FindElement((By.Id("message")))).Clear();
            new GenericDriver().Wait.Until(d => d.FindElement((By.Id("message")))).SendKeys(p3);

        }


        [Then(@"o formulario irá alertar o preenchimento incorreto do email '(.*)'")]
        public void EntaoOFormularioIraAlertarOPreenchimentoIncorretoDoEmail(string p0)
        {
            ResultadoEmailIncorreto(p0);

        }
            public static void ResultadoEmailIncorreto(string mensagemEsperada2)
        {
            var results = new GenericDriver().Wait.Until(d => d.FindElement((By.CssSelector("p.help-block.text-danger > ul > li"))));
            Assert.AreEqual(mensagemEsperada2, results.Text);
        }

        [Then(@"o site ira informar a mensagem '(.*)'")]
        public void EntaoOSiteIraInformarAMensagem(string p0)
        {
            ResultadoSucesso(p0);
        }
        public static void ResultadoSucesso(string mensagemEsperada)
        {
            var results = new GenericDriver().Wait.Until(d => d.FindElement((By.CssSelector("strong"))));
            Assert.AreEqual(mensagemEsperada, results.Text);

        }

        [When(@"eu clicar em Enviar")]
        public void QuandoEuClicarEmEnviar()
        {
            new GenericDriver().Wait.Until(d => d.FindElement((By.Id("enviarbotao")))).Click();
        }

    }
        //    {
        //    //var inicioTeste = DateTime.Now;
        //    //var tempoDesejado = inicioTeste.AddSeconds(20);
        //    //var results = GenericDriver.Wait.Until(d => d.FindElement((By.Id("success"))));

        //    //while (inicioTeste < tempoDesejado)
        //    //{

        //    //    if (p0.Equals(results.Text))
        //    //        break;
        //    //    else
        //    //        results = GenericDriver.Wait.Until(d => d.FindElement((By.Id("success"))));
        //    //    inicioTeste = DateTime.Now;
        //    //}
        //    Assert.IsTrue(GenericDriver.Wait.Until(d => d.FindElement((By.Id("success"))).Text.Contains(p0)));
        //    // Assert.IsTrue(p0, results.Text);
        //}

    }

