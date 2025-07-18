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



            int A = 20;
            Console.WriteLine($"brfore change {A}"); // A= 20
            ChangeInputValue(A);
            Console.WriteLine($"after change {A}"); // A= 20



            Console.WriteLine($"brfore change {A}"); // A= 20
            ChangeInputValueByRef(ref A);
            Console.WriteLine($"after change {A}"); // A= 10

            #endregion
        }
    }
}
