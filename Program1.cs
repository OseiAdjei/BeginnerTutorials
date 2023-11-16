using System;
//commented the above namespace to work on the next.
//namespace MyTutorials
//{
//class Program
//{
//    static void MyMethod()
//    {
//        Console.Write("What is your name?: ");
//        Console.WriteLine("\nYou cannot change your name hereafter, Thank you.");
//        string name = Console.ReadLine();

//        bool isStudent = GetYesNoAnswer("Are you a student?");

//        if (isStudent)
//        {
//            Console.WriteLine("Hello " + name + ", welcome to The Akwantuo Survey.");
//            Console.Write("Which school are you in?: ");
//            string school = Console.ReadLine();

//            Console.Write("Please enter your email: ");
//            string email = Console.ReadLine();

//            Console.Write("Please enter a recovery email: ");
//            string recoveryemail = Console.ReadLine();

//            bool joinClub = GetYesNoAnswer("Would you like to join this club?");

//            if (joinClub)
//            {
//                Console.WriteLine("Is this your email?: " + email + "?");
//                if (GetYesNoAnswer())
//                {
//                    Console.WriteLine("Congratulations! " + name + ", an " + email + " will be sent to you.");
//                }
//                else
//                {
//                    Console.Write("Please enter your phone number: ");
//                    string phone = Console.ReadLine();
//                    Console.WriteLine("Congratulations! " + name + ", a confirmation sms will be sent to " + phone);
//                }
//            }
//            else
//            {
//                Console.WriteLine("Thank you for shortly participating.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("You cannot go ahead with this survey!");
//        }
//    }

//    static bool GetYesNoAnswer(string question)
//    {
//        while (true)
//        {
//            Console.Write(question + " (yes/no): ");
//            string response = Console.ReadLine().Trim().ToLower();

//            if (response == "yes")
//            {
//                return true;
//            }
//            else if (response == "no")
//            {
//                return false;
//            }

//            Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
//        }
//    }

//    static bool GetYesNoAnswer()
//    {
//        return GetYesNoAnswer("");// Call the other overload with an empty question
//    }

//    static void Main(string[] args)
//    {
//        MyMethod();
//        // you can call a method twice.
//        //MyMethod();
//        Console.ReadKey();
//    }
//}

//namespace MethodParameters
//{
//    class ParametersArguments
//    {
//--------------------------------------------------------//
//SINGLE PARAMETER
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
//--------------------------------------------------------//




//--------------------------------------------------------//
//MULTIPLE PARAMETERS
//static void ThisMethod(string fname, int age)
//{
//    Console.WriteLine(fname + " Adjei is " + age + " years old.");
//}
//static void Main(string[] args)
//{
//    ThisMethod("Edward", 23);
//    ThisMethod("George", 12);
//    ThisMethod("Samuel", 19);

//    Console.ReadKey();
//}
//--------------------------------------------------------//



//--------------------------------------------------------//
// DEFAULT PARAMTER VALUE
//static void ThisMethod(string country = "Ghana")
//{
//    Console.WriteLine(country);
//}
//static void Main(string[] args) 
//{
//    ThisMethod("Angola");
//    ThisMethod();
//    ThisMethod("Burundi");

//    Console.ReadKey();
// A parameter with a default value, is often known as an "optional parameter".
// From the example above, country is an optional parameter and "Ghana" is the default value.
//--------------------------------------------------------//




//-------------------------------------------------------//
// RETURN VALUES
//static int NewMethod(int am)
//{
//    return am + 34;
//}
//static void Main(string[] args)
//{
//    Console.WriteLine(NewMethod(1));
//}
//outputs the sum of the two numbers
//--------------------------------------------------------//


//--------------------------------------------------------//
// Example returning the sum of a method's two parameters
//static int NewMethod(int a, int b)
//{
//    return a + b;
//}
//static void Main(string[] args)
//{
//    Console.WriteLine(NewMethod(1, 2));
//}
//--------------------------------------------------------//
//    }
//}

//created a logic to calculate a factorial
//        static long FactorialMethod(int a)
//        {
//            int result = 1;
//            while (a != 0)
//            {
//                result *= a;
//                a--;
//            }
//            return result;
//        }

//        long fact(int a)
//            {
//                long result = 1;
//    int count = 1;
//    while (count <= a) { 
//        result *= a;
//        count++;
//    }
//    return result;
//            }

//Console.WriteLine($"The factorial is {FactorialMethod(4)}");
namespace Methods
{
    //class NamedArguments
    //{
    //    static void MyMethod(string child1, string child3, string child2 = "Quaye")
    //    {
    //        Console.WriteLine("The youngest child is " + child3);
    //    }
    //    static void Main(string[] args)
    //    {
    //        MyMethod(child1: "Amina", child3: "Kwaku");
    //    }
    //}
    //class MethodOverload
    //{
    //    static int PlusMethodInt(int x, int y)
    //    {
    //        return x + y;   
    //    }
    //    static double PlusMethodDouble(double x, double y) 
    //    {
    //        return x + y;
    //    }
    //    static void Main(string[] args) 
    //    {
    //        int Num1 = PlusMethodInt(18, 2);
    //        double Num2 = PlusMethodDouble(18.5, 2.9);
    //        Console.WriteLine("Int: " + Num1);
    //        Console.WriteLine("Double: " + Num2);

    //        Console.ReadKey();
    //    }
    //}

    //Instead of defining two methods that should do the same thing, it is better to overload one.
    //In the example below, we overload the PlusMethod method to work for both int and double:

    class MethodOverload1
    {
        //static int PlusMethod(int x, int y)
        //{
        //    return x + y;
        //}
        //static double PlusMethod(double x, double y)
        //{
        //    return x + y;
        //}
        //static void Main(string[] args)
        //{
        //    int Num1 = PlusMethod(18, 2);
        //    double Num2 = PlusMethod(18.5, 2.9);
        //    Console.WriteLine("Int: " + Num1);
        //    Console.WriteLine("Double: " + Num2);

        //    Console.ReadKey();
        //    //Note: Multiple methods can have the same name as long as the number and/or type of parameters are different.
        //}

        //C# Conversions
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        string number = "true";
        //        //can use either of these:
        //        //byte b = byte.Parse(number);
        //        bool b = Convert.ToBoolean(number);
        //        Console.WriteLine(number);
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("The number could not be converted into a bool");
        //    }
        //}


        //C# Operators
        static void Main(string[] args)
        {
            int a = 1;
            int b = ++a;
            Console.WriteLine(a+b);
        }
    }
}