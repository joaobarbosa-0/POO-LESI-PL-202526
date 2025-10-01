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
using Lesson_2.Enums;
using Lesson_2.Models;

namespace Lesson_2.Services
{
    /// <summary>
    /// Represents a calculator capable of executing mathematical operations
    /// based on <see cref="Operation"/> and <see cref="Operator"/>.
    /// </summary>
    [CLSCompliant(true)]
    public class Calculator
    {
        /// <summary>
        /// Executes the specified mathematical operation.
        /// </summary>
        /// <param name="operation">
        /// The operation to be performed, including operands and operator.
        /// </param>
        /// <returns>The result of the mathematical operation.</returns>
        /// <exception cref="NotSupportedException">
        /// Thrown when the provided operator is not supported.
        /// </exception>
        public double Execute(Operation operation)
        {
            return operation.Operator switch
            {
                Operator.Add => operation.LeftOperand + operation.RightOperand,

                // You can extend support by adding:
                // Operator.Subtract => operation.LeftOperand - operation.RightOperand,
                // Operator.Multiply => operation.LeftOperand * operation.RightOperand,
                // Operator.Divide => operation.RightOperand != 0 
                //     ? operation.LeftOperand / operation.RightOperand 
                //     : throw new DivideByZeroException("Division by zero is not allowed."),

                _ => throw new NotSupportedException(
                    $"Operator '{operation.Operator}' is not supported.")
            };
        }
    }
}
