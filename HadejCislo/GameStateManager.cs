using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HadejCislo
{
    internal class GameStateManager
    {
        static GameStateManager instance;
        public static GameStateManager Instance
        {
            get
            {
                if(instance == null)
                    return instance = new GameStateManager();
                else
                    return instance;
            }
        }
        IGameState? currState;

        private GameStateManager() { }

        public void ChangeState(IGameState state)
        {
            if(currState != null)
                currState.Exit();

            currState = state;
            currState.Enter();
        }
    }
}
