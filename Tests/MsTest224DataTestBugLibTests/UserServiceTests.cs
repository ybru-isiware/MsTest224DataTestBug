using Microsoft.VisualStudio.TestTools.UnitTesting;
using MsTest224DataTestBugLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace MsTest224DataTestBugLib.Tests
{
    [TestClass()]
    public class UserServiceTests
    {
        [DataTestMethod()]
        [DynamicData(nameof(GetParseUserDatas), DynamicDataSourceType.Method)]
        public void ParseUserDatasTest(string userDatas, User expectedUser)
        {
            // Prepare
            UserService srv = new();

            // Act
            User user = srv.ParseUserDatas(userDatas);

            // Assert
            user.Should().BeEquivalentTo(expectedUser);
        }

        public static IEnumerable<object[]> GetParseUserDatas()
        {
            yield return new object[] {
                "John;Doe",
                new User()
                {
                    FirstName = "John",
                    LastName = "Doe"
                }
            };
        }
    }
}