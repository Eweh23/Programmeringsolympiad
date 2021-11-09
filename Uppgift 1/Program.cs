using System;

namespace Uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double kuvert_mvikt=0;
            double affisch_mvikt=0;
            double blad_mvikt=0;
            double kuvert_storlek= 229*324;
            double affisch_storlek= 297*420;
            double blad_storlek= 210*297;
            double vikt=0;
            double mm=1000000;
            
            Console.WriteLine("Kuvert?");
            kuvert_mvikt =double.Parse(Console.ReadLine());
            Console.WriteLine("Affisch?");
            affisch_mvikt =double.Parse(Console.ReadLine());
            Console.WriteLine("Blad?");
            blad_mvikt =double.Parse(Console.ReadLine());
            
            double kuvert_vikt=kuvert_storlek*(kuvert_mvikt/mm);
            double affisch_vikt=affisch_storlek*(affisch_mvikt/mm);
            double blad_vikt=blad_storlek*(blad_mvikt/mm);

            vikt=2*kuvert_vikt+2*affisch_vikt+blad_vikt;
            Console.WriteLine(vikt);
        }
    }
}
