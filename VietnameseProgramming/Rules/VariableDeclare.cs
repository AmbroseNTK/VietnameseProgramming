using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace VietnameseProgramming.Rules
{
    class VariableDeclare : Rule
    {
        public override void Execute()
        {
            output = "";
            MatchCollection matches = Regex.Matches(commandLine, @"tạo (.*) biến (.*) tên (.*)");
            int quality = 0;
            string type = "";
            string init = "";
            
            foreach (Match m in matches)
            {
                for (int i = 1; i < m.Groups.Count; i++)
                {
                    Group g = m.Groups[i];
                    if (i == 1)
                    {
                        if(g.Value=="một")
                        {
                            quality = 1;
                            continue;
                        }
                        int.TryParse(g.Value, out quality);
                    }
                    if (i == 2)
                    {
                        if (g.Value.Contains("nguyên"))
                        {
                            type = "int";
                            continue;
                        }
                        if (g.Value.Contains("thực"))
                        {
                            type = "float";
                            continue;
                        }
                        if(g.Value.Contains("ký tự")||g.Value.Contains("kí tự"))
                        {
                            type = "char";
                        }
                        if (g.Value.Contains("chuỗi"))
                        {
                            type = "char[]";
                        }
                    }
                    if (i == 3)
                    {
                        Rule getInit = new VariableInitialization();
                        getInit.CommandLine = g.Value;
                        getInit.Execute();
                        init += getInit.Output;
                    }
                }

            }
            output += type + init;
        }
    }
}
