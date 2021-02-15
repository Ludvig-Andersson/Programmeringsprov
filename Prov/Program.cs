using System;

namespace Prov
{
    class Program
    {
        static void Main(string[] args)
        {

            string fråga1 = "ja";




            while (fråga1 == "ja")
            {

                System.Console.WriteLine("Hur mycket HP vill du ha, du kan endast välja mellan 1-20?");




                string tal = Console.ReadLine();


                int resultat;


                while (resultat < 0 && resultat > 20)
                {
                    System.Console.WriteLine("Du skrev inte in ett nummer mellan 1-20");


                    bool lyckad = int.TryParse(tal, out resultat);

                    resultat = Console.ReadLine();
                }



                System.Console.WriteLine("HP " + tal);



                Console.ReadLine();

            }



            Console.ReadLine();


        }
    }
}
