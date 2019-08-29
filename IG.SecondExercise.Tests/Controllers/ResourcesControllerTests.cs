using IG.SecondExercise.Controllers;
using IG.SecondExercise.Dto;
using Xunit;

namespace IG.SecondExercise.Tests.Controllers
{
    public class ResourcesControllerTests
    {
        [Fact]
        public void Check_WhenCalled_CheckResultsShouldBeReturned()
        {
            //Assign
            var store = new Store();
            var controller = new ResourcesController();

            //Act
            var result = controller.Check(store);

            //Assert
            Assert.NotNull(result);
        }
    }
}