namespace BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Diak> list = new List<Diak>();
            var sorok = File.ReadAllLines("BMI.txt",System.Text.Encoding.Latin1).Skip(1);

            foreach (var sor in sorok) 
            {
                Console.WriteLine(sor);
                string[] darabok = sor.Split(";");
                string nev = darabok[0];
                int eletkor = int.Parse(darabok[1]);
                int magassag = int.Parse(darabok[2]);
                int suly = int.Parse(darabok[3]);
                Diak d = new Diak(nev,eletkor,magassag,suly);
                list.Add(d);

            }
        }
    }
}
