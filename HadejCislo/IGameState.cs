using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HadejCislo
{
    internal interface IGameState
    {
        public void Enter();
        public void Exit();
        public void Update();
        public void Render();
    }
}
