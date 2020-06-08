using System;
using System.Collections.Generic;
using System.Text;

namespace kalkulatorBMIv2
{
    class Procesor
    {
        
        static public void GetSummary(string gender, double BMI)
        {
            if (gender == "K" || gender == "k")
            {
                Procesor.GetBMIWoman(BMI);
            }
            //Doing BMI maths for Man
            if (gender == "M" || gender == "m")
            {
                Procesor.GetBMIMan(BMI);
            }
        }

        static private void GetBMIWoman(double BMI)
        {
            if (BMI < 16)
            {
                Console.WriteLine("Jesteś wygłodzona.");
            }
            else if (BMI > 16.1 && BMI <= 17.0)
            {
                Console.WriteLine("Jesteś wychudzona.");
            }
            else if (BMI > 17.1 && BMI <= 18.5)
            {
                Console.WriteLine("Masz niedowagę.");
            }
            else if (BMI > 18.6 && BMI <= 25.0)
            {
                Console.WriteLine("Masz prawidłową wagę.");
            }
            else if (BMI > 25.1 && BMI <= 30.0)
            {
                Console.WriteLine("Masz nadwagę.");
            }
            else if (BMI > 30.1)
            {
                Console.WriteLine("Masz poważną nadwagę");
            }
        }
        static private void GetBMIMan(double BMI)
        {

            if (BMI < 16)
            {
                Console.WriteLine("Jesteś wygłodzony.");
            }
            else if (BMI > 16.1 && BMI <= 17.0)
            {
                Console.WriteLine("Jesteś wychudzony.");
            }
            else if (BMI > 17.1 && BMI <= 18.5)
            {
                Console.WriteLine("Masz niedowagę.");
            }
            else if (BMI > 18.6 && BMI <= 25.0)
            {
                Console.WriteLine("Masz prawidłową wagę.");
            }
            else if (BMI > 25.1 && BMI <= 30.0)
            {
                Console.WriteLine("Masz nadwagę.");
            }
            else if (BMI > 30.1)
            {
                Console.WriteLine("Masz poważną nadwagę");
            }
        }
  
        static public int GetInformationFromUser()
        {
            while (true)
            {
                //kg value
                

                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {

                    Console.WriteLine("Źle podałeś wartość wzrostu, spróbuj podać ją w centymetrach.\n - Szczegóły dotyczące błędu: " + e.Message);

                }
            }
        }

        static public string GetSexFromUser(string gender)
        {
            while (true)
            {
                try
                {
                    return Convert.ToString(Console.ReadLine());
                }
                catch (Exception e)
                {

                    Console.WriteLine("Podałeś nieprawidłową wartość dla płci, wybierz pomiędzy K- kobieta i M- mężczyzna.\n - Szczegóły dotyczące błędu: " + e.Message);

                }
            }
        }
        static public void ShowResult(string gender, double BMI)
        {
            
                if (gender == "M" || gender == "m")
                {
                    Console.WriteLine($"Pana BMI wynosi: {BMI}\n Co oznacza, że: \n");
                }
                else if (gender == "K" || gender == "k")
                {
                    Console.WriteLine($"Pani BMI wynosi: {BMI}\n Co oznacza, że: \n");
                }
        }
        static public double BMI(double KG, double cm)
        {
            double BMI =  KG / Math.Pow(cm / 100.0, 2);
            BMI = Math.Round(BMI, 2);
            return BMI;
        }
    }
}
