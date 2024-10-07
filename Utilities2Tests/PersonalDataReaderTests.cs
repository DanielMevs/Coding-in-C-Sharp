using Utilities2;
using NUnit.Framework;
namespace Utilities2Tests;
using Moq;

public class PersonalDataReaderTests
{
    [Test]
    public void Read_ShallProduceResultWithDataOfPersonReadFromTheDatabase()
    {
        var databaseConnectionMock = new Mock<IDatabaseConnection>();
        databaseConnectionMock
            .Setup(mock => mock.GetById(5))
            .Returns(new Person(5, "John", "Smith"));

        var personalDataReader = new PersonalDataReader(
            databaseConnectionMock.Object);

        string result = personalDataReader.Read(5);

        Assert.AreEqual("(Id: 5) John Smith", result);
    }
}
