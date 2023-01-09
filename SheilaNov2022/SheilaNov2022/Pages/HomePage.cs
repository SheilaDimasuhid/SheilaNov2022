


namespace SheilaNov2022.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            Thread.Sleep(2000);
            // navigate to Time and Material Page
            IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            administrationDropdown.Click();
            Thread.Sleep(1000);

            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();
        }

        public void GoToEmployeePage(IWebDriver driver)
        {
            Thread.Sleep(2000);
            // navigate to Employee Page
            IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            administrationDropdown.Click();
            Thread.Sleep(1000);

            IWebElement employeeOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            employeeOption.Click();
        }
    }
}
