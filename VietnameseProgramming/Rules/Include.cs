using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace VietnameseProgramming.Rules
{
    class Include : Rule
    {
        public override void Execute()
        {
            output = "";
            MatchCollection matches = Regex.Matches(commandLine, @"muốn (.*)");
            foreach (Match m in matches)
            {
                for (int i = 1; i < m.Groups.Count; i++)
                {
                    Group g = m.Groups[i];
                    if (g.Value.Contains("nhập") || g.Value.Contains("xuất"))
                        output += "#include<iostream>\n#include<conio.h>\n";
                    if (g.Value.Contains("chuỗi"))
                        output += "#include<string>\n";
                    if (g.Value.Contains("cửa sổ"))
                        output += "#include<Windows.h>\n";
                    if (output == "")
                        output += "#include<" + g.Value + ">\n";
                }
                
            }
        }
    }
}
