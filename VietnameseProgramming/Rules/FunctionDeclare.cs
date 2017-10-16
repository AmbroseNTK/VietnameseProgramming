using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace VietnameseProgramming.Rules
{
    class FunctionDeclare : Rule
    {
        public override void Execute()
        {
            output = "";
            MatchCollection matches = Regex.Matches(commandLine, @"công việc (.*?) cần làm((.|\n)*?)hoàn thành");
            string funcName = "";
            string funcBody = "";
            foreach (Match m in matches)
            {
                for (int i = 1; i < m.Groups.Count; i++)
                {
                    Group g = m.Groups[i];
                    if (i == 1)
                    {
                        if (g.Value.Contains("chính") || g.Value.Contains("quan trọng") || g.Value.Contains("main"))
                            funcName += "void main(){\n";
                        if (funcName == "")
                        {
                            Rule getFuncName = new FunctionParameters();
                            getFuncName.CommandLine = g.Value;
                            getFuncName.Execute();
                            funcName += getFuncName.Output;
                        }
                    }
                    if (i == 2)
                    {
                        //Process in a function
                        List<Rule> ruleSet = new List<Rule>();
                        ruleSet.Add(new VariableDeclare());
                        List<string> codeList = g.Value.Split('\n').ToList<string>();
                        foreach(string line in codeList)
                        {
                            foreach (Rule rule in ruleSet)
                            {
                                rule.CommandLine = line;
                                rule.Execute();
                                if(rule.Output!="")
                                    funcBody += "\t" + rule.Output;
                            }
                        }
                    }
                }

            }
            if (funcBody != "")
            {
                output = funcName + funcBody + "\n}\n";
            }

        }
    }
}
