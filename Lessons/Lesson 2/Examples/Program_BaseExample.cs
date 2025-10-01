// //-----------------------------------------------------------------
// //    <copyright file="Lesson.cs" company="IPCA">
// //     Copyright IPCA-EST. All rights reserved.
// //    </copyright>
// //    <date>01-10-2025</date>
// //    <time>21:00</time>
// //    <version>0.1</version>
// //    <author>Ernesto Casanova</author>
// //-----------------------------------------------------------------
//
// using Lesson_2.Models;
// using Lesson_2.Services;
// using Lesson_2.Utils;
//
// namespace Lesson_2
// {
//     /// <summary>
//     /// Summary description for Lesson.
//     /// </summary>
//     internal class Program
//     {
//         /// <summary>
//         /// Main function
//         /// </summary>
//         /// <param name="args">string[]</param>
//         static void Main(string[] args)
//         {
//             #region Main Code
//             
//             Console.WriteLine("Calculator use 4 + 3");
//
//             do
//             {
//                 Console.WriteLine("Entry: ");
//                 string? arguments = Console.ReadLine()?.Trim();
//                 if (string.IsNullOrEmpty(arguments))
//                 {
//                     throw new ArgumentNullException("Empty arguments");
//                 }
//                 
//                 string[] input = arguments.Split(' ');
//                 if (input.Length != 3)
//                 {
//                     throw new ArgumentException("Invalid arguments");
//                 }
//                 
//                 double left = double.Parse(input[0]);
//                 double right = double.Parse(input[1]);
//                 string op = input[2];
//
//                 switch (op)
//                 {
//                     case "+":
//                         double result = left + right;
//                         Console.WriteLine($"{left} + {right} = {result}");
//                         break;
//                     default:
//                         throw new ArgumentException("Invalid operator");
//                 }
//                 
//             } while (true);
//             #endregion
//         }
//     }
// }