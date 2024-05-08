using Moq;
using WebApplication1.Interfaces;
using WebApplication1.Models;
using WebApplication1.Services;

namespace TestProject1
{
    public class UnitTest1
    {
        private readonly UserService _sut;

        private readonly Mock<IUserRepository> userRepositoryMock = new(MockBehavior.Strict);
        private readonly Mock<IAuditService> auditService = new(MockBehavior.Strict);


        //private readonly Mock<IUserRepository> userRepositoryMock = new();
        //private readonly Mock<IAuditService> auditService = new();

        public UnitTest1() 
        {
            var usersreturned = new List<User>();
            var userinlist = new User
            {
                Id = 1,
                Name = "cevanume",
                Email = "email",
                Password = "dsa"
            };

            usersreturned.Add(userinlist);

            userRepositoryMock.Setup(x => x.GetUsersAsync()).ReturnsAsync(usersreturned);
            auditService.Setup(x => x.InsertAudit("test", "Yes"));
            
            _sut = new UserService(auditService.Object, userRepositoryMock.Object);
        }

        [Fact]
        public async void Test1()
        {
            // arange
            var name = "test";
            var id = 1;

            // act
            await _sut.UpdateUserName(id, name);
            // assert

            auditService.Verify(x => x.InsertAudit("test", "Yes"), Times.Once);
        }
    }
}