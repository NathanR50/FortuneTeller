using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ask and read the user's first name
            Console.WriteLine("What is your first name?: ");
            String firstName = Console.ReadLine();

            if (firstName.ToUpper() == "QUIT")
            {
                Console.WriteLine("Nobody likes a quitter!");
                Environment.Exit(0);
            }


            //Ask and read the user's last name
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            if (lastName.ToUpper() == "QUIT")
            {
                Console.WriteLine("Nobody likes a quitter!");
                Environment.Exit(0);
            }

            //Ask and read the user's age and create a variable to be used later for even or odd age
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();



            if (age.ToUpper() == "QUIT")
            {
                Console.WriteLine("Nobody likes a quitter!");
                Environment.Exit(0);
            }

            //This determines the user's time to retirement      

            Double yearsToRetirement = Convert.ToDouble(age);
            if
            (yearsToRetirement % 2 == 1)
                yearsToRetirement = 5;
            else if (yearsToRetirement % 2 == 0)
                yearsToRetirement = 10;

            //Ask and read the user's birth month in an interger
            Console.WriteLine("What is your birth month? Enter as a number.");
            string birthMonth = Console.ReadLine();

            if (birthMonth.ToUpper() == "QUIT")
            {
                Console.WriteLine("Nobody likes a quitter!");
                Environment.Exit(0);
            }

            //Ask and read the user's favorite color
            Console.WriteLine("What is your favorite ROYGBIV color?  If you don't know what a ROYGBIV color is, enter \"Help\": ");
            string favoriteColor = Console.ReadLine();


            while (favoriteColor.ToUpper() == "HELP")

            {
                Console.WriteLine("A ROYGBIV color includes Red, Orange, Yellow, Green, Blue, Indigo and Violet. Which do you choose?: ");
                favoriteColor = Console.ReadLine();
            }

            if (favoriteColor.ToUpper() == "QUIT")
            {
                Console.WriteLine("Nobody likes a quitter!");
                Environment.Exit(0);
            }

            Console.WriteLine("How many siblings do you have?: ");
            string numberOfSiblings = Console.ReadLine();

            if (numberOfSiblings.ToUpper() == "QUIT")
            {
                Console.WriteLine("Nobody likes a quitter!");
                Environment.Exit(0);
            }

            //This determines where the user will live


            if (numberOfSiblings == "0")
                numberOfSiblings = "Costa Rica";
            else if (numberOfSiblings == "1")
                numberOfSiblings = "Canada";
            if (numberOfSiblings == "2")
                numberOfSiblings = "Mexico";
            else if (numberOfSiblings == "3")
                numberOfSiblings = "Hawaii";
            if (numberOfSiblings == "3")
                numberOfSiblings = "";
            else
                numberOfSiblings = "Italy";



            //This determines the user's mode of transport
            if (favoriteColor.ToUpper() == "RED")
                favoriteColor = "Porsche";
            else if (favoriteColor.ToUpper() == "ORANGE")
                favoriteColor = "sailboat";
            else if (favoriteColor.ToUpper() == "YELLOW")
                favoriteColor = "pickup truck";
            else if (favoriteColor.ToUpper() == "GREEN")
                favoriteColor = "bicycle";
            else if (favoriteColor.ToUpper() == "BLUE")
                favoriteColor = "mo ped";
            else if (favoriteColor.ToUpper() == "INDIGO")
                favoriteColor = "bus";
            else if (favoriteColor.ToUpper() == "VIOLET")
                favoriteColor = "station wagon";

            //This determines the user's bank account

            //This find's the letter at a particular position in the user's birth month.





            int money;

            if (birthMonth == "1" || birthMonth == "2" || birthMonth == "3" || birthMonth == "4")

            {
                money = 40000;

            }

            else if (birthMonth == "5" || birthMonth == "6" || birthMonth == "7" || birthMonth == "8")
            {
                money = 100000;
            }

            else if (birthMonth == "9" || birthMonth == "10" || birthMonth == "11" || birthMonth == "12")

            {
                money = 1000000;
            }


            else
            {
                money = 0;
            }


            //This prints out the user's fortune:

            Console.WriteLine("" + firstName + " " + lastName + " will retire in " + yearsToRetirement + " years with " + "$" + money + " dollars in the bank, a vacation home in " + numberOfSiblings + " and ride in a " + favoriteColor + ".");



        }
    }
}
