using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;

namespace _09_MultiThreading
{
    internal class Program
    {
        static void Method1()
        {
            for(int i = 1 ; i <= 20 ; i++)
            {
                Thread.Sleep(500);

                Console.WriteLine("Method1 : " + i);
            }
        }
        static void Method2()
        {
            for(int i = 1 ; i <= 10 ; i++)
            {
                Thread.Sleep(500);

                Console.WriteLine("Method2 : " + i);
            }
        }

        static void MethodWithParm(string SourceName)
        {
            for (int i = 1; i <= 20; i++)
            {
                Thread.Sleep(500);

                Console.WriteLine($"{SourceName} : {i}" );
            }
        }


        static object obj = new object();
        static int MyCounter = 0;
        static void IncreesCounter(string SourseName)
        {

            for(int i = 1; i <= 10; i++)
            {
                lock (obj)
                {
                    MyCounter++;
                    Console.WriteLine($"{SourseName} : {MyCounter}");
                }
            }
            
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Method1);
            t1.Start();
            
            Thread t2 = new Thread(Method2);
            t2.Start();   
            

            // Method1 and Method2 must Complet first
            t1.Join();
            t2.Join();

            // Run this Line of Code after Method1 and Method2 done
            Console.WriteLine("Data 1 Completed Successfuly");

            // ----------------------------------------------
            // ------[ Thread with paramters method ]--------
            // ----------------------------------------------

            Thread t3 = new Thread(()=> MethodWithParm("MethodWithParm"));
            t3.Start();
            t3.Join();

            // ----------------------------------------------
            // ---[ Solve Race Condition in MultiThreading]--
            // ----------------------------------------------

            // Block Statment to control on Threads

            Thread t4 = new Thread(()=>IncreesCounter("M1"));
            t4.Start();
            
            Thread t5 = new Thread(() => IncreesCounter("M2"));
            t5.Start();

            t4.Join();
            t5.Join();

            Console.ReadKey();






        }
    }
}
