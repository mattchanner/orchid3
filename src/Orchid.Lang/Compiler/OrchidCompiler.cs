using System;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.CSharp.RuntimeBinder;

using Orchid.Parser;

namespace Orchid.Compiler
{
    public class OrchidCompiler
    {
        private OrchidTranspiler transpiler;

        private static readonly MetadataReference[] References =
        {
            MetadataReference.CreateFromFile(typeof(object).GetTypeInfo().Assembly.Location),
            MetadataReference.CreateFromFile(typeof(RuntimeBinderException).GetTypeInfo().Assembly.Location),
            MetadataReference.CreateFromFile(typeof(System.Runtime.CompilerServices.DynamicAttribute).GetTypeInfo().Assembly.Location),
            MetadataReference.CreateFromFile(typeof(ExpressionType).GetTypeInfo().Assembly.Location),
            MetadataReference.CreateFromFile(Assembly.Load(new AssemblyName("mscorlib")).Location),
            MetadataReference.CreateFromFile(Assembly.Load(new AssemblyName("System.Runtime")).Location)
        };

        public OrchidCompiler()
        {
            this.transpiler = new OrchidTranspiler();
        }

        public OrchidParser.ProgramContext GenerateAst(string input)
        {
            var inputStream = new AntlrInputStream(input);
            var lexer = new OrchidLexer(inputStream);
            var tokens = new CommonTokenStream(lexer);
            var parser = new OrchidParser(tokens);
            //parser.ErrorHandler = new BailErrorStrategy();
            return parser.program();
        }

        public string GenerateTranspiledCode(string inputText)
        {
            var program = this.GenerateAst(inputText);
            return transpiler.Transpile(program);
        }

        public  async Task<TranspilationResult> RunAsync(string input)
        {
            var result = new TranspilationResult();

            if (string.IsNullOrEmpty(input))
                return result;

            Stopwatch watch = new Stopwatch();
            watch.Start();

            try
            {
                ScriptOptions scriptOptions = ScriptOptions.Default;
                scriptOptions = scriptOptions.AddReferences(References);
                scriptOptions = scriptOptions.AddImports("System");

                var resultCode = this.GenerateTranspiledCode(input);
                if (resultCode == null)
                {
                    watch.Stop();
                    result.TimeElapsed = watch.Elapsed.ToString();
                    return result;
                }

                var outputStrBuilder = new StringBuilder();
                using (var writer = new StringWriter(outputStrBuilder))
                {
                    Console.SetOut(writer);
                    var scriptState = await CSharpScript.RunAsync(resultCode, scriptOptions);
                    result.Output = outputStrBuilder.ToString();
                }
            }
            catch (Exception ex)
            {
                result.Output = ex.Message;
            }
            finally
            {
                watch.Stop();
                result.TimeElapsed = watch.Elapsed.ToString();
            }
            return result;
        }
    }
}
