using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class program
    {
        static void Main(string[] args)
        {
            start();
        Console.ReadKey();
        }
                                //Starting function
        static void start()
        {
            
            Console.WriteLine("Choose");
            Console.WriteLine("1-Round");
            Console.WriteLine("2-Normal");
            Console.WriteLine("3-Compare");
            Console.WriteLine("4-instructions");
            String choice = Console.ReadLine();
            if (choice == "instructions")
            {
                How();
            }
            if(choice == "Round" || choice == "round")
            {
                Round();
            }
            if(choice == "Normal" || choice == "normal")
            {
                Normal();
            }

            else if(choice == "Compare" || choice == "compare")
            {
                Compare();
            }
        }
                                    //Normal calculating function
        static void Normal()
        {
            double num1;
            double num2;
            double result;
            
            Console.WriteLine("Do you want to use opereators or square root");
            Console.WriteLine("Write o for operators and s for square root ");
            String Answer = Console.ReadLine();

            if (Answer == "s")
            {
                Console.WriteLine("The number: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                result = Math.Sqrt(num1);
                Console.WriteLine("The square root of " + num1 + " is " + result);
            }
            
            if (Answer == "o")
            {
                Console.WriteLine("First number: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Choose");
                Console.WriteLine("multiply or add or subtract or divide or power");
                String answer = Console.ReadLine();
                if(answer == "multiply")
                {
                    result = num1 * num2;
                    Console.WriteLine("The result is " + result);
                }
                if(answer == "add")
                {
                    result = num1 + num2;
                    Console.WriteLine("The result is " + result);
                }
                if(answer == "subtract")
                {
                    result = num1 - num2;
                    Console.WriteLine("The result is " + result);
                }
                if(answer == "divide")
                {
                    result = num1 / num2;
                    Console.WriteLine("The result is " + result);
                }
                if(answer == "power")
                {
                    result = Math.Pow(num1, num2);
                    Console.WriteLine("The result is " + result);
                }

            }
            Console.WriteLine("Reause ?");
            String retry = Console.ReadLine();
            if (retry == "yes"){
                start();
            }else{
            Console.ReadKey();
            }
        }  
                                //Rounding functiion
        static void Round()
        {
            double num;
            double result2;

            Console.WriteLine("If you wanna round up write up");
            Console.WriteLine("if you wanna round normaly write normal");
            String Answer2 = Console.ReadLine();
            if (Answer2 == "up"){
                Console.WriteLine("The number: ");
                num = Convert.ToDouble(Console.ReadLine());
                result2 = Math.Ceiling(num);
                Console.WriteLine("The result is: " + result2);
            }
            if (Answer2 == "normal"){
                Console.WriteLine("The number: ");
                num = Convert.ToDouble(Console.ReadLine());
                result2 = Math.Round(num);
                Console.WriteLine("The result is: " + result2);
            }
            Console.WriteLine("Reause ?");
            String retry = Console.ReadLine();
            if (retry == "yes"){
                start();
            }else{
                Console.ReadKey();
            }
        } 
                            //Comparing function
        static void Compare()
        {
            double number1;
            double number2;
            double result3;

            Console.WriteLine("Choose");
            Console.WriteLine("Write bigger to know what number is bigger");
            Console.WriteLine("Write smaller to know what number is smaller");
            Console.WriteLine("Write absolute for the absolute value");
            String answer3 = Console.ReadLine();

            if(answer3 == "bigger")
            {
                Console.WriteLine("First number ");
                number1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Second number ");
                number2 = Convert.ToDouble(Console.ReadLine());
                result3 = Math.Max(number1, number2);
                Console.WriteLine("The bigger number is " + result3);
            }
            if(answer3 == "smaller")
            {
                Console.WriteLine("First number ");
                number1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Second number ");
                number2 = Convert.ToDouble(Console.ReadLine());
                result3 = Math.Min(number1, number2);
                Console.WriteLine("The smaller number is " + result3);
            }
            if (answer3 == "absolute")
            {
                Console.WriteLine("The number ");
                number1 = Convert.ToDouble(Console.ReadLine());
                result3 = Math.Abs(number1);
                Console.WriteLine("The absolute value of " + number1 + " is " + result3);
            }
            Console.WriteLine("Reause ?");
            String retry = Console.ReadLine();
            if (retry == "yes"){
                start();
            }else {
                Console.ReadKey();
            }
        }
                                //Instructions
        static void How()
        {
            Console.WriteLine("---The normal calculator is used for");
            Console.WriteLine("adding");
            Console.WriteLine("multiplying");
            Console.WriteLine("dividing");
            Console.WriteLine("subtracting");
            Console.WriteLine("and power");
            Console.WriteLine("you first insert two numbers and then choose what to do with them");
            Console.WriteLine("---the rounding calculator can round up and down");
            Console.WriteLine("you will choose the type of rounding and then the number to round");
            Console.WriteLine("---The comparing calculator you choose to compare which number is");
            Console.WriteLine("bigger or smaller or get the absolute value of it");
            Console.WriteLine("---To reuse the calculator when it asks you the question");
            Console.WriteLine("reuse write yes but if you dont want write any thing then ckick");
            Console.WriteLine("any button");
            Console.WriteLine("--Go back?");
            String retry = Console.ReadLine();
            if (retry == "yes"){
                start();
            }else {
                Console.ReadKey();
            }
        }
    }
}