using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Session_6
{
    internal class Program
    {
        public static void ChangeInputValue(int x)
        {
            x = 10;
        }

        public static void ChangeInputValueByRef(ref int x) {
            x = 10;
        }

        public static int SumArray(int[] arr)
        {
            int sum = 0;
            arr[0] = 100;
            for (int i = 0; i < arr.Length; i++) { 
            sum += arr[i];
            }
            return sum;

        }

        public static void SumAndSubValues(int num1, int num2, out int sum, out int sub) {
                sum= num1 + num2;
                sub= num1 - num2;
        }
        
        public static int CalculateSumOfIndividualDigitsOfNumber( int num1)
        {
            int sum= 0;
            string convertedNumber= num1.ToString();
            for (int i = 0; i < convertedNumber.Length; i++) { 
                
                sum += int.Parse(convertedNumber[i].ToString());
            }


            return sum;
        }
       
        public static void MinMaxArray(ref int[] arr, out int min, out int max)
        {
            if (arr is not null)
            {
                Array.Sort(arr);
                min = arr[0];
                max = arr[arr.Length - 1];
            }
            else
            {
                min = 0;
                max = 0;
                
            }
            
        }
        
        public static void Factorial(int input, out int result)
        {
            result = 1;
            if (input < 0)
            {
                throw new ArgumentOutOfRangeException("please enter the right number");
            }
            else if (input == 0 || input == 1)
            {
                result = input;
            }
            else
            {
                for (int i = input; i >= 2; i--)
                {
                    result *= i;
                }
            }
        }
        
        public static string ChangeChar(string input, int position, char newChar)
        {
            if(input is null)
            {
                Console.WriteLine("please enter input value");
                
            }
            if(position < 0 || position > input.Length)
            {
                Console.WriteLine(" the position is out of the range");
            }

            char[] inputChars= input.ToCharArray();
            inputChars[position] = newChar;

            return new string(inputChars);
        }
        
        static void Main(string[] args)
        {
            #region question 1
            //1-	Explain the difference between passing (Value type parameters) by value and by reference then
            //write a suitable c# example.
            /*
              
            - Passing by value: This passes a copy of the value. Any changes made inside the
            method do NOT affect the original variable.
             - Passing by reference: This passes reference of the variable.
                Changes made inside the method DO affect the original variable.
             */



            //int A = 20;
            //Console.WriteLine($"brfore change {A}"); // A= 20
            //ChangeInputValue(A);
            //Console.WriteLine($"after change {A}"); // A= 20



            //Console.WriteLine($"brfore change {A}"); // A= 20
            //ChangeInputValueByRef(ref A);
            //Console.WriteLine($"after change {A}"); // A= 10

            #endregion

            #region question 2
            // 2-	Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            /*
             - by value: passes a copy of the reference and modifying will affect the original variable , if the the variable is reassigned the original reference will be not effected (outside the method)
            - by ref: passes the original reference, modifying will affect the original variables,if the the variable is reassigned the original reference will be  effected (outside the method)
             */

            int[] ints = { 1, 2, 3, 4, 5 };
            Console.WriteLine($"before modification: {ints[0]}"); // 1
            int result= SumArray(ints);

            Console.WriteLine($"sum is: {result}"); //114
            Console.WriteLine($"after modification: {ints[0]}");// 100

            #endregion

            #region question 3
            // 3-	Write a c# Function that accept 4 parameters from user and return result of summation
            // and subtracting of two numbers
            /*
            int A = 10, B = 5, sumNumbers, subNumbers;
           
            SumAndSubValues(A,B, out sumNumbers, out subNumbers);
            Console.WriteLine($"sum: {sumNumbers}, sub:{subNumbers}");

            */
            #endregion

            #region question 4
            /*
             * 4-	Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
        Output should be like 
        Enter a number: 25                                                                                            
        The sum of the digits of the number 25 is: 7
             */
            /*
            Console.WriteLine("Enter a number: ");
            int input = int.Parse(Console.ReadLine());
            int result = CalculateSumOfIndividualDigitsOfNumber(input);
            Console.WriteLine($"the result is {result}");
            */
            #endregion

            #region question5
            // Create a function named "IsPrime", which receives an integer number and retuns true if it is prime,
            // or false if it is not:

            #endregion

            #region question 6
            //Create a function named MinMaxArray, to return the minimum and maximum values stored in an array,
            //using reference parameters

            /*
            int[] numbers = { 4, 8, 1, 6, 9, 2 };
            MinMaxArray(ref numbers, out int minValue, out int maxValue);
            Console.WriteLine($"min value: {minValue}, max alue: {maxValue}");
            */
            #endregion

            #region question 7
            //7-	Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            /*
            Console.WriteLine("please enter the number");
            bool isValidInput = int.TryParse(Console.ReadLine(),out int num);
            if (isValidInput) {
                Factorial(num, out int result);
                Console.WriteLine($"Factorial of {num} is: {result}");
            }
            else {
                Console.WriteLine("please enter integar");
            }
            */
            #endregion

            #region question 8
            //8-	Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of
            //a string, replacing it with a different letter
            /*
            string result = ChangeChar("Ahmed", 8, 'b');
            Console.WriteLine($"the original word: Ahmed, the updated word: {result}");
            */


            #endregion
        }
    }
}
