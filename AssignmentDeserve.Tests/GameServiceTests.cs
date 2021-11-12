using System.Collections.Generic;
using AssignmentDeserve.Core;
using Moq;
using Xunit;

namespace AssignmentDeserve.Tests
{
    public class GameServiceTests
    {
        private readonly DiceFactory _diceFactory;

        public GameServiceTests(){
            _diceFactory=new DiceFactory(Mock.Of<IEnumerable<IRollable>>());
        }

        [Fact]
        public void StartGame_Success()
        {
            
        }
    }
}