using System;
using System.Collections.Generic;
using System.Globalization;

namespace Evaluator.Core
{
    public class ExpressionEvaluator
    {
        /// <summary>
        /// Evaluates an infix expression (supports +,-,*,/,^,(), decimals).
        /// </summary>
        public static double Evaluate(string infix)
        {
            var tokens = Tokenize(infix);
            var postfix = InfixToPostfix(tokens);
            return Calulate(postfix);
        }

        /// <summary>
        /// Tokenizes: groups digits and dot into full numbers and separates operators
        /// </summary>
        private static List<string> Tokenize(string infix)
        {
            var tokens = new List<string>();
            string numberBuffer = string.Empty;

            foreach (char c in infix)
            {
                if (char.IsDigit(c) || c == '.') // part of a number
                {
                    numberBuffer += c;
                }
                else if (!char.IsWhiteSpace(c)) // operator or parenthesis
                {
                    if (numberBuffer.Length > 0)
                    {
                        tokens.Add(numberBuffer);
                        numberBuffer = string.Empty;
                    }
                    tokens.Add(c.ToString());
                }
            }

            if (numberBuffer.Length > 0)
                tokens.Add(numberBuffer);

            return tokens;
        }

        /// <summary>
        /// Converts infix (list of tokens) to postfix (list of tokens).
        /// </summary>
        private static List<string> InfixToPostfix(List<string> tokens)
        {
            var stack = new Stack<string>();
            var postfix = new List<string>();

            foreach (string token in tokens)
            {
                if (IsOperator(token))
                {
                    if (token == ")")
                    {
                        while (stack.Count > 0 && stack.Peek() != "(")
                            postfix.Add(stack.Pop());
                        if (stack.Count == 0)
                            throw new Exception("Paréntesis desbalanceados.");
                        stack.Pop(); // remove "("
                    }
                    else
                    {
                        while (stack.Count > 0 && PriorityInfix(token) <= PriorityStack(stack.Peek()))
                        {
                            postfix.Add(stack.Pop());
                        }
                        stack.Push(token);
                    }
                }
                else
                {
                    // is number
                    postfix.Add(token);
                }
            }

            while (stack.Count > 0)
            {
                var top = stack.Pop();
                if (top == "(" || top == ")")
                    throw new Exception("Paréntesis desbalanceados.");
                postfix.Add(top);
            }

            return postfix;
        }

        private static bool IsOperator(string token)
            => token is "^" or "/" or "*" or "%" or "+" or "-" or "(" or ")";

        private static int PriorityInfix(string op) => op switch
        {
            "^" => 4,
            "*" or "/" or "%" => 2,
            "-" or "+" => 1,
            "(" => 5,
            _ => throw new Exception("Operador inválido."),
        };

        private static int PriorityStack(string op) => op switch
        {
            "^" => 3,
            "*" or "/" or "%" => 2,
            "-" or "+" => 1,
            "(" => 0,
            _ => throw new Exception("Operador inválido."),
        };

        /// <summary>
        /// Calculates result from the postfix list
        /// </summary>
        private static double Calulate(List<string> postfix)
        {
            var stack = new Stack<double>();
            foreach (string token in postfix)
            {
                if (IsOperator(token))
                {
                    if (stack.Count < 2)
                        throw new Exception("Expresión inválida.");
                    var op2 = stack.Pop();
                    var op1 = stack.Pop();
                    stack.Push(Calulate(op1, token, op2));
                }
                else
                {
                    // safe parse using invariant culture so "." works everywhere
                    if (!double.TryParse(token, NumberStyles.Float, CultureInfo.InvariantCulture, out var value))
                        throw new Exception($"Token no numérico: '{token}'");
                    stack.Push(value);
                }
            }

            if (stack.Count != 1)
                throw new Exception("Expresión inválida.");
            return stack.Peek();
        }

        private static double Calulate(double op1, string oper, double op2) => oper switch
        {
            "*" => op1 * op2,
            "/" => op1 / op2,
            "^" => Math.Pow(op1, op2),
            "+" => op1 + op2,
            "-" => op1 - op2,
            "%" => op1 % op2,
            _ => throw new Exception("Operador inválido."),
        };
    }
}
