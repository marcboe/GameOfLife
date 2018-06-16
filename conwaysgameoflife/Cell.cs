using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife
{
    class Cell
    {
        //false: not alive; true: alive
        bool state;
        //Anzahl Nachbarn
        int environment;
    
    public Cell() {
            SetState(false);
            SetEnv(0);
        }
        //Status eingeben
        public void SetState(bool State) 
        {
            state = State;
        }
        //Status ausgeben
        public bool GetState() 
        {
            return state;
        }
        //Nachbarn eingeben
        public void SetEnv(int Number) 
        {
            environment = Number;
        }
        //Nachbarn ausgeben
        public int GetEnv()
        {
            return environment;
        }
    }
}
