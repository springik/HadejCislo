using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HadejCislo
{
    internal class Game
    {
        MainMenuState MainMenuState { get; set; } = new MainMenuState();
        PlayState PlayState { get; set; } = new PlayState();
        GameOverState GameOverState { get; set; } = new GameOverState();
        public void Run()
        {
            GameStateManager.Instance.ChangeState(MainMenuState);
        }
    }
}
