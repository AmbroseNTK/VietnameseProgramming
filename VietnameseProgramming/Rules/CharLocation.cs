using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace VietnameseProgramming.Rules
{
    class CharLocation:Rule
    {
        public override void Execute()
        {
            output = "";
            MatchCollection matches = Regex.Matches(commandLine, @"ký tự (.*)|kí tự (.*)");
            foreach (Match m in matches)
            {
                for (int i = 1; i < m.Groups.Count; i++)
                {
                    Group g = m.Groups[i];
                    output += "\'" + g.Value + "\'";
                }

            }
        }
    }
}
