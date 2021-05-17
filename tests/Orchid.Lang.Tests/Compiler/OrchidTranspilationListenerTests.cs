using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

using FluentAssertions;

using Orchid.Compiler;
using Orchid.Parser;

using Xunit;

namespace Orchid.Lang.Tests.Compiler
{
    public class OrchidTranspilationListenerTests
    {
        [Theory]
        [
            InlineData("return 1 > 2", "return 1 > 2;"), // greater than
            InlineData("return 1 >= 2", "return 1 >= 2;"), // great than or equal to
            InlineData("return 1 < 2", "return 1 < 2;"), // less than
            InlineData("return 1 <= 2", "return 1 <= 2;"), // less than or equal to
            InlineData("return 1 != 2", "return 1 != 2;"), // not equals
            InlineData("return 1 = 2", "return 1 == 2;"), // equals
            InlineData("return 1 + 2", "return 1 + 2;"), // add
            InlineData("return 1 - 2", "return 1 - 2;"), // minus
            InlineData("return 1 * 2", "return 1 * 2;"), // mul
            InlineData("return 1 % 2", "return 1 % 2;"), // mod
            InlineData("return 1 / 2", "return 1 / 2;"), // divide
            InlineData("return 1 > 2 ? true : false", "return 1 > 2 ? true : false;"), // ternary operator
            InlineData("return true if 1 > 2 else false", "return 1 > 2 ? true : false;"), // ternary operator
            InlineData("return 10 unless x > 10 else 4", "return !(x > 10) ? 10 : 4;"), // inverted ternary operator
            InlineData("return 10 if x > 10 else 4", "return x > 10 ? 10 : 4;"),
            InlineData("return 'The' + 'Text'", "return \"The\" + \"Text\";"), // single quotes string
            InlineData("return \"The\" + \"Text\"", "return \"The\" + \"Text\";"), // double quoted string
            InlineData("return true or false", "return true || false;"), // or
            InlineData("return true || false", "return true || false;"), // or alt
            InlineData("return true and false", "return true && false;"), // and
            InlineData("return true && false", "return true && false;") // and alt
        ]
        public void Can_Transpile_Return_Statement(string orchidStatement, string expectedCSharpCode)
        {
            string transpiled = Transpile(orchidStatement);
            transpiled.Should().Be(expectedCSharpCode);
        }

        [Theory,
            InlineData("return function()", "return function();"),

            // assignment
            InlineData("x := 10", "x = 10;"),

            // assignment to array
            InlineData("x := [1, 2]", "x = new dynamic[] {1, 2};"),

            // return statement
            InlineData("return 10", "return 10;"),

            // if - then statement
            InlineData("if x > 10 then return true end", "if (x > 10) {return true;}"),

            // if - then - else statement
            InlineData("if x > 10 then return true else return false end", "if (x > 10) {return true;} else {return false;}"),

            // if - then - else if - else statement
            InlineData(@"
                if x > 10 then 
                    return true 
                elseif x < 3 then 
                    return -1 
                else 
                    return false 
                end", 
                "if (x > 10) {return true;} else if (x < 3) {return -(1);} else {return false;}"),

            // if - then - elseif - elseif - else statement
            InlineData(@"
                if x > 10 then 
                    return true 
                elseif x < 3 then 
                    return -1 
                elseif x < 2 then
                    return -2
                else 
                    return false 
                end",
                "if (x > 10) {return true;} else if (x < 3) {return -(1);} else if (x < 2) {return -(2);} else {return false;}"),
        ]
        public void Program_Verification(string program, string expected)
        {
            string transpiled = Transpile(program);
            transpiled.Replace("\n", string.Empty).Should().Be(expected);
        }

        private string Transpile(string source) => new OrchidCompiler().GenerateTranspiledCode(source);
    }
}
