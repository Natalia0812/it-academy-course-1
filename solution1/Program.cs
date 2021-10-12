using System;

namespace solution1
{
    class Program
    {
        static void Main(string[] args)
        {

           Console.Write("Введите  число гвоздей - Q: ");
            int Q = Convert.ToInt32(Console.ReadLine());
         
                                
            if (Q <= 10)
            {
                if (Q != 0)
                {
                    Console.Write("Введите  число ударов - D: ");
                    int D = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine( );

                    if (D <= 5)
                    {
                            for (int i = 1; i <= Q; i++)
                              {
                                 for (int j = 1; j <= D; j++)
                                 {
                                      Console.WriteLine("Вбиваем гвоздь " + i + " удар " + j);
                                
                                 }
                                
                                    if (i == Q)
                                        break;
                                   Console.WriteLine("Берем новый гвоздь ");
                                   Console.WriteLine();
     
                            }
                        Console.WriteLine("Больше гвоздей нет ");
                    } 
                    else
                    { Console.WriteLine("неверные входные данные"); }
                }
                else
                { Console.WriteLine("неверные входные данные"); }
            }
            else
            { Console.WriteLine("неверные входные данные"); }
        }
    }
}
