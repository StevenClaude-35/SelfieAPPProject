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
            var controller = new SelfieController();
            //Act
            var result = controller.Get();
            //Assert=>prouvé que c'est vrai
            Assert.NotNull(result);
            Assert.True(result.GetEnumerator().MoveNext());
        }
        #endregion

    }
}
