using System;


namespace FirstLibrary
{
    public class clsCalculator
    {
        public int Result { get; set; }

        public int Add(int number)
        {
            return Result += number; 
        }
        
        public int Subtracct(int number)
        {
            return Result -= number;
        }
        
        public double Divide(int number)
        { 
            if(number !=0)
            {
                return Result /= number;
            }

            return Result /= 1;
        }
       
        public int Multiply(int number)
        {
            return Result *= number;
        }
        
        public void Clear()
        {
            Result = 0;
        }
        
        public void PrintResult()
        {
            Console.WriteLine("Result is : {0}",this.Result);
        }
    }
}
