

namespace SheilaNov2022.Tests
{

    [TestFixture]
    [Parallelizable]
    public class Employee_Tests : CommonDriver
    {
           
        [Test, Order(1)]
        public void CreateEmployee_Test()
        {
            //HomePage object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeePage(driver);

            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.CreateEmployee(driver);
        }

        [Test, Order(2)]
        public void EditEmployee_Test()
        {

            //HomePage object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeePage(driver);
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.EditEmployee(driver);
        }

        [Test, Order(3)]
        public void DeleteEmployee_Test()
        {
            //HomePage object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeePage(driver);

            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.DeleteEmployee(driver);
        }

    }
}
