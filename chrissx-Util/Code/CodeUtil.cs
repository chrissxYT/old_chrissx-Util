using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace chrissx_Util.Code
{
    public static class CodeUtil
    {
        public static CompilerResults Compile(string[] assemblys, string file, string source, string version)
        {
            return new CSharpCodeProvider(new Dictionary<string, string>() { { "CompilerVersion", version } }).CompileAssemblyFromSource(new CompilerParameters(assemblys, file, true)
            {
                GenerateExecutable = true
            }, source);
        }
    }
}
