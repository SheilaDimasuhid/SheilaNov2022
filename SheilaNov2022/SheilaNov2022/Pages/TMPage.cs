


namespace SheilaNov2022.Pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            //Script for Create New Button in Time and Material  (Time option)

            // click on Create New button
            Thread.Sleep(1500);
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();
            Thread.Sleep(500);

            Wait.WaitForElementToExist(driver, "XPath", "//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span", 6);


            // select Time in the typecode dropdown
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();

            //IWebElement hoveroverlapping = driver.FindElement(By.XPath("//*[@id=\"TypeCode-list\"]"));
            Thread.Sleep(500);
            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\'TypeCode_listbox\']/li[2]"));
            timeOption.Click();


            // enter code in the code textbox
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("SheilaTestCode");

            // enter description in the description textbox
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
            Thread.Sleep(7000);

           // Wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 20);

            //wait for the last page button to be clickable
            //var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")));


            // check if new time record has been created successfully
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
                                                                           //*[@id="tmsGrid"]/div[4]/a[4]/span
            goToLastPageButton.Click();

            Thread.Sleep(5000);
            
                                                                //*[@id="tmsGrid"]/div[3]/table/tbody/tr[last()]/td[1]
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]")); 
            //IWebElement newDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            //IWebElement newPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));

            Thread.Sleep(2000);

            //Example 1:
            Assert.That(newCode.Text == "SheilaTestCode", "Actual code and accepted code do not match");
            //Assert.That(newDescription.Text == "SheilaTestDescription", "Actual Description and accepted description do not match");
            //Assert.That(newPrice.Text == "$10.00", "Actual price and accepted price do not match");
            

            /*Example 2:
            if (newCode.Text == "SheilaTestCode")
            {
                Assert.Pass("Time record created successfully.");
            }
            else
            {
                Assert.Fail("Time record hasn't been created successfully");
            }
            */
        }

        public void EditTM(IWebDriver driver)
        {
            //Thread.Sleep(3000);

            // Added by Galen
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 3);

            // Complete automation for the update time and material
            // Update the newly added record
            //Last page should be shown per previous code

            // go to the last page
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            Thread.Sleep(5000);

            IWebElement findNewRecordCreated = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (findNewRecordCreated.Text == "SheilaTestCode")
            {
                IWebElement editButtontask = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                editButtontask.Click();
                Thread.Sleep(500);
            }
            else
            {
                Assert.Fail("Record to be edited hasn't been found. Record not edited");
            }
            

            // select Time in the typecode dropdown
            IWebElement typeCodeDropdown2 = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown2.Click();

            Thread.Sleep(500);
            IWebElement timeOption2 = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            timeOption2.Click();

            // enter code in the code textbox
            IWebElement codeTextbox2 = driver.FindElement(By.Id("Code"));
            codeTextbox2.Clear();
            codeTextbox2.SendKeys("SheilaUpdatedCode2");

            // enter description in the description textbox
            IWebElement descriptionTextbox2 = driver.FindElement(By.Id("Description"));
            descriptionTextbox2.Clear();
            descriptionTextbox2.SendKeys("SheilaUpdatedDescription2");

            Thread.Sleep(500);

            // enter price in price per unit textbox
            IWebElement overlappingTag2 = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement priceTextbox2 = driver.FindElement(By.Id("Price"));

            overlappingTag2.Click();
            priceTextbox2.Clear();
            overlappingTag2.Click();
            priceTextbox2.SendKeys("50");

            // click on save button
            IWebElement saveButton2 = driver.FindElement(By.Id("SaveButton"));
            saveButton2.Click();
            //Thread.Sleep(5000);

            // Added by Galen
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 3);

            //Sample of Wait
            //var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")));


            // check if new time record has been created successfully
            IWebElement goToLastPageButton2 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton2.Click();
            Thread.Sleep(5000);

            IWebElement newCode2 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(5000);

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            //IWebElement newDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            //IWebElement newPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));

            Thread.Sleep(5000);

            //Example 1:
            Assert.That(newCode2.Text == "SheilaUpdatedCode2", "Actual code and accepted code do not match");

            /*
            if (newCode2.Text == "SheilaUpdatedCode2")
            {
                Console.WriteLine("Time record updated successfully.");
            }
            else
            {
                Console.WriteLine("Time record hasn't been updated successfully");
            }
            */

        }

        public void DeleteTM(IWebDriver driver)
        {
            // Complete automation for the delete time and material
            // Delete the newly added and updated record

            // go to the last page

            //Thread.Sleep(3000);
            // Added by Galen
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 3);


            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            Thread.Sleep(1000);

            IWebElement findRecordToDelete = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (findRecordToDelete.Text == "SheilaUpdatedCode2")
            {
                IWebElement deleteButtontask = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
                deleteButtontask.Click();
                Thread.Sleep(2000);
            }
            else
            {
                Assert.Fail("Record to be deleted hasn't been found. Record not deleted");
            }

            //This step produce an alert on screen
                   
            // Switch the control of 'driver' to the Alert from main window
            IAlert confirmationAlert = driver.SwitchTo().Alert();

            // Get the Text of Alert
            //String alertText = confirmationAlert.Text;

            //Console.WriteLine("Alert text is " + alertText);

            //'.Dismiss()' is used to cancel the alert '(click on the Cancel button)'
            confirmationAlert.Accept();
            //Thread.Sleep(5000);

            // Added by Galen
            driver.Navigate().Refresh();
            // Added by Galen
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 3);

            
            
            IWebElement goToLastPageButton3 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton3.Click();
            Thread.Sleep(1000);

            IWebElement newCode3 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(500);


            Assert.That(newCode3.Text != "SheilaUpdatedCode2", "Time record hasn't been deleted successfully");

            // Added by Galen
            /*VALIDATE DELETE
            IWebElement deletedRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (deletedRecord.Text != "C002")
            {
                Assert.Pass("Record has been deleted successfully ");
            }
            else
            {
                Assert.Fail("Record hasn't been deleted");
            }
            */

            /*
            if (newCode3.Text != "SheilaUpdatedCode2")
            {
                Assert.Pass("Time record deleted successfully.");
            }
            else
            {
                Assert.Fail("Time record hasn't been deleted successfully");
            }
            */

        }
    }
}
