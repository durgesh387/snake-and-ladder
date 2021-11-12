using System;

namespace AssignmentDeserve.Core{
    public class SingleDice : IRollable
    {
        private readonly RollableType Type;

        public SingleDice(){
            Type=RollableType.SingleDice;
        }

        public RollableType GetRollableType()
        {
            return Type;
        }

        public int Roll()
        {
            var random=new Random();
            return random.Next(1,7);
        }
    }
}