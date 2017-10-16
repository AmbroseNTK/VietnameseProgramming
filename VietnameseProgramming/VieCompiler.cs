using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using VietnameseProgramming.Rules;

namespace VietnameseProgramming
{
    class VieCompiler
    {
        string sourceInput;
        string sourceOut;
        List<string> codeList;
        List<Rule> ruleSet;
        
        public string SourceInput { get => sourceInput; set => sourceInput = value; }
        public string SourceOut { get => sourceOut;}
        public VieCompiler()
        {
            codeList = new List<string>();
            ruleSet = new List<Rule>();
            ruleSet.Add(new Include());
            ruleSet.Add(new FunctionDeclare());
        }
        public float compile()
        {
            float accurancy = 0;
            sourceOut = "";
            foreach(Rule rule in ruleSet)
            {
                rule.CommandLine = sourceInput;
                rule.Execute();
                sourceOut += rule.Output;
            }
            return accurancy;
        }
    }
}
