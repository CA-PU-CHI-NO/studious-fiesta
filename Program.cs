using System;

namespace Pract1
{
    class Program
   /* {
        static void Main(string[] args)
        { 
        }
    }*/
    {
        private int nom;
        private string data;
        private float summ;

        public Program(string data, int nom, float summ)
        {
            this.nom = nom;
            this.data = data;
            this.summ = summ;
        }
        public int Nom
        {
            get
            {
                return nom;
            }
            set
            {
                nom = value;
            }
        }
        public string Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
        public float Summ
        {
            get
            {
                return summ;
            }
            set
            {
                summ = value;
            }
        }
    }
}
