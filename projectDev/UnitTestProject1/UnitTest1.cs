using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using projectDev.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CourseUnitTest()
        {
            CoursesUnitTestController controller = new CoursesUnitTestController();
            IActionResult result = controller.Index() as IActionResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CourseMarksUnitTest()
        {
            CourseMarksUnitTestController controller = new CourseMarksUnitTestController();
            IActionResult result = controller.Index() as IActionResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void EnrolmentsUnitTest()
        {
            EnrolmentsUnitTestController controller = new EnrolmentsUnitTestController();
            IActionResult result = controller.Index() as IActionResult;
            Assert.IsNotNull(result);
        }
    }
}
