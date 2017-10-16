using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace VietnameseProgramming.Rules
{
    class VariableInitialization : Rule
    {
        public override void Execute()
        {
            output = "";
            double value = 0;
            string data = "";
            MatchCollection matches = Regex.Matches(commandLine, @"(.*) bằng (.*)|là (.*)|\= (.*)");
            
            foreach (Match m in matches)
            {
                for (int i = 1; i < m.Groups.Count; i++)
                {
                    Group g = m.Groups[i];
                    if (i == 1)
                    {
                        output +=" "+g.Value;
                    }
                    if (i == 2)
                    {
                        if (data == "")
                        {
                            Rule getString = new StringLocation();
                            getString.CommandLine = g.Value;
                            getString.Execute();
                            if(getString.Output!="")
                                data += " = " + getString.Output;
                        }
                        if (data == "")
                        {
                            Rule getChar = new CharLocation();
                            getChar.CommandLine = g.Value;
                            getChar.Execute();
                            if (getChar.Output != "")
                                data += " = " + getChar.Output;
                        }
                        if (data == "")
                        {
                            if (g.Value.ToLower().Contains("rỗng"))
                                data += " = NULL";

                            if (g.Value.ToLower().Contains("đúng"))
                                data += " = true";

                            if (g.Value.ToLower().Contains("sai"))
                                data += " = false";
                        }
                        if (data == "")
                        {
                            output += " = " + g.Value;
                        }
                    }
                }

            }
            if (data != "")
                output += data+";\n";
            if (matches.Count == 0)
                output += commandLine + ";\n";
            
        }
    }
}
