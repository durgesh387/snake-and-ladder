using System.Collections.Generic;
using System;

namespace AssignmentDeserve.Core{
    public class GameService:IGameService{

        private readonly DiceFactory _diceFactory;

        private static IRollable RollingEquipment;

        private static List<IJumper> Jumpers{get;set;}

        private static List<Player> Players{get;set;}

        private static Queue<Player> PlayersQueue{get;set;}

        private static Dictionary<int,int> PlayersPieces{get;set;}
        private static Dictionary<int,int> JumpersDictionary{get;set;}

        private static int BoardSize{get;set;}

        public GameService(DiceFactory diceFactory){
            _diceFactory=diceFactory;
        }

        private void SetupJumpers(){
            Jumpers=new List<IJumper>();
            Jumpers.Add(new Snake{StartPoint=10,EndPoint=2});
            Jumpers.Add(new Snake{StartPoint=99,EndPoint=12});
            Jumpers.Add(new Ladder{StartPoint=5,EndPoint=25});
            Jumpers.Add(new Ladder{StartPoint=40,EndPoint=89});
        }

        private void SetupJumeprsDicationary(){
            JumpersDictionary=new Dictionary<int,int>();
            foreach(var jumper in Jumpers){
                JumpersDictionary.Add(jumper.GetStartPoint(),jumper.GetEndPoint());
            }
        }

        private void SetupPlayersList(){
            Players=new List<Player>();
            Players.Add(new Player{Id=1,Name="Durgesh"});
            Players.Add(new Player{Id=2,Name="Akash"});
        }

        private void SetupPlayersQueue(){
            PlayersQueue=new Queue<Player>();
            foreach(var player in Players){
                PlayersQueue.Enqueue(player);
            }
        }

        private void SetupPlayersPieces(){
            PlayersPieces=new Dictionary<int,int>();
            foreach(var player in Players){
                PlayersPieces.Add(player.Id,0);
            }
        }

        private void SetupBoardSize(){
            BoardSize=GameConfigurationInput.BoardSize;
        }

        private void SetupRollingEquipment(){
            RollingEquipment=_diceFactory.GetDice(GameConfigurationInput.Dicetype);
        }

        public void SetupGame(){
            SetupRollingEquipment();
            SetupJumpers();
            SetupPlayersList();
            SetupPlayersQueue();
            SetupPlayersPieces();
            SetupJumeprsDicationary();
            SetupBoardSize();
        }

        

        public void StartGame(){
            while(PlayersQueue.Count>1){
                var currentPlayer=PlayersQueue.Dequeue();
                var diceValue=RollingEquipment.Roll();
                Console.WriteLine(currentPlayer.Name + " rolled the dice, got :" + diceValue);
                MovePlayer(currentPlayer,diceValue);
                int currentPos=PlayersPieces[currentPlayer.Id];
                if(currentPos!=BoardSize){
                    PlayersQueue.Enqueue(currentPlayer);
                }
                else{
                    Console.WriteLine(currentPlayer.Name + " is home and only " + PlayersQueue.Count + " player/s left in the game");
                }
            }

            Console.WriteLine("Game ended!!!");
        }

        public void MovePlayer(Player player,int diceValue){
            int oldPos=PlayersPieces[player.Id];
            int tmpNewPos=oldPos + diceValue;
            int newPos=tmpNewPos;
            if(JumpersDictionary.ContainsKey(tmpNewPos)){
                newPos=JumpersDictionary[tmpNewPos];
            }
            if(newPos <= BoardSize){
                PlayersPieces[player.Id]=newPos;
                Console.WriteLine(" and moved to position " + newPos);
            }
            Console.WriteLine(" and can't move further");
        }
    }
}