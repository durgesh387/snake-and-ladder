namespace AssignmentDeserve.Core
{
    public interface IDiceFactory
    {
         IRollable GetDice(RollableType type);
    }
}