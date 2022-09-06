using System;
using System.Collections.Generic;
using System.IO;

namespace Elso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

           

            List<string> nevek = new List<string>();
            string[] sorok = File.ReadAllLines("nevsor.txt");
            //add sor
            for (int i = 0; i < sorok.Length; i++)
            {
                nevek.Add(sorok[i]);
            }
            //add tetel
            List<int> tetelek = new List<int>();
            for (int i = 1; i < 21; i++)
            {
                tetelek.Add(i);
            }
            Random rand = new Random();
            //Kiiras
            StreamWriter ir = new StreamWriter("sorsolas.txt");
            //nev
            for (int i = 0; i < nevek.Count; i++)
            {
                int szam = rand.Next(0, tetelek.Count);
                Console.WriteLine("{0}: {1}. témakör", nevek[i], tetelek[szam]);
                ir.WriteLine("{0}: {1}. témakör", nevek[i], tetelek[szam]);

                tetelek.RemoveAt(szam);
            }
           
            //tetel
            for (int i = 0; i < tetelek.Count; i++)
            {
                int szam = rand.Next(0, nevek.Count);
                Console.WriteLine("{0}: {1}. témakör", nevek[szam], tetelek[i]);
                ir.WriteLine("{0}: {1}. témakör", nevek[szam], tetelek[i]);
                nevek.RemoveAt(szam);
            }
            ir.Close();
            
            

            StreamWriter nevsor = new StreamWriter("nevsor.txt");
            {
                nevsor.WriteLine("Biró Barnabás");
                nevsor.WriteLine("Szécsényi Máté");
                nevsor.WriteLine("Pápai Botond Zsolt");
                nevsor.WriteLine("Rajcsányi Zsombor Levente");
                nevsor.WriteLine("Nyerges Martin");
                nevsor.WriteLine("Kovács Milán");
                nevsor.WriteLine("Lóth György");
                nevsor.WriteLine("Kozári Krisztián");
                nevsor.WriteLine("Mezei Attila");
                nevsor.WriteLine("Váradi Bertold");
                nevsor.WriteLine("Fábos Ervin");
                nevsor.WriteLine("Lenti János");
                nevsor.WriteLine("Ignácz Marcell");
                nevsor.WriteLine("Klauz Péter");
                nevsor.WriteLine("Kőváari Sándor");

            }
            nevsor.Close();
        }
    }
}
