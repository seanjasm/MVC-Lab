using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            while (repeat)
            {
                Console.Clear();
                new CountryController().WelcomeAction();

                repeat = UserInput.UserConfirmationPrompt("Continue(Y/N)? ");
            }
        }
    }
}
