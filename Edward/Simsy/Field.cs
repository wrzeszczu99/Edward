using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simsy
{
    class Field
    {
        //float temp;
        int station;
        char ascii;
        int delta_health;
        int delta_hunger;
        int delta_sleep;
        int delta_bored;

        public Field(int s) //Zrobić pola w zależności od ziennej:stacja. Temperatura jest do zaimplementowania na końcu razem z piecykiem
        {
            station = s;
            switch (station)
            {
                case 0: //Zwykła podłoga
                    ascii = '.';
                    delta_health = 0;
                    delta_hunger = -1;
                    delta_sleep = -1;
                    delta_bored = -1;
                    break;

                case 1: //Łóżko
                    ascii = '=';
                    delta_health = 0;
                    delta_hunger = -2;
                    delta_sleep = 5;
                    delta_bored = 0;
                    break;

                case 2: //Lodówka
                    ascii = '§';
                    delta_health = 0;
                    delta_hunger = 10;
                    delta_sleep = -3;
                    delta_bored = 0;
                    break;

                case 3: //Biurko(Nuda), do dodania potem
                    ascii = '╦';
                    delta_health = 0;
                    delta_hunger = -5;
                    delta_sleep = -5;
                    delta_bored = 7;
                    break;
                case 4: //Piecyk
                    ascii = '▓';
                    delta_health = 0;
                    delta_hunger = -3;
                    delta_sleep = -2;
                    delta_bored = 0;
                    break;
            }
        }

        public char Draw()
        {
            return this.ascii;
        }

        public int D_Sleep()
        {
            return delta_sleep;
        }

        public int D_Hunger()
        {
            return delta_hunger;
        }

        public int D_Health()
        {
            return delta_health;
        }

        public int D_Bored()
        {
            return delta_bored;
        }
    }
    
}
