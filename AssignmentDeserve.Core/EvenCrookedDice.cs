using System;

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
            var rand=new Random();
            var tmp=rand.Next(1,7);
            if(tmp%2==0){
                return tmp;
            }
            else{
                if(tmp+1 <7){
                    return tmp+1;
                }
                else{
                    return tmp-1;
                }
            }
        }
    }
}