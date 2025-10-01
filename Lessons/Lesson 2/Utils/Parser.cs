//-----------------------------------------------------------------
//    <copyright file="Lesson.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>01-10-2025</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Ernesto Casanova</author>
//-----------------------------------------------------------------

using System;
using System.Globalization;
using Lesson_2.Enums;
using Lesson_2.Models;

namespace Lesson_2.Utils
{
    /// <summary>
    /// Provides utility methods to parse text input into <see cref="Operation"/> objects.
    /// </summary>
    [CLSCompliant(true)]
    public class Parser
    {
        /// <summary>
        /// Parses a string expression into an <see cref="Operation"/> instance.
        /// </summary>
        /// <param name="input">
        /// The input string containing a mathematical expression (e.g., "5 + 3").
        /// The format must be: &lt;operand&gt; &lt;operator&gt; &lt;operand&gt;.
        /// </param>
        /// <returns>
        /// An <see cref="Operation"/> object representing the parsed expression.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// Thrown when the operator is invalid or not supported.
        /// </exception>
        /// <exception cref="FormatException">
        /// Thrown when the input format is invalid or the numeric values cannot be parsed.
        /// </exception>
        public static Operation Parse(string input)
        {
            var parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length == 3)
            {
                double left = ParseDouble(parts[0]);
                double right = ParseDouble(parts[2]);
                string op = parts[1];

                return op switch
                {
                    "+" => new Operation(left, right, Operator.Add),
                    _ => throw new ArgumentException($"Invalid operator: {op}")
                };
            }

            throw new FormatException("Invalid format. Expected: '<number> <operator> <number>'.");
        }

        /// <summary>
        /// Parses a string into a <see cref="double"/> value using invariant culture.
        /// </summary>
        /// <param name="part">The string representing the number.</param>
        /// <returns>The parsed numeric value.</returns>
        /// <exception cref="FormatException">
        /// Thrown when the string is not a valid number.
        /// </exception>
        private static double ParseDouble(string part)
        {
            if (double.TryParse(part, NumberStyles.Any, CultureInfo.InvariantCulture, out var result))
                return result;

            throw new FormatException($"Invalid numeric value: '{part}'");
        }
    }
}
