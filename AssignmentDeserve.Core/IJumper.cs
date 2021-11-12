namespace AssignmentDeserve.Core{
    public interface IJumper{
        int Jump(int start,int end);

        int GetStartPoint();

        int GetEndPoint();
    }
}