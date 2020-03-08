using CXO.ProgrammingAssignments.ORM.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CXO.ProgrammingAssignments.ORM.Tests
{
    [TestClass]
    public class DbContextTest
    {
        [TestMethod]
        public void Insert_Prota_ExecutesNonEmptyCommand()
        {
            //Arrange
            var testConnection = new TestDbConnection();
            var dbContext = new DbContext(DbType.Prota, testConnection);

            //Act
            dbContext.Insert(It.Is<string>(x => x.Contains("User")));

            //Assert
            Assert.AreEqual(1, testConnection.ExecutedCommands.Count);
            Assert.IsFalse(string.IsNullOrEmpty(testConnection.ExecutedCommands[0]));
        }

        [TestMethod]
        public void Insert_Defteros_ExecutesNonEmptyCommand()
        {
            //Arrange
            var testConnection = new TestDbConnection();
            var dbContext = new DbContext(DbType.Defteros, testConnection);

            //Act
            dbContext.Insert(It.Is<string>(x => x.Contains("User")));

            //Assert
            Assert.AreEqual(1, testConnection.ExecutedCommands.Count);
            Assert.IsFalse(string.IsNullOrEmpty(testConnection.ExecutedCommands[0]));
        }
    }
}
