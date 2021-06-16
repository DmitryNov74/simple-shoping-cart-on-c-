using System;
using System.Collections;
using System.Collections.Generic;

namespace Ruokakori
{
    class Program:Tuote
    {

        List<Tuote> koris = new List<Tuote>();

        public Program(string productName, int amount, double hinta) : base(productName, amount, hinta)
        {
        }


        public Program()
        {

        }

        public void LisaaTuote()
        {

            try
            {
                Console.WriteLine("Tuotteen nimi:");
                string tuote = Console.ReadLine();

                Console.WriteLine("Anna määrä:");
                int maara = int.Parse(Console.ReadLine());

                Console.WriteLine("Anna tuotteen hinta:");
                double hinta = double.Parse(Console.ReadLine());

                Tuote tuote1 = new Tuote(tuote, maara, hinta);
                koris.Add(tuote1);
            }catch(Exception)
            {
                Console.WriteLine("Hinta ja määrä pitää syöttää numerona");
            }
            

        }


        public void NaytaKori()
        {

            Console.WriteLine("***RUOKAKORI***");

            foreach (Tuote tuote1 in koris)

            {
                

                Console.WriteLine("TUOTE: " + tuote1.GetProductName);
                Console.WriteLine("MÄÄRÄ: " + tuote1.GetAmount);
                Console.WriteLine("HINTA: " + tuote1.GetHinta);
                
                double yhte = (tuote1.GetHinta * tuote1.GetAmount);

                Console.WriteLine("Yhttensä " + yhte.ToString("0.00") + " euroa");
                Console.WriteLine("-----------------------");
            }

        }



        public void PoistaTuote()
        {

            Console.WriteLine("***Mitä poistetaan?***");

            foreach (Tuote tuote1 in koris)
            {
                
                Console.WriteLine(tuote1.GetProductName);
                

                
            }

            Console.WriteLine("Kirjoita poistettava nimi:");


              

            foreach(Tuote tuote1 in koris)
            {
                
                string poista = Console.ReadLine();

                string poistettava = tuote1.GetProductName;

                if (poistettava.Equals(poista))
                {
                    
                    koris.Remove(tuote1);

                    if (koris.Count == 0)
                    {
                        Console.WriteLine("Ostoskori on tyhjä");
                    }
                    break;

                    

                }
                

            }

            


        }

        public void Kassalle()
        {
            double loppuLasku = 0;
            foreach (Tuote tuote1 in koris)
            {
                double yhte = (tuote1.GetHinta * tuote1.GetAmount);
                loppuLasku = loppuLasku + yhte;
                





            }
            Console.WriteLine("---------------------");
            Console.WriteLine("Maksettavaksi: " +loppuLasku.ToString("0.00") + " euroa");
            Console.WriteLine("---------------------");

        }

       


        static void Main(string[] args)
        {

            Program kori = new Program();
            int valinta = -1;

            do
            {
                Console.WriteLine("*****Tervetuloa kauppaan!*****");
                Console.WriteLine("1: Lisää tuote; 2: Katso korisi; 3: Poista tuote; 4: Poistu; 5: Kassalle");

                valinta = int.Parse(Console.ReadLine());

                if (valinta == 1)
                {
                    kori.LisaaTuote();
                }
                else if (valinta == 2)
                {
                    kori.NaytaKori();
                }
                else if (valinta == 3)
                {
                    kori.PoistaTuote();
                }
                else if (valinta == 5)
                {
                    kori.Kassalle();
                }
                else if(valinta == 4)
                {
                    break;
                }
            } while (valinta != 4);

        }
    }
}
