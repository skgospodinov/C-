using System;
using System.Collections.Generic;

namespace _8._Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {

            //{[()]}
            string sequence = Console.ReadLine();
            Stack<char> parantheses = new Stack<char>();
            bool resut = true;

            foreach (var ch in sequence)
            {
                switch (ch)
                {
                    case '(':
                        parantheses.Push(')');
                        break;
                    case '{':
                        parantheses.Push('}');
                        break;
                    case '[':
                        parantheses.Push(']');
                        break;
                    case ')':                        
                    case '}':                      
                    case ']':
                        if (parantheses.Count == 0 || parantheses.Pop() != ch)
                        {
                            resut = false;
                        }
                        break;

                    default:
                        break;
                }
                if (!resut) 
                {
                    break;
                }
            }
            Console.WriteLine(resut? "YES" : "NO");

        }
    }
}
