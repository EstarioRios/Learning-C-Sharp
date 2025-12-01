using System;
using System.Threading.Tasks.Sources;

class Program
{
    static void Main(string[] args)
    {

        string wellcome_text = "Wellcome to this console application";
        Console.WriteLine(wellcome_text);
        Console.WriteLine("Enter a Number: ");
        string input = Console.ReadLine();
        int number = Convert.ToInt32(input);

        if (number == 1)
        {
            Console.WriteLine($"your chosen number is {number}");
        }
        else if (number == 2)
        {
            Console.WriteLine($"your chosen number is {number}");
        }
    }
}


















////using System;
////using System.Threading.Tasks.Sources;

////class Program
////{
////    static void Main(string[] args)
////    {
////        //Console.WriteLine("Hello World!");
////        //Console.WriteLine(2 + 3); // integer
////        //Console.WriteLine("2" + "5"); // string
////        //Console.WriteLine("2 + 3 = " + 2 + 3); // completely string 
////        ///*Wellcome to the this part of coding*/


////        //string firstName = "Abolfazl";
////        //string lastName = "Khezri";
////        //int age = 17;
////        //char myChar = 'a';
////        //bool amMale = true;
////        //double myDoubleNumber = 0.13D; // I sould about 'D' from ChatGPT

////        //Console.Write("Hello Im " + firstName + " " + lastName + ".");
////        //Console.WriteLine("");
////        //Console.WriteLine(amMale);
////        //Console.WriteLine(age);
////        //Console.WriteLine(myDoubleNumber);


////        //const int myNumber = 10; // this variable will wont change anymore
////        //Console.WriteLine(myNumber);

////        //int firstNumber = 1, secondNumber = 2, thirdNumber = 3, fourthNumber = 4;
////        //Console.WriteLine(firstNumber + fourthNumber);

////        //string firstName = "Abolfazl", lastName = "Khezri";
////        //Console.WriteLine("My name is: " + firstName + " " + lastName);


////        //double myNum = 12.3;
////        //double myNum = 12.3D;
////        //float mySecondNum = 0.12F;

////        //int myNum = 341;
////        //long mySecondNum = myNum;
////        //long myThirdNum = 431;
////        //long myFourthNum = 1222222222222222232L;

////        //string myFirstNum = "12";
////        //int mySecondNum = Convert.ToInt32(myFirstNum);

////        //int firstNumber = 2;
////        //int secondNumber = 3;
////        //int thirdNumber = firstNumber + secondNumber;

////        ////Console.WriteLine("2 + 3 = " + thirdNumber.ToString());
////        //Console.WriteLine("2 + 3 = " + Convert.ToString(thirdNumber));

////    }
////}

//using System;
//using System.Threading.Tasks.Sources;
//class Program
//{
//    static void Main(string[] args)
//    {
//        //string wellcomeText = "Wellcome";
//        //Console.WriteLine("Write your First Name: ");
//        //string firstName = Console.ReadLine();
//        //Console.WriteLine("Write your Last Name");
//        //string lastName = Console.ReadLine();

//        ////Console.WriteLine("My name is " + firstName + " " + lastName);
//        //Console.WriteLine($"My name is {firstName} {lastName}");

//        bool amIaMan = true;
//        //Console.WriteLine(amIaMan);

//        //if (amIaMan == true)
//        //{
//        //    Console.WriteLine("Yes I'm a man");
//        //}
//        //else
//        //{
//        //    Console.WriteLine("No I'm not a man");
//        //}




//        // yeaaaaaaaaaaaaaaaaaaaaaaaaaaaa 

//        if (amIaMan == true)
//        {
//            Console.WriteLine("yes I'm man");
//        }
//        else if (amIaMan == false)
//        {
//            Console.WriteLine("no I'm woman");
//        }
//        else if (!amIaMan)
//        {
//            Console.WriteLine("there is no Male/NoMale for you");
//        }
//    }
//}