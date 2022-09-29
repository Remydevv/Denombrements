using System;


namespace Denombrements
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 1;
            /// Choix du menu
            while (c != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                c = int.Parse(Console.ReadLine());

                ///Option quitter choix = 0
                if (c == 0) {Environment.Exit(0);}

                ///Calcule éléments si choix = 1
                if (c == 1)
                {
                    Console.Write("nombre total d'éléments à gérer = "); 
                    int n = int.Parse(Console.ReadLine()); 
                    // calcul de r
                    long r = 1;
                    for (int k = 1; k <= n; k++)
                        r *= k;
                    Console.WriteLine(n + "! = " + r);
                }
                else
                {
                    ///Calcule des éléments a gérer si choix = 2 
                    if (c == 2)
                    {
                        Console.Write("nombre total d'éléments à gérer = "); 
                        int t = int.Parse(Console.ReadLine()); 
                        Console.Write("nombre d'éléments dans le sous ensemble = "); 
                        int n = int.Parse(Console.ReadLine()); 
                        // calcul de r
                        long r = 1;
                        for (int k = (t - n + 1); k <= t; k++)
                            r *= k;
                        Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                    }
                    ///Calcule des éléments à gerer si choix = 3
                    else
                    {
                        Console.Write("nombre total d'éléments à gérer = "); 
                        int t = int.Parse(Console.ReadLine()); 
                        Console.Write("nombre d'éléments dans le sous ensemble = "); 
                        int n = int.Parse(Console.ReadLine()); 
                        // calcul de r1
                        long r1 = 1;
                        for (int k = (t - n + 1); k <= t; k++)
                            r1 *= k;
                        // calcul de r2
                        long r2 = 1;
                        for (int k = 1; k <= n; k++)
                            r2 *= k;
                        // calcul de r3
                        Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
