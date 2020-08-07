using System;

namespace Build_your_own_website_
{
    class Program
    {
        static void Main(string[] args)
        {     
            //Asking for the Users Name
            Console.WriteLine("What is your name?");
            //Users Input
            string usersName = Console.ReadLine();

            //Printing the users name
            Console.WriteLine("If I'm correct, your name is: {0}?", usersName);
            //Seeing if it's the correct answer
            string usersAnswer = Console.ReadLine();

            var anInstanceOfMyClass = new Program();

            if (usersAnswer == "yes" || usersAnswer == "no") {
                anInstanceOfMyClass.YesOrNo(usersAnswer);
            }


            

        }

        void YesOrNo(string ans) {
            if (ans == "yes") {
                Console.WriteLine("YAY! I got it right, funny thing is, I always get this wrong somehow, so thank you!");
            } else if (ans == "no") {
                Console.WriteLine("Ok, please tell me your name.");
                string usersName2 = Console.ReadLine();
                Console.WriteLine("If I'm correct, your name is: {0}?", usersName2);
            } else {
                Console.WriteLine("Please input a valid answer (yes or no)");
            }
        }
    }
}
