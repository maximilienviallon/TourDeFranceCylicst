using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumballSystem
{
    class GumballController
    {   
        IState currentState;


        public IState setCurrentState()
        {
    
            return currentState;
        }
    }

   
}
