using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AlgorithmPrograms.Lists<char>;

namespace AlgorithmPrograms
{
    public class Balanced_Parentheses
    {
        public void BalanceChecker()
        {
            BalancedParentheses<char> balancedParantheses = new BalancedParentheses<char>();
            string expression = "(5+6)∗(7+8)/(4+3)(5+6)∗(7+8)/(4+3)(";
            char[] expressionArray = expression.ToCharArray();
            for (int i = 0; i < expressionArray.Length; i++)
            {
                if (expressionArray[i] == '(')
                {
                    balancedParantheses.Push(expressionArray[i]);
                    balancedParantheses.Display();
                }
                if (expressionArray[i] == ')')
                {
                    if (balancedParantheses.Peek() == ' ')
                    {
                        Console.WriteLine("Expression does not have a balanced Parentheses");
                        return;
                    }
                    if (balancedParantheses.Peek() == '(')
                    {
                        balancedParantheses.Pop();
                        balancedParantheses.Display();
                    }
                }
            }
            if (balancedParantheses.Peek() == ' ')
            {

                Console.WriteLine("Expression has a balanced Parentheses");
            }
            else
            {
                Console.WriteLine("Expression does not have a balanced Parentheses");
            }
        }
    }
}
