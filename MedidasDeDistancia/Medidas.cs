using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidasDeDistancia
{
    public class Medidas
    {


        public double metros { get; set; }
        public double km { get; set; }
        public double millas { get; set; }
        public double centimetros { get; set; }

        public string opcion1 { get; set; }
        public string opcion2 { get; set; }


        public double ConversionMetros()
        {
            if (opcion2 == "Kilometros")
            {
                return metros / 1000;
            }
            else if(opcion2 == "Millas")
            {
                return metros / 16091;
            }
            else if( opcion2 == "Centimetros")
            {
                return metros * 100; ;
            }

            return 0;
        }

        public double ConversionKilometros()
        {
            if (opcion2 == "Metros")
            {
                return km * 1000;
            }
            else if (opcion2 == "Millas")
            {
                return km / 1.609;
            }
            else if (opcion2 == "Centimetros")
            {
                return km * 100000;
            }

            return 0;
        }

        public double ConversionMillas()
        {
            if (opcion2 == "Metros")
            {
                return millas * 1609.34;
            }
            else if (opcion2 == "Kilometros")
            {
                return millas * 1.60934;
            }
            else if (opcion2 == "Centimetros")
            {
                return millas * 160934;
            }

            return 0;
        }


        public double ConversionCenti()
        {
            if (opcion2 == "Metros")
            {
                return centimetros / 100;
            }
            else if (opcion2 == "Kilometros")
            {
                return centimetros / 100000;
            }
            else if (opcion2 == "Millas")
            {
                return centimetros / 160900;
            }

            return 0;
        }



        


        public double Conversion()
        {
            switch (opcion1)
            {
                case "Kilometros":
                {

                        return ConversionKilometros();
                }
                case "Metros":
                {

                        return ConversionMetros(); 

                        
                }
                case "Millas":
                {
                        
                        return ConversionMillas();


                }
                case "Centimetros":
                {
                        
                        return ConversionCenti();


                }
            }

            return 0;
        }
        

    }
}
