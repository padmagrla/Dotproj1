﻿using Automation.Framework.ComponentHelper;
using Automation.Framework.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
namespace Automation.Framework.Base
{
    public class BasePage
    {
        public Helpers Helper = new Helpers();
        private static IWebElement _webElement;
       
        public BasePage(IWebDriver driver)
        {
            Driver.Browser = driver;
        }

        public static IWebElement WaitTillElementExist(string locator, ElementLocator elementLocatorType = ElementLocator.Xpath, int TimeOutForFindingElement = 10)
        {
            var wait = new WebDriverWait(Driver.Browser, TimeSpan.FromSeconds(TimeOutForFindingElement));

            if (elementLocatorType == ElementLocator.Xpath)
            {
                _webElement = wait.Until(ExpectedConditions.ElementExists(By.XPath(locator)));
            }
            else if (elementLocatorType == ElementLocator.PartialLinkText)
            {
                _webElement = wait.Until(ExpectedConditions.ElementExists(By.PartialLinkText(locator)));
            }
            else if (elementLocatorType == ElementLocator.Name)
            {
                _webElement = wait.Until(ExpectedConditions.ElementExists(By.Name(locator)));
            }
            else if (elementLocatorType == ElementLocator.LinkText)
            {
                _webElement = wait.Until(ExpectedConditions.ElementExists(By.LinkText(locator)));
            }
            else if (elementLocatorType == ElementLocator.ID)
            {
                _webElement = wait.Until(ExpectedConditions.ElementExists(By.Id(locator)));
            }
            else if (elementLocatorType == ElementLocator.CssSelector)
            {
                _webElement = wait.Until(ExpectedConditions.ElementExists(By.CssSelector(locator)));
            }
            else if (elementLocatorType == ElementLocator.TagName)
            {
                _webElement = wait.Until(ExpectedConditions.ElementExists(By.TagName(locator)));
            }
            else if (elementLocatorType == ElementLocator.ClassName)
            {
                _webElement = wait.Until(ExpectedConditions.ElementExists(By.ClassName(locator)));
            }

            return _webElement;
        }

        public static IWebElement WaitTillElementDisplayed(string locator, ElementLocator elementLocatorType = ElementLocator.Xpath, int TimeOutForFindingElement = 10)
        {

            var wait = new WebDriverWait(Driver.Browser, TimeSpan.FromSeconds(TimeOutForFindingElement));

            if (elementLocatorType == ElementLocator.Xpath)
            {
                _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
            }
            else if (elementLocatorType == ElementLocator.PartialLinkText)
            {
                _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(locator)));
            }
            else if (elementLocatorType == ElementLocator.Name)
            {
                _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.Name(locator)));
            }
            else if (elementLocatorType == ElementLocator.LinkText)
            {
                _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(locator)));
            }
            else if (elementLocatorType == ElementLocator.ID)
            {
                _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(locator)));
            }
            else if (elementLocatorType == ElementLocator.CssSelector)
            {
                _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(locator)));
            }
            else if (elementLocatorType == ElementLocator.TagName)
            {
                _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.TagName(locator)));
            }
            else if (elementLocatorType == ElementLocator.ClassName)
            {
                _webElement = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(locator)));
            }

            return _webElement;
        }

        public static void WaitTillElementStalenessOf(string locator, ElementLocator elementLocatorType = ElementLocator.Xpath, int TimeOutForFindingElement = 10)
        {
            var wait = new WebDriverWait(Driver.Browser, TimeSpan.FromSeconds(TimeOutForFindingElement));

            if (elementLocatorType == ElementLocator.Xpath)
            {
                wait.Until(ExpectedConditions.StalenessOf(Driver.Browser.FindElement(By.XPath(locator))));
            }
            else if (elementLocatorType == ElementLocator.PartialLinkText)
            {
                wait.Until(ExpectedConditions.StalenessOf(Driver.Browser.FindElement(By.PartialLinkText(locator))));
            }
            else if (elementLocatorType == ElementLocator.Name)
            {
                wait.Until(ExpectedConditions.StalenessOf(Driver.Browser.FindElement(By.Name(locator))));
            }
            else if (elementLocatorType == ElementLocator.LinkText)
            {
                wait.Until(ExpectedConditions.StalenessOf(Driver.Browser.FindElement(By.LinkText(locator))));
            }
            else if (elementLocatorType == ElementLocator.ID)
            {
                wait.Until(ExpectedConditions.StalenessOf(Driver.Browser.FindElement(By.Id(locator))));
            }
            else if (elementLocatorType == ElementLocator.CssSelector)
            {
                wait.Until(ExpectedConditions.StalenessOf(Driver.Browser.FindElement(By.CssSelector(locator))));
            }
            else if (elementLocatorType == ElementLocator.TagName)
            {
                wait.Until(ExpectedConditions.StalenessOf(Driver.Browser.FindElement(By.TagName(locator))));
            }
            else if (elementLocatorType == ElementLocator.ClassName)
            {
                wait.Until(ExpectedConditions.StalenessOf(Driver.Browser.FindElement(By.ClassName(locator))));
            }
        }

    }

    public class Helpers
    {
        public AutoSuggest AutoSuggestHelper = new AutoSuggest();
        public MouseAction MouseActionHelper = new MouseAction();
        public KeyBoardAction KeyBoardActionHelper = new KeyBoardAction();
        public Browser BrowserHelper = new Browser();
        public Button ButtonHelper = new Button();
        public CheckBox CheckBoxHelper = new CheckBox();
        public ComboBox ComboBoxHelper = new ComboBox();
        public JavascriptHelp JavaScriptHelper = new JavascriptHelp();
        public Label LabelHelper = new Label();
        public Link LinkHelper = new Link();
        public RadioButton RadioButtonHelper = new RadioButton();
        public Text TextBoxHelper = new Text();
    }
}
