using System;

namespace Method_Overloads
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add(2,3);

            //Add(2,3);

            Add(2,3);
        }

       public static double Add(double a, double b,)
        {
            return a + b;
        }


        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static string Add(bool a, int b, int c)
        {
            var answer = b + c;
            if (a == true & answer > 1)
            {
                return $"{answer} dollars";
            }
            else if (a == true & answer < 1)
            {
                return $"{answer} dollars";

            }
            else if (a == true & answer == 1)
            {
                return $"{answer} dollars";
            }
            else
            {
                return answer.ToString();
            }
            
            











        }

    }
}
