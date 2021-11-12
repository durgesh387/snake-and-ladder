namespace AssignmentDeserve.Core{
    public interface IRollable{
        RollableType GetRollableType();
        int Roll();
    }
}