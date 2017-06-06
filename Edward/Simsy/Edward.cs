using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simsy
{
    class Edward
    {
        int health;
        int sleep;
        int hunger;
        int bored;
        int x, y;
        char draw;
        bool deppresion;

        public Edward()
        {
            bored = 100;
            health = 100;
            sleep = 100;
            hunger = 100;
            x = 2;
            y = 2;
            draw = '@';
        }//Konstruktor

        public bool Needs_Update(int d_sleep, int d_hunger, int d_health,int d_bored, int l)
        {
            sleep = sleep + d_sleep;
            if (sleep > 100) sleep = 100;
            if (sleep < 0) sleep = 0;
            hunger = hunger + d_hunger;
            if (hunger> 100) hunger = 100;
            if (hunger < 0) hunger = 0;
            health = health + d_health;
            if (health > 100) health = 100;
            bored = bored + d_bored;
            if (bored > 100) bored= 100;
            if (bored < 0) bored = 0;
            if (health <= 0)
            {
                draw = '÷';
                System.Console.Write("Edward umarł po: "+l+" turach. Wciśnij dowolny klawisz...");
                System.Console.ReadKey();
                return false;

            }
            if (sleep < 20)
            {
                if (sleep < 5)
                {
                    this.health = health - 8;//dla <5,0) odejmij 8
                }
                else if (sleep < 10)
                {
                    this.health = health - 4;//dla <10,5) odejmij 4
                }
                else if (sleep < 15)
                {
                    this.health = health - 2;//dla <15,10) odejmij 2
                }
                else if (sleep < 20)
                {
                    this.health = health - 1;//dla <20,15) odejmij 1
                }
            }
            if (hunger < 20)
            {
                if (hunger < 5)
                {
                    this.health = health - 8;//dla <5,0) odejmij 8
                }
                else if (hunger< 10)
                {
                    this.health = health - 4;//dla <10,5) odejmij 4
                }
                else if (hunger < 15)
                {
                    this.health = health - 2;//dla <15,10) odejmij 2
                }
                else if (health < 20)
                {
                    this.health = health - 1;//dla <20,15) odejmij 1
                }
            }
            if (bored == 0)
            {
                deppresion = true;
            }
            if (bored == 100)
            {
                deppresion = false;
            }
            if (deppresion)
            {
                health = health - 1;
            }
            return true;
        }

        public void AI(int E_x, int E_y)
        {
            Random rand = new Random();
            int R1, R2;
            R1 = rand.Next(-100, 100);
            R2 = rand.Next(-100, 100);


                if (this.hunger < 70 && this.sleep > this.hunger)//lodówka(3,0) 
                {
                    if (E_x > 0)
                    {
                        this.x = x - 1;
                    }
                    if (E_x < 0)
                    {
                        this.x = x + 1;
                    }
                    if (E_x == 0)
                    {

                    }
                    if (E_y > 3)
                    {
                        this.y = y - 1;
                    }
                    if (E_y < 3)
                    {
                        this.y = y + 1;
                    }
                    if (E_y == 3)
                    {

                    }
                goto END;
                }
                if (this.sleep < 70 && this.sleep < this.hunger)//Łóżko(4,4)
                {
                    if (E_x > 4)
                    {
                        this.x = x - 1;
                    }
                    if (E_x < 4)
                    {
                        this.x = x + 1;
                    }
                    if (E_x == 4)
                    {

                    }
                    if (E_y > 4)
                    {
                        this.y = y - 1;
                    }
                    if (E_y < 4)
                    {
                        this.y = y + 1;
                    }
                    if (E_y == 4)
                    {

                    }
                goto END;
                }
                if (((this.hunger > 70 && this.sleep > 70) && ((E_x != 0 && E_y != 3) || (E_x != 4 && E_y != 4))) || this.bored < 20)//Biórko (0,3)
                {
                    if (E_x > 3)
                    {
                        this.x = x - 1;
                    }
                    if (E_x < 3)
                    {
                        this.x = x + 1;
                    }
                    if (E_x == 3)
                    {

                    }
                    if (E_y > 0)
                    {
                        this.y = y - 1;
                    }
                    if (E_y < 0)
                    {
                        this.y = y + 1;
                    }
                    if (E_y == 0)
                    {

                    }
                goto END;
                }

                if (R1 > 0 && x + 1 != 5) x = x + 1;
                if (R1 < 0 && x - 1 != -1) x = x - 1;
                if (R2 > 0 && y + 1 != 5) y = y + 1;
                if (R2 < 0 && y - 1 != -1) y = y - 1;

            END:;


        }



        public int X()
        {
            return x;
        }  // Metody te zwracają pole z nazwy

        public int Y()
        {
            return y;
        }

        public char Draw()
        {
            return draw;
        }

        public int Life()
        {
            return health;
        }

        public int Hunger()
        {
            return hunger;
        }

        public int Sleep()
        {
            return sleep;
        }

        public int Bored()
        {
            return bored;
        }

        public bool Depression()
        {
            return deppresion;
        }
    }
}
