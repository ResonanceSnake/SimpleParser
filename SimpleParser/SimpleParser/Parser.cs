using System;

namespace SimpleParser
{
    public class Parser
    {
        static int lookAhead;
        const char plus = '+';
        const char minus = '-';

        public Parser()
        {
            lookAhead = Console.Read();
        }

        public void Expr()
        {
            Term();
            while(true)
            {
                if (lookAhead == plus)
                {
                    Match(plus);
                    Term();
                    Console.Write(plus);
                }
                else if (lookAhead == minus)
                {
                    Match(minus);
                    Term();
                    Console.Write(minus);
                }
                else return;
            }
        }

        public void Term()
        {
            if (Char.IsDigit((char)lookAhead))
            {
                Console.Write((char)lookAhead);
                Match(lookAhead);
            }
            else
            {
                throw new Exception("Syntax error");
            }
        }

        public void Match(int t)
        {
            if (lookAhead == t)
                lookAhead = Console.Read();
            else
                throw new Exception("Syntax error");
        }
    }
}
