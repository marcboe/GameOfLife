using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife
{
    struct Cell
    {

        private int state, environment;
        //Status 1 = alive; 2 = dead; 0 = empty
        public int State
        {
            get
            {
                return state;
            }
            //set => State = value;
            set
            {
                state = value;
            }
        }


        //Anzahl Nachbarn
        public int Environment
        {
            get
            {
                return environment;
            }
            set => environment = value;
        }
    
    public Cell(int status, int env) {
            state = status;
            environment = env;
        }
    }
}

//Status eingeben ; a = alive; d = dead; e = empty


/* Code-Reste, ersetzt durch properties
 * public void SetState(char State) 
{
    state = State;
}
//Status ausgeben
public char GetState() 
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
*/

