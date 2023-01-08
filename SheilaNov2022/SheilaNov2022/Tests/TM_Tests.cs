using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SheilaNov2022.Pages;
using NUnit.Framework;
using SheilaNov2022.Utilities;

namespace SheilaNov2022.Tests
{
    [TestFixture]
    public class TM_Tests : CommonDriver
    {
        [SetUp]
        public void LoginSTeps()
        {
            // open chrome browser
            driver = new ChromeDriver();

            //LoginPage object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);


            //HomePage object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

        }

        [Test,Order(1)]
        public void CreateTM_Test()
        {
            //TMPage object initiualization and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);
        }

        [Test, Order(2)]
        public void EditTM_Test()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTM(driver);
        }

        [Test, Order(3)]
        public void DeleteTM_Test()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.DeleteTM(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
         
    }
}
