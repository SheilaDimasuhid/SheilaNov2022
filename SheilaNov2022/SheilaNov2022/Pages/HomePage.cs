﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheilaNov2022.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            // navigate to Time and Material
            IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            administrationDropdown.Click();
            Thread.Sleep(500);

            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();
        }
    }
}
