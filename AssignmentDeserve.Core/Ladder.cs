namespace AssignmentDeserve.Core{
    public class Ladder:IJumper{
        public int StartPoint{get;set;}
        public int EndPoint{get;set;}

        public int GetEndPoint()
        {
            return EndPoint;
        }

        public int GetStartPoint()
        {
            return StartPoint;
        }

        public int Jump(int start, int end)
        {
            throw new System.NotImplementedException();
        }
    }
}