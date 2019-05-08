using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLab
{
    class CountryController
    {
        public List<Country> CountryDB = new List<Country>();

        public void CountryAction(Country c)
        {
            new CountryView(c).Display();
        }

        public void WelcomeAction()
        {
            TestData(CountryDB);

            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:\n");
            new CountryListView(CountryDB).Display();
           
            int index = UserInput.GetUserInputAsInteger("");

            if(CountryDB.Count > 0 && index >= 0 && index < CountryDB.Count)
            {
                CountryAction(CountryDB[index]);
            }
            
        }

        private void TestData(List<Country> countries)
        {
            Country country = new Country();

            country.Colors = new List<string>(){ "red", "blue", "white" };
            country.Name = "America";
            country.Continent = "North America";

            countries.Add(country);

            country = new Country();
            country.Colors = new List<string>() { "green", "black", "yellow" };
            country.Name = "Jamaica";
            country.Continent = "North America";

            countries.Add(country);

            country = new Country();
            country.Colors = new List<string>() { "white", "red"};
            country.Name = "China";
            country.Continent = "Asia";

            countries.Add(country);
        }
    }
}
