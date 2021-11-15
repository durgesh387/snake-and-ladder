using System.Collections.Generic;
using AssignmentDeserve.Core;
using Moq;
using Xunit;

namespace AssignmentDeserve.Tests
{
    public class GameServiceTests
    {
        private readonly Mock<IDiceFactory> _diceFactoryMock;

        public GameServiceTests(){
            _diceFactoryMock=new Mock<IDiceFactory>();
        }

        [Fact]
        public void StartGame_Success()
        {
            var gameService=new GameService(_diceFactoryMock.Object);

            //act
            //gameService.StartGame();
            //assert

        }

        [Fact]
        public void SetupGame_Success(){
            //arrange
            var gameServiceMock=new Mock<IGameService>();
            //gameServiceMock.Setup(x=>x.SetupGame());
            //act
            gameServiceMock.Object.SetupGame();

            // assert/verify
            gameServiceMock.Verify(x=>x.SetupGame(),Times.Once);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        public void MovePlayer_Success(int diceValue){

        }
    }
}