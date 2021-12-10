using Microsoft.AspNetCore.Mvc;
using SelfieApp.UI.Controllers;
using System;
using Xunit;

namespace TestWebAPI
{
    public class SelfieControllerUnitTest
    {
        #region Public Methods
        [Fact]
        public void ShouldReturnListSelfies()
        {
            //Arange =>Préparer les jeux de données
            var controller = new SelfieController(null);
            //Act
            var result = controller.Get();
            //Assert=>prouvé que c'est vrai

            Assert.NotNull(result);
            Assert.IsType<OkObjectResult>(result);
            OkObjectResult okObjectResult = result as OkObjectResult;
            Assert.NotNull(okObjectResult.Value);
        }
        #endregion

    }
}
