


namespace SheilaNov2022.Pages
{
    public class EmployeePage : CommonDriver
    {
        public void CreateEmployee(IWebDriver driver)
        {
            /*
                //Script for Create New Button in Employee Page

                // click on Create New button
                Thread.Sleep(1500);
                IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
                createNewButton.Click();
                Thread.Sleep(1000);

                //Wait.WaitForElementToExist(driver, "XPath", "//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span", 6);

                //IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
                //typeCodeDropdown.Click();

                //IWebElement hoveroverlapping = driver.FindElement(By.XPath("//*[@id=\"TypeCode-list\"]"));
                //Thread.Sleep(500);
                //IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\'TypeCode_listbox\']/li[2]"));
                //timeOption.Click();


                // enter Name in the Name textbox
                IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
                codeTextbox.SendKeys("SheilaTestCode");

                // enter Username in the Username textbox
                IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
                descriptionTextbox.SendKeys("SheilaTestDescription");

                // enter Password in the Password textbox
                IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
                codeTextbox.SendKeys("SheilaTestCode");

                // enter RetypePassword in the RetypePassword textbox
                IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
                descriptionTextbox.SendKeys("SheilaTestDescription");

                // enter price in price per unit textbox
                IWebElement overlappingTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
                overlappingTag.Click();

                IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
                priceTextbox.SendKeys("10");

                // click on save button
                IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
                saveButton.Click();
                Thread.Sleep(5000);

                // Wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 20);

                //wait for the last page button to be clickable
                //var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")));


                // check if new time record has been created successfully
                IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
                //*[@id="tmsGrid"]/div[4]/a[4]/span
                goToLastPageButton.Click();

                Thread.Sleep(2000);

                //*[@id="tmsGrid"]/div[3]/table/tbody/tr[last()]/td[1]
                IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
                //IWebElement newDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
                //IWebElement newPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));

                Thread.Sleep(2000);

                //Example 1:
                Assert.That(newCode.Text == "SheilaTestCode", "Actual code and accepted code do not match");
                //Assert.That(newDescription.Text == "SheilaTestDescription", "Actual Description and accepted description do not match");
                //Assert.That(newPrice.Text == "$10.00", "Actual price and accepted price do not match");


                // Example 2:
                    //if (newCode.Text == "SheilaTestCode")
                    //{
                    //    Assert.Pass("Time record created successfully.");
                    //}
                    //else
                    //{
                    //    Assert.Fail("Time record hasn't been created successfully");
                    //}
                
            */
        }

        public void EditEmployee(IWebDriver driver)
        {

        }

        public void DeleteEmployee(IWebDriver driver)
        {

        }
    }
}
