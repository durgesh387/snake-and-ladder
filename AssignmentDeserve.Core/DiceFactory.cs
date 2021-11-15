using System.Collections.Generic;
using System.Linq;

namespace AssignmentDeserve.Core
{
    public class DiceFactory:IDiceFactory
    {
        private readonly IEnumerable<IRollable> _rollables;
        public DiceFactory(IEnumerable<IRollable> rollables){
            _rollables=rollables;
        }
        public IRollable GetDice(RollableType type){
            // can verify the passed type and throw exceptions accordingly
            var diceObj=_rollables.FirstOrDefault(x=>x.GetRollableType()==type);
            return diceObj;
        }
    }
}