using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    public class Diak
    {
        public string Név { get; set; }
        public int Életkor { get; set; }

        public int Magasság { get; set; }

        public int Testsúly { get; set; }

        public Diak(string név, int életkor, int magasság, int testsúly)
        {
            Név = név;
            Életkor = életkor;
            Magasság = magasság;
            Testsúly = testsúly;
        }

        public override string? ToString()
        {
            return $"{Név} {Életkor}éves {Magasság}cm {Testsúly}kg";
        }
        public string BMI()
        {
            double magassagm = Magasság / 100.0;
            double bmi = Testsúly / (magassagm * magassagm);
                if (bmi < 18.5)
                {
                    return "sovány";
                }
                else if (bmi < 25)
                {
                    return "Normal";
                }
                else if (bmi < 30 )
                {
                    return "Túlsúly";
                }
                else
                {
                return "Elhízott";
            }
        }
        
        
    }
}
