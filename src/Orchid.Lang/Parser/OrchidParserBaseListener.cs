//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from OrchidParser.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Orchid.Parser {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IOrchidParserListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class OrchidParserBaseListener : IOrchidParserListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="OrchidParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProgram([NotNull] OrchidParser.ProgramContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OrchidParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProgram([NotNull] OrchidParser.ProgramContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OrchidParser.statementList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatementList([NotNull] OrchidParser.StatementListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OrchidParser.statementList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatementList([NotNull] OrchidParser.StatementListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OrchidParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] OrchidParser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OrchidParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] OrchidParser.StatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OrchidParser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlock([NotNull] OrchidParser.BlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OrchidParser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlock([NotNull] OrchidParser.BlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OrchidParser.arrowFunctions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrowFunctions([NotNull] OrchidParser.ArrowFunctionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OrchidParser.arrowFunctions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrowFunctions([NotNull] OrchidParser.ArrowFunctionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OrchidParser.expressionStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpressionStatement([NotNull] OrchidParser.ExpressionStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OrchidParser.expressionStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpressionStatement([NotNull] OrchidParser.ExpressionStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OrchidParser.assignmentOperatorStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignmentOperatorStatement([NotNull] OrchidParser.AssignmentOperatorStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OrchidParser.assignmentOperatorStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignmentOperatorStatement([NotNull] OrchidParser.AssignmentOperatorStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OrchidParser.functionDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionDeclaration([NotNull] OrchidParser.FunctionDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OrchidParser.functionDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionDeclaration([NotNull] OrchidParser.FunctionDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OrchidParser.formalParameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFormalParameterList([NotNull] OrchidParser.FormalParameterListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OrchidParser.formalParameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFormalParameterList([NotNull] OrchidParser.FormalParameterListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OrchidParser.ifStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfStatement([NotNull] OrchidParser.IfStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OrchidParser.ifStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfStatement([NotNull] OrchidParser.IfStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OrchidParser.returnStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReturnStatement([NotNull] OrchidParser.ReturnStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OrchidParser.returnStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReturnStatement([NotNull] OrchidParser.ReturnStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OrchidParser.printStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrintStatement([NotNull] OrchidParser.PrintStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OrchidParser.printStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrintStatement([NotNull] OrchidParser.PrintStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OrchidParser.assignmentStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignmentStatement([NotNull] OrchidParser.AssignmentStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OrchidParser.assignmentStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignmentStatement([NotNull] OrchidParser.AssignmentStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OrchidParser.declarationStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclarationStatement([NotNull] OrchidParser.DeclarationStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OrchidParser.declarationStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclarationStatement([NotNull] OrchidParser.DeclarationStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>DoStatement</c>
	/// labeled alternative in <see cref="OrchidParser.iterationStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDoStatement([NotNull] OrchidParser.DoStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>DoStatement</c>
	/// labeled alternative in <see cref="OrchidParser.iterationStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDoStatement([NotNull] OrchidParser.DoStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>WhileStatement</c>
	/// labeled alternative in <see cref="OrchidParser.iterationStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhileStatement([NotNull] OrchidParser.WhileStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>WhileStatement</c>
	/// labeled alternative in <see cref="OrchidParser.iterationStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhileStatement([NotNull] OrchidParser.WhileStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ForStatement</c>
	/// labeled alternative in <see cref="OrchidParser.iterationStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForStatement([NotNull] OrchidParser.ForStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ForStatement</c>
	/// labeled alternative in <see cref="OrchidParser.iterationStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForStatement([NotNull] OrchidParser.ForStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OrchidParser.variableDeclarationList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableDeclarationList([NotNull] OrchidParser.VariableDeclarationListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OrchidParser.variableDeclarationList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableDeclarationList([NotNull] OrchidParser.VariableDeclarationListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OrchidParser.expressionSequence"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpressionSequence([NotNull] OrchidParser.ExpressionSequenceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OrchidParser.expressionSequence"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpressionSequence([NotNull] OrchidParser.ExpressionSequenceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OrchidParser.prefixStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrefixStatement([NotNull] OrchidParser.PrefixStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OrchidParser.prefixStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrefixStatement([NotNull] OrchidParser.PrefixStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OrchidParser.postfixStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPostfixStatement([NotNull] OrchidParser.PostfixStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OrchidParser.postfixStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPostfixStatement([NotNull] OrchidParser.PostfixStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ParenthesizedExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParenthesizedExpression([NotNull] OrchidParser.ParenthesizedExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ParenthesizedExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParenthesizedExpression([NotNull] OrchidParser.ParenthesizedExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>AdditiveExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdditiveExpression([NotNull] OrchidParser.AdditiveExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AdditiveExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdditiveExpression([NotNull] OrchidParser.AdditiveExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>RelationalExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRelationalExpression([NotNull] OrchidParser.RelationalExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>RelationalExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRelationalExpression([NotNull] OrchidParser.RelationalExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>TernaryExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTernaryExpression([NotNull] OrchidParser.TernaryExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>TernaryExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTernaryExpression([NotNull] OrchidParser.TernaryExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>IfExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfExpression([NotNull] OrchidParser.IfExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>IfExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfExpression([NotNull] OrchidParser.IfExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>LogicalAndExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogicalAndExpression([NotNull] OrchidParser.LogicalAndExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>LogicalAndExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogicalAndExpression([NotNull] OrchidParser.LogicalAndExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>PowerExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPowerExpression([NotNull] OrchidParser.PowerExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>PowerExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPowerExpression([NotNull] OrchidParser.PowerExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>UnlessExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnlessExpression([NotNull] OrchidParser.UnlessExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>UnlessExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnlessExpression([NotNull] OrchidParser.UnlessExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>LiteralExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteralExpression([NotNull] OrchidParser.LiteralExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>LiteralExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteralExpression([NotNull] OrchidParser.LiteralExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>LogicalOrExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogicalOrExpression([NotNull] OrchidParser.LogicalOrExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>LogicalOrExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogicalOrExpression([NotNull] OrchidParser.LogicalOrExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ArrayLiteralExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrayLiteralExpression([NotNull] OrchidParser.ArrayLiteralExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ArrayLiteralExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrayLiteralExpression([NotNull] OrchidParser.ArrayLiteralExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>NotExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNotExpression([NotNull] OrchidParser.NotExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>NotExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNotExpression([NotNull] OrchidParser.NotExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>FunctionCallExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionCallExpression([NotNull] OrchidParser.FunctionCallExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>FunctionCallExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionCallExpression([NotNull] OrchidParser.FunctionCallExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>IdentifierExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifierExpression([NotNull] OrchidParser.IdentifierExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>IdentifierExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifierExpression([NotNull] OrchidParser.IdentifierExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>UnaryMinusExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnaryMinusExpression([NotNull] OrchidParser.UnaryMinusExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>UnaryMinusExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnaryMinusExpression([NotNull] OrchidParser.UnaryMinusExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>PrefixExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrefixExpression([NotNull] OrchidParser.PrefixExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>PrefixExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrefixExpression([NotNull] OrchidParser.PrefixExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>AssignmentOperatorExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignmentOperatorExpression([NotNull] OrchidParser.AssignmentOperatorExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AssignmentOperatorExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignmentOperatorExpression([NotNull] OrchidParser.AssignmentOperatorExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>UnaryPlusExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnaryPlusExpression([NotNull] OrchidParser.UnaryPlusExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>UnaryPlusExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnaryPlusExpression([NotNull] OrchidParser.UnaryPlusExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>PostfixExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPostfixExpression([NotNull] OrchidParser.PostfixExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>PostfixExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPostfixExpression([NotNull] OrchidParser.PostfixExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ArrowFunctionExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrowFunctionExpression([NotNull] OrchidParser.ArrowFunctionExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ArrowFunctionExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrowFunctionExpression([NotNull] OrchidParser.ArrowFunctionExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>MultiplicativeExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMultiplicativeExpression([NotNull] OrchidParser.MultiplicativeExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>MultiplicativeExpression</c>
	/// labeled alternative in <see cref="OrchidParser.singleExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMultiplicativeExpression([NotNull] OrchidParser.MultiplicativeExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OrchidParser.multiplicativeOperators"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMultiplicativeOperators([NotNull] OrchidParser.MultiplicativeOperatorsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OrchidParser.multiplicativeOperators"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMultiplicativeOperators([NotNull] OrchidParser.MultiplicativeOperatorsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OrchidParser.additiveOperators"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdditiveOperators([NotNull] OrchidParser.AdditiveOperatorsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OrchidParser.additiveOperators"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdditiveOperators([NotNull] OrchidParser.AdditiveOperatorsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OrchidParser.prefixPostfixOps"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrefixPostfixOps([NotNull] OrchidParser.PrefixPostfixOpsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OrchidParser.prefixPostfixOps"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrefixPostfixOps([NotNull] OrchidParser.PrefixPostfixOpsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OrchidParser.logicalAndOperators"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogicalAndOperators([NotNull] OrchidParser.LogicalAndOperatorsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OrchidParser.logicalAndOperators"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogicalAndOperators([NotNull] OrchidParser.LogicalAndOperatorsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OrchidParser.logicalOrOperators"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogicalOrOperators([NotNull] OrchidParser.LogicalOrOperatorsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OrchidParser.logicalOrOperators"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogicalOrOperators([NotNull] OrchidParser.LogicalOrOperatorsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OrchidParser.comparisonOperators"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComparisonOperators([NotNull] OrchidParser.ComparisonOperatorsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OrchidParser.comparisonOperators"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComparisonOperators([NotNull] OrchidParser.ComparisonOperatorsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OrchidParser.assignmentOperators"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignmentOperators([NotNull] OrchidParser.AssignmentOperatorsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OrchidParser.assignmentOperators"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignmentOperators([NotNull] OrchidParser.AssignmentOperatorsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OrchidParser.functionCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionCall([NotNull] OrchidParser.FunctionCallContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OrchidParser.functionCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionCall([NotNull] OrchidParser.FunctionCallContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OrchidParser.identifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifier([NotNull] OrchidParser.IdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OrchidParser.identifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifier([NotNull] OrchidParser.IdentifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OrchidParser.arrayLiteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrayLiteral([NotNull] OrchidParser.ArrayLiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OrchidParser.arrayLiteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrayLiteral([NotNull] OrchidParser.ArrayLiteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OrchidParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteral([NotNull] OrchidParser.LiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OrchidParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteral([NotNull] OrchidParser.LiteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OrchidParser.eos"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEos([NotNull] OrchidParser.EosContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OrchidParser.eos"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEos([NotNull] OrchidParser.EosContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace Orchid.Parser
