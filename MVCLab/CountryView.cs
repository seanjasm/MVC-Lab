using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLab
{
    class CountryView
    {
        public Country DisplayCountry;

        public CountryView(Country country)
        {
            DisplayCountry = country;
        }


        public void Display()
        {
            Console.Write($"\nName: {DisplayCountry.Name} Continent: {DisplayCountry.Continent} " +
                $"Colors:");

            Console.ResetColor();

            for (int  i = 0; i < DisplayCountry.Colors.Count; i++)
            {
                
                if (i == 0)
                {
                    if (Enum.TryParse(DisplayCountry.Colors[i], true, out ConsoleColor result))
                    {
                        Console.BackgroundColor = result;
                    }
                }
                else if(i == 1)
                {
                    if (Enum.TryParse(DisplayCountry.Colors[i], true, out ConsoleColor result))
                    {
                        Console.ForegroundColor = result;                        
                    }
                }
                Console.Write(" " + DisplayCountry.Colors[i]);
            }
            Console.WriteLine("\n");
        }
    }
}
