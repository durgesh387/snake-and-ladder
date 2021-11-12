namespace AssignmentDeserve.Core{
    public class OddCrookedDice : IRollable
    {
        private readonly RollableType Type;

        public OddCrookedDice(){
            Type=RollableType.OddCrookedDice;
        }

        public RollableType GetRollableType()
        {
            //throw new System.NotImplementedException();
            return Type;
        }

        public int Roll()
        {
            throw new System.NotImplementedException();
        }
    }
}