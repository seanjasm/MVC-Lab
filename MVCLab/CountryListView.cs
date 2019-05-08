using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLab
{
    class CountryListView
    {
        public List<Country> Countries;

        public CountryListView(List<Country> countries)
        {
            Countries = countries;
        }

        public void Display()
        {
            for(int i = 0; i < Countries.Count; i++)
            {
                Console.WriteLine($"\t{i}........... {Countries[i].Name}");
            }
        }
    }
}
