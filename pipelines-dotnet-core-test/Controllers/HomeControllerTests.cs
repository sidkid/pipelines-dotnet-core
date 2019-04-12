using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using pipelines_dotnet_core.Controllers;

namespace pipelines_dotnet_core_test.Controllers
{
    public class HomeControllerTests
    {
        [Test]
        public void DefaultViewIsCorrect()
        {
            var homeController = new HomeController();

            ViewResult indexView = homeController.Index() as ViewResult;

            Assert.That(indexView, Is.InstanceOf<ViewResult>());
        }

        [Test]
        public void PrivacyViewIsCorrect()
        {
            var homeController = new HomeController();

            ViewResult privacyView = homeController.Privacy() as ViewResult;

            // Fail it to see failure report in Azure DevOps CI
            Assert.That(privacyView, Is.Not.InstanceOf<ViewResult>());
        }
    }
}