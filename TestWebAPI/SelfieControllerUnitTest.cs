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
            //Arange =>Pr�parer les jeux de donn�es
            var controller = new SelfieController(null);
            //Act
            var result = controller.Get();
            //Assert=>prouv� que c'est vrai

            Assert.NotNull(result);
            Assert.IsType<OkObjectResult>(result);
            OkObjectResult okObjectResult = result as OkObjectResult;
            Assert.NotNull(okObjectResult.Value);
        }
        #endregion

    }
}
