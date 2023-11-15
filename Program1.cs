using System;
//commented the above namespace to work on the next.
//namespace MyTutorials
//{
//    class Program
//    {
//        static void MyMethod()
//        {
//            Console.Write("What is your name?: ");
//            Console.WriteLine("\nYou cannot change your name hereafter, Thank you.");
//            string name = Console.ReadLine();

//            bool isStudent = GetYesNoAnswer("Are you a student?");

//            if (isStudent)
//            {
//                Console.WriteLine("Hello " + name + ", welcome to The Akwantuo Survey.");
//                Console.Write("Which school are you in?: ");
//                string school = Console.ReadLine();

//                Console.Write("Please enter your email: ");
//                string email = Console.ReadLine();

//                Console.Write("Please enter a recovery email: ");
//                string recoveryemail = Console.ReadLine();

//                bool joinClub = GetYesNoAnswer("Would you like to join this club?");

//                if (joinClub)
//                {
//                    Console.WriteLine("Is this your email?: " + email + "?");
//                    if (GetYesNoAnswer())
//                    {
//                        Console.WriteLine("Congratulations! " + name + ", an " + email + " will be sent to you.");
//                    }
//                    else
//                    {
//                        Console.Write("Please enter your phone number: ");
//                        string phone = Console.ReadLine();
//                        Console.WriteLine("Congratulations! " + name + ", a confirmation sms will be sent to " + phone);
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Thank you for shortly participating.");
//                }
//            }
//            else
//            {
//                Console.WriteLine("You cannot go ahead with this survey!");
//            }
//        }

//        static bool GetYesNoAnswer(string question)
//        {
//            while (true)
//            {
//                Console.Write(question + " (yes/no): ");
//                string response = Console.ReadLine().Trim().ToLower();

//                if (response == "yes")
//                {
//                    return true;
//                }
//                else if (response == "no")
//                {
//                    return false;
//                }

//                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
//            }
//        }

//        static bool GetYesNoAnswer()
//        {
//            return GetYesNoAnswer("");// Call the other overload with an empty question
//        }

//        static void Main(string[] args)
//        {
//            MyMethod();
//            // you can call a method twice.
//            //MyMethod();
//            Console.ReadKey();
//        }
//    }
//}
namespace MethodParameters
{
    class ParametersArguments
    {
        //single parameter
        //static void ThisMethod(string fname)
        //{
        //    Console.WriteLine(fname + " Adjei");
        //}
        //static void Main(string[] args)
        //{
        //    ThisMethod("Edward");
        //    ThisMethod("Erica");
        //    ThisMethod("Michael");

        //    Console.ReadLine();
        //}

        //Multiple parameters
        static void ThisMethod(string fname, int age)
        {
            Console.WriteLine(fname + " Adjei is " + age + " years old.");
        }
        static void Main(string[] args)
        {
            ThisMethod("Edward", 23);
            ThisMethod("George", 12);
            ThisMethod("Samuel", 19);

            Console.ReadKey();
        }

    }
}