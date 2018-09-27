using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SO_Segment_Solution.Controllers;
using System.Web.Mvc;
using System.IO;
using System.Web;
using Microsoft.CSharp.RuntimeBinder;
using Moq;
using System.Web.Routing;

namespace SO_Segement_Test

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var context = new Mock<HttpContextBase>();
            var postedfile = new Mock<HttpPostedFileBase>();
            var absPath= Path.GetFullPath("../../input_user_story_dummy.txt");
            var streamReader = new StreamReader(absPath);
            postedfile.Setup(x => x.InputStream).Returns(streamReader.BaseStream);
            HomeController controller = new HomeController();
            controller.ControllerContext = new ControllerContext(context.Object, new RouteData(), controller);
            ViewResult result = controller.UploadFile(postedfile.Object);
            var Message = result.ViewBag.Message;
            Assert.AreEqual("600143155", Message);
        }
    }
}
