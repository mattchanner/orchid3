using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.Extensions.Logging;

using Orchid.Compiler;
using Orchid.Parser;
using Orchid.Web.Models;

namespace Orchid.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly OrchidCompiler compiler = new OrchidCompiler();

        [BindProperty(SupportsGet = true)]
        public TranspilationModel TranspilationModel { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            TranspilationModel.CSharpScript = Transpile(TranspilationModel.OrchidScript);
            var compilerResult = await compiler.RunAsync(TranspilationModel.OrchidScript);
            TranspilationModel.Output = compilerResult.Output;

            return Page();
        }

        private string Transpile(string source)
        {
            string transpiled = compiler.GenerateTranspiledCode(source);            
            var tree = CSharpSyntaxTree.ParseText(transpiled);
            return tree.GetRoot().NormalizeWhitespace().ToFullString();
        }
    }
}
