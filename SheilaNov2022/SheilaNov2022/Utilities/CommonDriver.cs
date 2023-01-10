
namespace SheilaNov2022.Utilities
{
    public class CommonDriver
    {

        //public static IWebDriver driver;
        public IWebDriver driver;

        [OneTimeSetUp]
        public void LoginSTeps()
        {
            // open chrome browser
            driver = new ChromeDriver();

            //LoginPage object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);
        }

        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
