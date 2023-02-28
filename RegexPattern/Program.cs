using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            RegexPatternProblem pattern = new RegexPatternProblem();
            pattern.ValidateFirstName("Ritesh");
            pattern.ValidateLastName("Waykole");
            pattern.ValidateEmailID("abc.xyz@bridgelabz.co.in");
            Console.ReadLine();
        }
    }
}
