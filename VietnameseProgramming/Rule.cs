using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietnameseProgramming
{
    abstract class Rule
    {
        protected string commandLine;
        protected string output;

        public string CommandLine { get => commandLine; set => commandLine = value; }
        public string Output { get => output;}
        public abstract void Execute();
    }
}
