using Utilities2;
using NUnit.Framework;
using Moq;
namespace Utilities2Tests;


public class PersonalDataReaderTests
{   // cut -> Class Under Test
    private PersonalDataReader _cut;
    private Mock<IDatabaseConnection> _databaseConnectionMock;

    [SetUp]
    public void Setup()
    {
        _databaseConnectionMock = new Mock<IDatabaseConnection>();
        _cut = new PersonalDataReader(
            _databaseConnectionMock.Object);
    }

    [Test]
    public void Read_ShallProduceResultWithDataOfPersonReadFromTheDatabase()
    {
        
        _databaseConnectionMock
            .Setup(mock => mock.GetById(5))
            .Returns(new Person(5, "John", "Smith"));

        string result = _cut.Read(5);

        Assert.AreEqual("(Id: 5) John Smith", result);
    }

    [Test]
    public void Save_ShallCallTheWriteMethod_WithCorrectArguments()
    {
             
        var personToBeSaved = new Person(10, "Jane", "Miller");
        _cut.Save(personToBeSaved);

        _databaseConnectionMock.Verify(
            mock => mock.Write(personToBeSaved.Id, personToBeSaved));
    }
}
