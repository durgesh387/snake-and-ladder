using System.Collections.Generic;
using System.Linq;
using AssignmentDeserve.Core;
//using Moq;
using Xunit;
namespace AssignmentDeserve.Tests
{
    public class DiceFactoryTests
    {
        
        [Theory]
        [InlineData(RollableType.SingleDice)]
        [InlineData(RollableType.DoubleDice)]
        [InlineData(RollableType.OddCrookedDice)]
        [InlineData(RollableType.EvenCrookedDice)]
        public void GetDice_Success(RollableType type){
            //arrange
            var rollables=new List<IRollable>{
                new SingleDice(),
                new EvenCrookedDice(),
                new OddCrookedDice()
            };
            var diceFactory=new DiceFactory(rollables);
            //act
            var result=diceFactory.GetDice(type);
            // assert
            Assert.Equal(rollables.FirstOrDefault(x=>x.GetRollableType()==type),result);

        }
    }
}