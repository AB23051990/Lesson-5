using HW3.Controllers.Models;
using HW3.Repositories;
using Moq;
using Xunit;

namespace HW3
{
    public class Test
    {
       [Fact]
        public void PersonManager_Test()
        {
            Mock<IPersonsRepository> PersonRepositoryMock = new Mock<IPersonsRepository>();
            PersonRepositoryMock.Setup(mock => mock.Test()).Returns(new List<Persons>()
            {
                new Persons() { id = 1, Name = "111111111"},
                new Persons() { id = 2, Name = "222222222"},
            });
            IPersonsManager PersonManager = new PersonsManager(PersonRepositoryMock.Object);
            PersonManager.Test();
            PersonManager.Test();
            PersonRepositoryMock.Verify(mock => mock.Test(), Times.Once);
        }       
    }
}
