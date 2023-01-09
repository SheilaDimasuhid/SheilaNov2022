

namespace SheilaNov2022.Tests
{
    [TestFixture]
    [Parallelizable]
    public class TM_Tests : CommonDriver
    {
      
        [Test,Order(1),Description("Check if user is able to create a new record with valid data")]
        public void CreateTM_Test()
        {
            //HomePage object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            //TMPage object initiualization and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);
        }

        [Test, Order(2), Description("Check if user is able to edit an existing record with valid data")]
        public void EditTM_Test()
        {
            //HomePage object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTM(driver);
        }

        [Test, Order(3), Description("Check if user is able to delete existing record successfully")]
        public void DeleteTM_Test()
        {
            //HomePage object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            TMPage tmPageObj = new TMPage();
            tmPageObj.DeleteTM(driver);
        }
      
    }
}
