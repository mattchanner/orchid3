using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr4.Runtime.Misc;

using Microsoft.CodeAnalysis;

using Orchid.Parser;

namespace Orchid.Compiler
{
    public class OrchidTranspiler
    {
        private readonly StringBuilder buffer = new StringBuilder();

        public string Output => buffer.ToString();

        public void Reset()
        {
            buffer.Clear();
        }

        public string Transpile([NotNull] OrchidParser.ProgramContext context)
        {
            Reset();
            buffer.Append(ResolveStatementList(context.statementList()));
            return this.Output;
        }

        private string ResolveStatementList(OrchidParser.StatementListContext context, int indentation = 0)
        {
            var sequence = context.statement().Select(ResolveStatement).ToList();
            string indent = new string(' ', indentation);
            if (sequence.Any())
            {
                return sequence.Aggregate((a, b) => $"{indent}{a}\n{indent}{b}");
            }

            return string.Empty;
        }

        private string ResolveStatement(OrchidParser.StatementContext context)
        {
            if (context.iterationStatement() != null)
            {
                return ResolveIterationStatement(context.iterationStatement());
            }
            else if (context.returnStatement() != null)
            {
                return ResolveReturnStatement(context.returnStatement());
            }
            else if (context.assignmentStatement() != null)
            {
                return ResolveAssignmentStatement(context.assignmentStatement());
            }
            else if (context.declarationStatement() != null)
            {
                return ResolveDeclarationStatement(context.declarationStatement());
            }
            else if (context.ifStatement() != null)
            {
                return ResolveIfStatement(context.ifStatement());
            }
            else if (context.block() != null)
            {
                return ResolveBlockStatement(context.block());
            }
            else if (context.functionDeclaration() != null)
            {
                return ResolveFunctionDeclaration(context.functionDeclaration());
            }
            else if (context.printStatement() != null)
            {
                return ResolvePrintStatement(context.printStatement());
            }
            else if (context.functionCall() != null)
            {
                return ResolveFunctionCall(context.functionCall());
            }
            else if (context.prefixStatement() != null)
            {
                return ResolvePrefixStatement(context.prefixStatement());
            }
            else if (context.postfixStatement() != null)
            {
                return ResolvePostfixStatement(context.postfixStatement());
            }
            else if (context.assignmentOperatorStatement() != null)
            {
                return ResolveAssignmentOperatorStatement(context.assignmentOperatorStatement());
            }

            return "";
        }

        private string ResolveAssignmentOperatorStatement(OrchidParser.AssignmentOperatorStatementContext context)
        {
            string left = context.identifier().GetText();
            string op = context.assignmentOperators().GetText();
            string right = ResolveSingleExpression(context.singleExpression());

            return $"{left} {op} {right};";
        }

        private string ResolveDeclarationStatement(OrchidParser.DeclarationStatementContext context)
        {
            string identifier = context.identifier().GetText();
            string exp = ResolveSingleExpression(context.singleExpression());
            string type = InferType(context.singleExpression());
            return $"{type} {identifier} = {exp};";
        }

        private string InferType(OrchidParser.SingleExpressionContext context)
        {
            string leftSide = string.Empty;
            if (context is OrchidParser.ArrowFunctionExpressionContext arrow)
            {
                string arguments = 
                    Enumerable.Range(0, arrow.arrowFunctions().formalParameterList().Name().Length)
                        .Select(_ => "dynamic")
                        .Aggregate((a, b) => $"{a}, {b}");

                leftSide = $"System.Func<{arguments}, dynamic>";
            }
            else if (context is OrchidParser.LiteralExpressionContext le)
            {
                if (le.literal().NumericLiteral() != null)
                {
                    leftSide = "double";
                }
                else if (le.literal().BooleanLiteral() != null)
                {
                    leftSide = "bool";
                }
                else
                {
                    leftSide = "string";
                }
            }
            else
            {
                leftSide = "dynamic";
            }

            return leftSide;
        }

        private string ResolvePrintStatement(OrchidParser.PrintStatementContext context)
        {
            string exp = ResolveSingleExpression(context.singleExpression());
            return $"System.Console.WriteLine({exp});";
        }

        private string ResolveFunctionDeclaration(OrchidParser.FunctionDeclarationContext context)
        {
            string name = context.identifier().GetText();

            string args = context.formalParameterList() != null 
                ? ResolveFormalParameterList(context.formalParameterList())
                : string.Empty;

            if (context.expr != null)
            {
                string expr = ResolveSingleExpression(context.expr);
                return $"public static dynamic {name} ({args}) => {expr};";
            }
            else
            {
                string body = ResolveStatementList(context.statementList(), 4);

                bool hasReturnStatement =
                    context.statementList().GetText().Contains("return");

                string functionReturn = hasReturnStatement ? "dynamic" : "void";

                return $"public static {functionReturn} {name} ({args})" + " {\n" + body + "\n}";
            }
            
            
        }

        private string ResolveBlockStatement(OrchidParser.BlockContext context)
        {
            return "{\n" + ResolveStatementList(context.statementList(), 4) + "\n}";
        }

        private string ResolveIfStatement(OrchidParser.IfStatementContext context)
        {
            string condition = ResolveSingleExpression(context.singleExpression(0));
            string thenCondition = ResolveStatementList(context.statementList(0), 4);

            string result = "if (" + condition + ") {" + thenCondition + "\n}";

            if (context.ElseIf() != null)
            {
                int count = context.ElseIf().Length;
                var elseIfConditions = context.singleExpression().Skip(1).ToArray();
                var elseIfBlocks = context.statementList().Skip(1).Take(count).ToArray();

                for (int i = 0; i < count; i++)
                {
                    result += " else if (" + ResolveSingleExpression(elseIfConditions[i]) + ") {";
                    result += ResolveStatementList(elseIfBlocks[i], 4) + "\n}";
                }
            }

            if (context.Else() != null)
            {
                string elseCondition = ResolveStatementList(context.statementList().Last(), 4);
                result += " else {" + elseCondition + "\n}";
            }

            return result;
        }

        private string ResolveReturnStatement(OrchidParser.ReturnStatementContext context)
        {
            string exp = ResolveSingleExpression(context.singleExpression());
            return $"return {exp};";
        }

        private string ResolveAssignmentStatement(OrchidParser.AssignmentStatementContext context)
        {
            var left = context.identifier().GetText();
            var right = ResolveSingleExpression(context.singleExpression());

            return $"{left} = {right};";
        }

        private string ResolveAssignmentStatement(OrchidParser.VariableDeclarationListContext context)
        {
            var left = context.identifier().GetText();
            var right = ResolveSingleExpression(context.singleExpression());

            return $"{left} = {right};";
        }

        private string ResolveIterationStatement(OrchidParser.IterationStatementContext context) => context switch
        {
            OrchidParser.DoStatementContext doStatement => ResolveDoStatement(doStatement),
            OrchidParser.WhileStatementContext whileStatement => ResolveWhileStatement(whileStatement),
            OrchidParser.ForStatementContext forStatement => ResolveForStatement(forStatement),
            _ => context.GetText()
        };

        private string ResolveForStatement(OrchidParser.ForStatementContext context)
        {
            int expressionIndex = 0;

            string initBlock;
            string conditionBlock;
            string incrementBlock;
            string statements;

            if (context.declarationStatement() != null)
            {
                initBlock = ResolveDeclarationStatement(context.declarationStatement());
            }
            else if (context.variableDeclarationList() != null)
            {
                initBlock = ResolveAssignmentStatement(context.variableDeclarationList());
            }
            else
            {
                initBlock = ResolveSingleExpression(context.singleExpression(expressionIndex++));
            }

            if (initBlock.EndsWith(";"))
                initBlock = initBlock[0..^1];

            conditionBlock = ResolveSingleExpression(context.singleExpression(expressionIndex++));
            if (context.statement() != null)
            {
                incrementBlock = ResolveStatement(context.statement());
            }
            else
            {
                incrementBlock = ResolveSingleExpression(context.singleExpression(expressionIndex++));
            }
            
            statements = ResolveStatementList(context.statementList());

            return @"for (<INIT>; <COND>; <INCR>) {
    <STMNTS>
}
"
                .Replace("<INIT>", initBlock)
                .Replace("<COND>", conditionBlock)
                .Replace("<INCR>", incrementBlock)
                .Replace("<STMNTS>", statements);
        }

        private string ResolveWhileStatement(OrchidParser.WhileStatementContext context)
        {
            string condition = ResolveSingleExpression(context.singleExpression());
            string statementBlock = ResolveStatementList(context.statementList());

            return "while (" + condition + ")\n{" + statementBlock + "}";
        }

        private string ResolveDoStatement(OrchidParser.DoStatementContext context)
        {
            string statementBlock = ResolveStatementList(context.statementList());
            string condition = ResolveSingleExpression(context.singleExpression());

            return "do {\n" + statementBlock + "}\nwhile (" + condition + ");";
        }

        private string ResolveSingleExpression(OrchidParser.SingleExpressionContext context) => context switch
        {
            OrchidParser.IfExpressionContext ifExpr => ResolveIfExpression(ifExpr),
            OrchidParser.UnlessExpressionContext unlessExpr => ResolveUnlessExpression(unlessExpr),
            OrchidParser.FunctionCallExpressionContext func => ResolveFunction(func),
            OrchidParser.TernaryExpressionContext tern => ResolveTernaryExpression(tern),
            OrchidParser.UnaryMinusExpressionContext min => ResolveUnaryMinusExpression(min),
            OrchidParser.UnaryPlusExpressionContext plus => ResolveUnaryPlusExpression(plus),
            OrchidParser.NotExpressionContext not => ResolveNotExpression(not),
            OrchidParser.AdditiveExpressionContext add => ResolveAdditiveExpression(add),
            OrchidParser.MultiplicativeExpressionContext mul => ResolveMultiplicativeExpression(mul),
            OrchidParser.PowerExpressionContext pow => ResolvePowerExpression(pow),
            OrchidParser.LogicalAndExpressionContext andEx => ResolveLogicalAndExpression(andEx),
            OrchidParser.LogicalOrExpressionContext orEx => ResolveLogicalOrExpression(orEx),
            OrchidParser.RelationalExpressionContext rel => ResolveRelationalExpression(rel),
            OrchidParser.ParenthesizedExpressionContext pe => ResolveParenthesizedExpression(pe),
            OrchidParser.IdentifierExpressionContext ident => ResolveIdentifierExpression(ident),
            OrchidParser.ArrayLiteralExpressionContext arr => $"new dynamic[] {{{ResolveExpressionSequence(arr.arrayLiteral().expressionSequence())}}}",
            OrchidParser.LiteralExpressionContext le => ResolveLiteral(le),
            OrchidParser.ArrowFunctionExpressionContext arrow => ResolveArrowFunction(arrow),
            OrchidParser.PostfixExpressionContext post => ResolvePostfixExpression(post),
            OrchidParser.PrefixExpressionContext pre => ResolvePrefixExpression(pre),
            OrchidParser.AssignmentOperatorExpressionContext aoe => ResolveAssignmentOperatorExpression(aoe),
            null => string.Empty,
            _ => context.GetText()
        };

        private string ResolveParenthesizedExpression(OrchidParser.ParenthesizedExpressionContext context)
        {
            string innerExpr = ResolveSingleExpression(context.singleExpression());
            return $"({innerExpr})";
        }

        private string ResolveAssignmentOperatorExpression(OrchidParser.AssignmentOperatorExpressionContext context)
        {
            string identifier = context.identifier().GetText();
            string op = context.assignmentOperators().GetText();
            string rightHand = ResolveSingleExpression(context.singleExpression());

            return $"{identifier} {op} {rightHand}";
        }

        private string ResolveFunction(OrchidParser.FunctionCallExpressionContext context)
        {
            var function = context.functionCall();
            string name = function.Name().GetText();
            if (function.expressionSequence() != null)
            {
                string seq = ResolveExpressionSequence(function.expressionSequence());
                return $"{name}({seq})";
            }

            return name + "()";
        }

        private string ResolveFunctionCall(OrchidParser.FunctionCallContext context)
        {
            var function = context;
            string name = function.Name().GetText();
            if (function.expressionSequence() != null)
            {
                string seq = ResolveExpressionSequence(function.expressionSequence());
                return $"{name}({seq});";
            }

            return name + "();";
        }

        private string ResolvePrefixExpression(OrchidParser.PrefixExpressionContext context)
        {
            return $"{context.prefixPostfixOps().GetText()}{context.identifier().GetText()}";
        }

        private string ResolvePostfixExpression(OrchidParser.PostfixExpressionContext context)
        {
            return $"{context.identifier().GetText()}{context.prefixPostfixOps().GetText()}";
        }

        private string ResolvePrefixStatement(OrchidParser.PrefixStatementContext context)
        {
            string ident = context.identifier().GetText();
            string op = context.prefixPostfixOps().GetText().Substring(0, 1);
            return $"{ident} = {ident} {op} 1;";
        }

        private string ResolvePostfixStatement(OrchidParser.PostfixStatementContext context)
        {
            string ident = context.identifier().GetText();
            string op = context.prefixPostfixOps().GetText();
            return $"{ident} = {ident} {op} 1;";
        }

        private string ResolveArrowFunction(OrchidParser.ArrowFunctionExpressionContext context)
        {
            var arrowFunction = context.arrowFunctions();
            string parameters = ResolveFormalParameterList(arrowFunction.formalParameterList());
            if (arrowFunction.singleExpression() != null)
            {
                string body = ResolveSingleExpression(arrowFunction.singleExpression());
                return $"({parameters}) => {body}";
            }
            else
            {
                string statements = ResolveStatementList(arrowFunction.statementList(), 4);
                return $"({parameters}) => " + " {\n    " + statements + "\n}";
            }
        }

        private string ResolveFormalParameterList(OrchidParser.FormalParameterListContext context)
        {
            List<string> parameters = new List<string>();
            foreach (var name in context.Name())
            {
                parameters.Add("dynamic " + name.GetText());
            }

            if (parameters.Any())
                return $"{parameters.Aggregate((a, b) => $"{a}, {b}")}";

            return "";
        }

        private string ResolveTernaryExpression(OrchidParser.TernaryExpressionContext context)
        {
            string condition = ResolveSingleExpression(context.cond);
            string thenPart = ResolveSingleExpression(context.then);
            string elsePart = ResolveSingleExpression(context.@else);

            return $"{condition} ? {thenPart} : {elsePart}";
        }

        private string ResolveAdditiveExpression(OrchidParser.AdditiveExpressionContext context)
        {
            var left = ResolveSingleExpression(context.left);
            var op = context.op;
            var right = ResolveSingleExpression(context.right);

            return $"{left} {op.GetText()} {right}";
        }

        private string ResolveNotExpression(OrchidParser.NotExpressionContext context)
        {
            var right = ResolveSingleExpression(context.right);
            return $"!({right})";
        }

        private string ResolveUnaryPlusExpression(OrchidParser.UnaryPlusExpressionContext context)
        {
            string right = ResolveSingleExpression(context.right);
            return $"+({right})";
        }

        private string ResolveUnaryMinusExpression(OrchidParser.UnaryMinusExpressionContext context)
        {
            string right = ResolveSingleExpression(context.right);
            return $"-({right})";
        }

        private string ResolveRelationalExpression(OrchidParser.RelationalExpressionContext context)
        {
            var left = ResolveSingleExpression(context.left);
            var op = context.op.GetText();
            var right = ResolveSingleExpression(context.right);

            if (op == "=")
                op = "==";

            return $"{left} {op} {right}";
        }

        private string ResolveIfExpression(OrchidParser.IfExpressionContext context)
        {
            string result = ResolveSingleExpression(context.result);
            string condition = ResolveSingleExpression(context.@if);
            string otherwise = ResolveSingleExpression(context.@else);

            return $"{condition} ? {result} : {otherwise}";
        }

        private string ResolveUnlessExpression(OrchidParser.UnlessExpressionContext context)
        {
            string result = ResolveSingleExpression(context.result);
            string condition = ResolveSingleExpression(context.unless);
            string otherwise = ResolveSingleExpression(context.@else);

            return $"!({condition}) ? {result} : {otherwise}";
        }
        
        private string ResolveLogicalAndExpression(OrchidParser.LogicalAndExpressionContext context)
        {
            var left = ResolveSingleExpression(context.left);
            var right = ResolveSingleExpression(context.right);

            return $"{left} && {right}";
        }

        private string ResolveLogicalOrExpression(OrchidParser.LogicalOrExpressionContext context)
        {
            var left = ResolveSingleExpression(context.left);
            var right = ResolveSingleExpression(context.right);

            return $"{left} || {right}";
        }

        private string ResolvePowerExpression(OrchidParser.PowerExpressionContext context)
        {
            var left = ResolveSingleExpression(context.left);
            var right = ResolveSingleExpression(context.right);
            
            return $"System.Math.Pow({left}, {right})";
        }

        private string ResolveMultiplicativeExpression(OrchidParser.MultiplicativeExpressionContext context)
        {
            var left = ResolveSingleExpression(context.left);
            var op = context.op;
            var right = ResolveSingleExpression(context.right);

            return $"{left} {op.GetText()} {right}";
        }

        private string ResolveIdentifierExpression(OrchidParser.IdentifierExpressionContext context)
        {
            if (context.identifier().Name() != null)
                return context.identifier().Name().GetText();

            return context.identifier().Variable().GetText();
        }

        private string ResolveLiteral(OrchidParser.LiteralExpressionContext context)
        {
            OrchidParser.LiteralContext literal = context.literal();

            if (literal.NumericLiteral() != null)
            {
                return literal.NumericLiteral().GetText();
            }
            else if (literal.BooleanLiteral() != null)
            {
                return literal.BooleanLiteral().GetText();
            }

            string stringLiteral = literal.StringLiteral().GetText();
            if (stringLiteral.StartsWith("\""))
                return stringLiteral;
            else
                return "\"" + stringLiteral[1..^1] + "\"";
        }

        private string ResolveExpressionSequence(OrchidParser.ExpressionSequenceContext context)
        {
            return context.singleExpression().Select(ResolveSingleExpression).Aggregate((a, b) => $"{a}, {b}");
        }
    }
}
