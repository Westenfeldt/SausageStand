using System;

namespace SausageStand
{
    class Program
    {
        static void Main(string[] args)
        {

            int forsøg = 0;

            while(forsøg < 2) {
                forsøg++;
            Console.WriteLine("Velkommen til pølseboden");

            double pølse = 18.50;
            double brød = 3.75;

            Console.WriteLine("Hvor mange pølser vil du købe?");

            int pølseantal = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Hvor mange brød vil du købe?");

            int brødantal = Convert.ToInt16(Console.ReadLine());

            //Beregning
            
            while(pølseantal > 50 || brødantal > 50 || pølseantal < 0 || brødantal < 0) {

                Console.WriteLine("Du må højst købe 50 pølser eller brød");
                Console.WriteLine("Hvor mange pølser vil du købe?");

                pølseantal = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Hvor mange brød vil du købe?");

                brødantal = Convert.ToInt16(Console.ReadLine());

                

                }
            

            Console.WriteLine("Hvad betaler du i kontant?");

            double betal = Convert.ToDouble(Console.ReadLine());


            if (pølseantal > 10)
            {
                double totalpris = pølse * pølseantal + brød * brødantal;
                double totalprisrabat = totalpris - (totalpris * 0.10);
                double pengetilbage = betal - totalprisrabat;

                Console.WriteLine("Prisen er {0} kr", totalprisrabat);
                Console.WriteLine("Du vil få {0} kr tilbage", pengetilbage);
            }
            else
            {
                double totalpris = pølse * pølseantal + brød * brødantal;
                double pengetilbage = betal - totalpris;

                Console.WriteLine("Prisen er {0} kr", totalpris);
                Console.WriteLine("Du vil få {0} kr tilbage", pengetilbage);
            }
                //STOR WHILE SLUT 
                Console.WriteLine("Vil du fortsætte?");
                string svar = Console.ReadLine();

                if (svar == "n")
                {
                    Environment.Exit(0);
                }else if (svar == "j")
                {
                    Console.WriteLine("Dette var forsøg nummer {0}", forsøg);
                    
                }


                
            }




        }
    }
}
