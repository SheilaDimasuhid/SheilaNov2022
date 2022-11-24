using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SheilaNov2022.Pages;
using System.Xml.Linq;


// open chrome browser
IWebDriver driver = new ChromeDriver();

//LoginPage object initialization and definition
LoginPage loginPageObj = new LoginPage();
loginPageObj.LoginActions(driver);


//HomePage object initialization and definition
HomePage homePageObj = new HomePage();
homePageObj.GoToTMPage(driver);

//TMPage object initiualization and definition
TMPage tmPageObj = new TMPage();
tmPageObj.CreateTM(driver);

tmPageObj.EditTM(driver);

tmPageObj.DeleteTM(driver);

driver.Quit();
Environment.Exit(0);