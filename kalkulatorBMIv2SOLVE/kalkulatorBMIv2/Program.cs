using kalkulatorBMIv2;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;

namespace KalkulatorBMIv2
{


    class Program
    {
        static void Main(string[] args)
        {
            string gender = "";
            bool endApp = false;
            double KG = 0;
            double cm = 0;
            double BMI = KG / Math.Pow(cm / 100.0, 2);
            Console.WriteLine("BMI calculator");
            Console.WriteLine("---------------\n");

            while (!endApp)
            {
                Console.Write("Podaj swoją wagę w kg: ");
                KG = Procesor.GetInformationFromUser();
                Console.Write("Podaj swój wzrost w cm: ");
                cm = Procesor.GetInformationFromUser();
                Console.Write("Podaj swoją płeć (K/M): ");
                gender = Procesor.GetSexFromUser(gender);
                BMI = Procesor.BMI(KG, cm);
                Procesor.ShowResult(gender, BMI);
                Procesor.GetSummary(gender, BMI);
                Console.WriteLine("------------------------\n");
                Console.Write("Naciśnij 'n' i Enter żeby zamknąć aplikację, albo inny dowolny guzik i enter żeby kontynuować: ");
                if (Console.ReadLine() == "n") endApp = true;
                Console.WriteLine("\n");

            }
            return;
        }
    }
}
