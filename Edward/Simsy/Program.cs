using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simsy
{
    class Program
    {
        static int length;
        static void Main(string[] args)
        {
            Edward edek = new Edward();
            length = 0;
            Field[,] map = new Field[5, 5];
            Map_Make(map);
            Turn(edek, length, map);
        }

        static void Map_Make(Field[,] m)
        {
            
            for(int i=0;i<=4;i++)
            {
                
                for(int j=0;j<=4;j++)
                {
                    if (i == 4 && j == 4)
                    {
                        m[j, i] = new Field(1);
                    }
                    if (i == 3 && j == 0)
                    {
                        m[j, i] = new Field(2);
                    }
                    if (i == 0 && j == 3)
                    {
                        m[j, i] = new Field(3);
                    }
                    if (!(i == 3 && j == 0)&& !(i == 4 && j == 4) && !(i == 0 && j == 3))
                    m[j, i] = new Field(0);
                }
            }
        }

        static void Turn(Edward Edward,int length, Field[,] m)
        {
            length++;
            Edward.AI(Edward.X(),Edward.Y());
            System.Threading.Thread.Sleep(1000);
            System.Console.Clear();
          if (Edward.Needs_Update(m[Edward.X(),Edward.Y()].D_Sleep(), m[Edward.X(), Edward.Y()].D_Hunger(), m[Edward.X(), Edward.Y()].D_Health(), m[Edward.X(), Edward.Y()].D_Bored(), length) ==true )
            {
                
                Map_Show(m, Edward);
                Turn(Edward, length, m);
            }
        }

        static void Map_Show(Field[,] m, Edward e)
        {
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    if (i == e.X() && j == e.Y())
                    {
                        System.Console.Write(e.Draw());
                    }
                    else
                    {
                        System.Console.Write(m[i, j].Draw());
                    }

                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine("life: " + e.Life());
            System.Console.WriteLine("Hunger: " + e.Hunger());
            System.Console.WriteLine("Sleep: " + e.Sleep());
            System.Console.WriteLine("Boredom: " + e.Bored());
            if (e.Depression() == true) System.Console.WriteLine("Edek Ma Depresje!");
        }
    }
}
