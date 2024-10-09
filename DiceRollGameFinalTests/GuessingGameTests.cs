using NUnit.Framework;
using DiceRollGameFinal.Game;
using DiceRollGameFinal.UserCommunication;
using Moq;

namespace DiceRollGameFinalTests;

[TestFixture]
public class GuessingGameTests
{
    
    [Test]
    public void Play_ShallReturnVictory_IfTheUserGuessesThenumberonTheFirstTry()
    {
        var diceMock = new Mock<IDice>();
        var userCommunicationMock = new Mock<IUserCommunication>();
        const int NumberOnDie = 3;
        diceMock.Setup(mock => mock.Roll()).Returns(NumberOnDie);
        var cut = new GuessingGame(
            diceMock.Object, userCommunicationMock.Object);

        var gameResult = cut.Play();
    }
}
