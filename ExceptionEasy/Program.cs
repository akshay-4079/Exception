using System;

namespace ExceptionEasy
{
    class MainClass
    {
        public class Student
        {

            public string StudentName { get; set; }
        }
        public static void Main(string[] args)
        {
            Student std = null;

            try
            {
                try
                {
           
                    std.StudentName = "";
                }
                catch (InvalidOperationException innerEx)
                {
                    Console.WriteLine("Inner catch");
                }
            }
            catch
            {
                Console.WriteLine("Outer catch");
            }
        }
    }
}
