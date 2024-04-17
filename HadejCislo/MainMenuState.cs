using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HadejCislo
{
    internal class MainMenuState : IGameState
    {
        static PlayState ps = new PlayState();
        static GameOverState gs = new GameOverState();
        public void Enter()
        {
            Console.Clear();
            Console.WriteLine("Vítej ve hře Hadej číslo!\n 1.Hrát\n 2.Pravidla\n 3.Konec");
            string input = Console.ReadLine();

            switch (int.Parse(input))
            {
                case 1:
                    Update();
                    break;
                case 2:
                    PrintRules();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Vyběrte si z možností");
                    break;
            }
        }

        void PrintRules()
        {
            Console.Clear();
            Console.WriteLine("Znažíte se uhádnout číslo v rozmezí.");
            Console.ReadKey();
            Enter();
        }

        public void Exit()
        {
            Console.Clear();
            //GameStateManager.Instance.ChangeState(gs);
        }

        // No clue what this should do here
        public void Render()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            GameStateManager.Instance.ChangeState(ps);
        }
    }
}
