using System;
namespace Ruokakori
{
    public class Tuote
    {
        private string tuoteNimi;
        private int maara;
        private double hinta;


        public Tuote(string productName, int amount, double hinta)
        {
            this.tuoteNimi = productName;
            this.maara = amount;
            this.hinta = hinta;

        }

                                                    
        public Tuote()
        {

        }


        public string SetPoductName
        {
            set
            {
                tuoteNimi = value;
            }
        }

        public string GetProductName
        {
            get
            {
                return tuoteNimi;
            }
        }

        public int SetAmount
        {
            set
            {
                maara = value;
            }
        }

        public int GetAmount
        {
            get
            {
                return maara;
            }
        }


        public double SetHinta
        {
            set
            {
                hinta = value;
            }
        }

        public double GetHinta
        {
            get
            {
                return hinta;
            }
        }
    }
}
