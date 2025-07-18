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

            int A = 10, B = 5, sumNumbers, subNumbers;
           
            SumAndSubValues(A,B, out sumNumbers, out subNumbers);
            Console.WriteLine($"sum: {sumNumbers}, sub:{subNumbers}");


            #endregion

        }
    }
}
