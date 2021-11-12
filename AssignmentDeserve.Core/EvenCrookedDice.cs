namespace AssignmentDeserve.Core{
    public class EvenCrookedDice : IRollable
    {
        private readonly RollableType Type;

        public EvenCrookedDice(){
            Type=RollableType.EvenCrookedDice;
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