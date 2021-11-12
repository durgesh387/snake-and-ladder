namespace AssignmentDeserve.Core{
    public class Ladder:IJumper{
        public int StartPoint{get;set;}
        public int EndPoint{get;set;}

        public int GetEndPoint()
        {
            //throw new System.NotImplementedException();
            return EndPoint;
        }

        public int GetStartPoint()
        {
            //throw new System.NotImplementedException();
            return StartPoint;
        }

        public int Jump(int start, int end)
        {
            throw new System.NotImplementedException();
        }
    }
}