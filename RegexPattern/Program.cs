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
            pattern.ValidatePhoneNo("91 3265981235");
            pattern.ValidatePassWord("1236afuvp");
            pattern.ValidateUpperCase("Fujhtjbf");
            Console.ReadLine();
        }
    }
}
