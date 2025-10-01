//-----------------------------------------------------------------
//    <copyright file="Lesson.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>01-10-2025</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Ernesto Casanova</author>
//-----------------------------------------------------------------

using Lesson_2.Models;
using Lesson_2.Services;
using Lesson_2.Utils;

namespace Lesson_2
{
    /// <summary>
    /// Summary description for Lesson.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main function
        /// </summary>
        /// <param name="args">string[]</param>
        static void Main(string[] args)
        {
            #region Main Code
            Calculator  calc = new Calculator();
            
            Console.WriteLine("Calculator OOP in C#");
            Console.WriteLine("Supports +");
            Console.WriteLine("Insert 'exit' to leave. \n");

            do
            {
                Console.WriteLine("Entry: ");
                string? op = Console.ReadLine()?.Trim();
                if (op.Equals("exit", StringComparison.OrdinalIgnoreCase)) break;

                try
                {
                    Operation operation = Parser.Parse(op);
                    double result = calc.Execute(operation);
                    Console.WriteLine($"Result: {result}\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            } while (true);
            #endregion
        }
    }
}