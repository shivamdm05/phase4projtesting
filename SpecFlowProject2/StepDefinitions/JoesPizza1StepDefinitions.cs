using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Collections.Generic;
using System.Linq;

namespace SpecFlowProject2.StepDefinitions
{
    [Binding]
    public class JoesPizza1StepDefinitions
    {
        private ChromeDriver chromedriver;

        public JoesPizza1StepDefinitions()
        {
            chromedriver = new ChromeDriver("C:\\Users\\shiva\\Downloads\\chromedriver_win32 (1)");
        }

        [Given(@"I have opened the website")]
        public void GivenIHaveOpenedTheWebsite()
        {
            chromedriver.Navigate().GoToUrl("https://phase4deploy.azurewebsites.net/");
        }

        [When(@"I click on Checkout button")]
        public void WhenIClickOnCheckoutButton()
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromMilliseconds(5000));
            IWebElement Checkout = chromedriver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[3]/a"));
            Thread.Sleep(3000);
            chromedriver.ExecuteScript("arguments[0].click();", Checkout);
        }

        [Then(@"It displays cart is empty message")]
        public void ThenItDisplaysCartIsEmptyMessage()
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromMilliseconds(5000));
        }

        [When(@"I click on pizza list")]
        public void WhenIClickOnPizzaList()
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromMilliseconds(5000));
            IWebElement pizzal = chromedriver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[1]/a"));
            Thread.Sleep(3000);
            chromedriver.ExecuteScript("arguments[0].click();", pizzal);
        }

        [Then(@"I get redirected to pizza list")]
        public void ThenIGetRedirectedToPizzaList()
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromMilliseconds(5000));
        }

        [When(@"I click on Add To Cart button to add pizza")]
        public void WhenIClickOnAddToCartButtonToAddPizza()
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromMilliseconds(5000));
            IWebElement Addtocart = chromedriver.FindElement(By.XPath("/html/body/div/main/div/div[1]/div/a"));
            Thread.Sleep(3000);
            chromedriver.ExecuteScript("arguments[0].click();", Addtocart);
        }

        [Then(@"I will be redirected to the cart")]
        public void ThenIWillBeRedirectedToTheCart()
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromMilliseconds(5000));
        }

        [When(@"I click on add more pizza")]
        public void WhenIClickOnAddMorePizza()
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromMilliseconds(5000));
            IWebElement Addtocart = chromedriver.FindElement(By.XPath("/html/body/div/main/div/h1/a"));
            Thread.Sleep(3000);
            chromedriver.ExecuteScript("arguments[0].click();", Addtocart);
        }

        [Then(@"I will get redirected to pizza list")]
        public void ThenIWillGetRedirectedToPizzaList()
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromMilliseconds(5000));
        }

        [When(@"I  add another pizza")]
        public void WhenIAddAnotherPizza()
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromMilliseconds(5000));
            IWebElement Addtocart = chromedriver.FindElement(By.XPath("/html/body/div/main/div/div[2]/div/a"));
            Thread.Sleep(3000);
            chromedriver.ExecuteScript("arguments[0].click();", Addtocart);
        }

        [Then(@"I get redirected towards the cart")]
        public void ThenIGetRedirectedTowardsTheCart()
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromMilliseconds(5000));
        }

        [When(@"I click on checkout")]
        public void WhenIClickOnCheckout()
        {

            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromMilliseconds(5000));
            IWebElement Addtocart = chromedriver.FindElement(By.XPath("/html/body/div/main/div/a"));
            Thread.Sleep(3000);
            chromedriver.ExecuteScript("arguments[0].click();", Addtocart);
        }

        [Then(@"Order confirmation page is opened")]
        public void ThenOrderConfirmationPageIsOpened()
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromMilliseconds(5000));
        }
    }
}
