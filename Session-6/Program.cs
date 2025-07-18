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

        public static void SumAndSubValues(int num1, int num2, out int sum, out int sub) {
                sum= num1 + num2;
                sub= num1 - num2;
        }
        
        public static int CalculateSumOfIndividualDigitsOfNumber(int num1)
        {
            int sum= 0;
            string convertedNumber= num1.ToString();
            for (int i = 0; i < convertedNumber.Length; i++) { 
                
                sum += int.Parse(convertedNumber[i].ToString());
            }


            return sum;
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


        }
    }
}
