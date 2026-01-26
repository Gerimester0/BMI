using System.Security.Cryptography.X509Certificates;

namespace BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Diak> list = new List<Diak>();
            var sorok = File.ReadAllLines("BMI.txt", System.Text.Encoding.Latin1).Skip(1);

            foreach (var sor in sorok)
            {
                Console.WriteLine(sor);
                string[] darabok = sor.Split(";");
                string nev = darabok[0];
                int eletkor = int.Parse(darabok[1]);
                int magassag = int.Parse(darabok[2]);
                int suly = int.Parse(darabok[3]);
                Diak d = new Diak(nev, eletkor, magassag, suly);
                list.Add(d);

            }
            foreach (var d in list)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("-------------");
            Console.WriteLine($"3. a feladat: A diákok száma: {list.Count}");

            Diak legmagasabb = list[0];
            foreach (var diak in list)
            {
                if (diak.Magasság > legmagasabb.Magasság)
                    legmagasabb = diak;
            }
            Console.WriteLine($"3. b feladat: A legmagasabb diák:" + $"{legmagasabb.Név}, magasság: {legmagasabb.Magasság} cm ");

            double atlag = 0;
            foreach (var diak in list)
            {
                atlag += diak.Testsúly;
            }
            atlag /= list.Count;
            Console.WriteLine($"5. a feladat: átlagos testsúly:"+ $"{atlag:F1} kg");

            int atlagsuly = 0;
            foreach (var d in list)
            {
                if (d.BMI() == "Normal")
                {
                    atlagsuly++;
                }
            }
      
            Console.WriteLine($"5. b feladat: egészséges diákok száma: {atlagsuly} darab");


            bool van = false;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Név == "Tóth Éva")
                {
                    van = true;
                    break;
                }
            }
            Console.WriteLine($"5.c feladat: "+"Van Tóth Éva? ");
            if (van == true)
                Console.WriteLine("Van Tóth Éva");

            else { Console.WriteLine("Nincs Tóth Éva"); }

        }
    }
}
