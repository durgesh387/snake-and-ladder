using System;
namespace AssignmentDeserve.Core{
    public class EntryPoint{
        private readonly IGameService _gameService;
        public EntryPoint(IGameService gameService){
            _gameService=gameService;
        }

        public void Run(){
            _gameService.SetupGame();

            Console.WriteLine("......Starting the game........");

            _gameService.StartGame();
        }
    }
}