using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HadejCislo
{
    internal class GameOverState : IGameState
    {
        static PlayState ps = new PlayState();
        static MainMenuState mm = new MainMenuState();
        public void Enter()
        {
            Console.Clear();
            Update();
        }

        public void Exit()
        {
            Console.Clear();
        }

        public void Render()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            Console.WriteLine("1.Hrát znovu\n2.Návrat do menu\n3.Konec");
            string tmp = Console.ReadLine();
            int input = int.Parse(tmp);
            switch (input)
            {
                case 1:
                    GameStateManager.Instance.ChangeState(ps);
                    break;
                case 2:
                    GameStateManager.Instance.ChangeState(mm);
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Vyberte si z možností!");
                    break;
            }
        }
    }
}
