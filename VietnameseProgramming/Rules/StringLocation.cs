using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace VietnameseProgramming.Rules
{
    class StringLocation : Rule
    {
        public override void Execute()
        {
            output = "";
            MatchCollection matches = Regex.Matches(commandLine, @"chuỗi (.*)");
            foreach (Match m in matches)
            {
                for (int i = 1; i < m.Groups.Count; i++)
                {
                    Group g = m.Groups[i];
                    output += String.Format("\"{0}\"", g.Value);
                }

            }
        }
    }
}
