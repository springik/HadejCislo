using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HadejCislo
{
    internal class PlayState : IGameState
    {
        static GameOverState gs = new GameOverState();
        static int max = 100;
        int chosenNum;
        public void Enter()
        {
            Console.Clear();
            Random rnd = new Random();
            chosenNum = rnd.Next(0, max);
            Console.WriteLine($"Hra začíná...\nHádejte číslo v rozmezí od 0 do {max}");
            Update();
        }

        public void Exit()
        {
            Console.Clear();
            //GameStateManager.Instance.ChangeState(gs);
        }

        public void Render()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            string tmp = Console.ReadLine();
            int input = int.Parse(tmp);
            Console.WriteLine($"Váš input: {input}");
            Evaluate(input);
        }

        void Evaluate(int input)
        {
            Console.WriteLine(chosenNum);



            if (input == chosenNum)
            {
                Console.WriteLine("Uhádli jste správně");
                Console.ReadKey();
                GameStateManager.Instance.ChangeState(gs);
            }
            if ( chosenNum < input )
            {
                Console.WriteLine("Vaše číslo je nižší");
                Update();
            }
            if( chosenNum > input )
            {
                Console.WriteLine("Vaše číslo je vyší");
                Update();
            }
        }
    }
}
