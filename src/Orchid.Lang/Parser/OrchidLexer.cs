//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from OrchidLexer.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Orchid.Parser {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public partial class OrchidLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		MultiLineComment=1, SingleLineComment=2, BooleanLiteral=3, StringLiteral=4, 
		NumericLiteral=5, Integer=6, Float=7, Dot=8, And=9, Or=10, Not=11, If=12, 
		Else=13, ElseIf=14, Then=15, Unless=16, Do=17, While=18, Loop=19, For=20, 
		Return=21, Function=22, End=23, Break=24, Next=25, Continue=26, Print=27, 
		Val=28, PlusPlus=29, MinusMinus=30, MulEq=31, PlusEq=32, MinusEq=33, DivEq=34, 
		SemiColon=35, Mul=36, Div=37, Plus=38, Sub=39, Mod=40, Pow=41, Amp=42, 
		Gt=43, Gte=44, Lt=45, Lte=46, Eq=47, Assign=48, NotEq=49, UnaryNot=50, 
		LogicalAnd=51, LogicalOr=52, Colon=53, Comma=54, PowerOp=55, Question=56, 
		OpenRound=57, CloseRound=58, Arrow=59, OpenSquare=60, CloseSquare=61, 
		OpenCurly=62, CloseCurly=63, Name=64, Variable=65, WhiteSpace=66, Discardable=67;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"MultiLineComment", "SingleLineComment", "BooleanLiteral", "StringLiteral", 
		"NumericLiteral", "Integer", "Float", "Dot", "And", "Or", "Not", "If", 
		"Else", "ElseIf", "Then", "Unless", "Do", "While", "Loop", "For", "Return", 
		"Function", "End", "Break", "Next", "Continue", "Print", "Val", "PlusPlus", 
		"MinusMinus", "MulEq", "PlusEq", "MinusEq", "DivEq", "SemiColon", "Mul", 
		"Div", "Plus", "Sub", "Mod", "Pow", "Amp", "Gt", "Gte", "Lt", "Lte", "Eq", 
		"Assign", "NotEq", "UnaryNot", "LogicalAnd", "LogicalOr", "Colon", "Comma", 
		"PowerOp", "Question", "OpenRound", "CloseRound", "Arrow", "OpenSquare", 
		"CloseSquare", "OpenCurly", "CloseCurly", "Name", "Variable", "WhiteSpace", 
		"Discardable", "LETTER", "DIGIT", "UNDERSCORE", "EXPONENT"
	};


	public OrchidLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public OrchidLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, null, null, null, null, null, null, null, "'.'", "'and'", "'or'", 
		"'not'", "'if'", "'else'", "'elseif'", "'then'", "'unless'", "'do'", "'while'", 
		"'loop'", "'for'", "'return'", "'func'", "'end'", "'break'", "'next'", 
		"'continue'", "'print'", "'val'", "'++'", "'--'", "'*='", "'+='", "'-='", 
		"'/='", "';'", "'*'", "'/'", "'+'", "'-'", "'%'", "'^'", "'&'", "'>'", 
		"'>='", "'<'", "'<='", "'='", "':='", "'!='", "'!'", "'&&'", "'||'", "':'", 
		"','", "'**'", "'?'", "'('", "')'", "'->'", "'['", "']'", "'{'", "'}'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "MultiLineComment", "SingleLineComment", "BooleanLiteral", "StringLiteral", 
		"NumericLiteral", "Integer", "Float", "Dot", "And", "Or", "Not", "If", 
		"Else", "ElseIf", "Then", "Unless", "Do", "While", "Loop", "For", "Return", 
		"Function", "End", "Break", "Next", "Continue", "Print", "Val", "PlusPlus", 
		"MinusMinus", "MulEq", "PlusEq", "MinusEq", "DivEq", "SemiColon", "Mul", 
		"Div", "Plus", "Sub", "Mod", "Pow", "Amp", "Gt", "Gte", "Lt", "Lte", "Eq", 
		"Assign", "NotEq", "UnaryNot", "LogicalAnd", "LogicalOr", "Colon", "Comma", 
		"PowerOp", "Question", "OpenRound", "CloseRound", "Arrow", "OpenSquare", 
		"CloseSquare", "OpenCurly", "CloseCurly", "Name", "Variable", "WhiteSpace", 
		"Discardable"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "OrchidLexer.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static OrchidLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x45', '\x1D5', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x4', 
		' ', '\t', ' ', '\x4', '!', '\t', '!', '\x4', '\"', '\t', '\"', '\x4', 
		'#', '\t', '#', '\x4', '$', '\t', '$', '\x4', '%', '\t', '%', '\x4', '&', 
		'\t', '&', '\x4', '\'', '\t', '\'', '\x4', '(', '\t', '(', '\x4', ')', 
		'\t', ')', '\x4', '*', '\t', '*', '\x4', '+', '\t', '+', '\x4', ',', '\t', 
		',', '\x4', '-', '\t', '-', '\x4', '.', '\t', '.', '\x4', '/', '\t', '/', 
		'\x4', '\x30', '\t', '\x30', '\x4', '\x31', '\t', '\x31', '\x4', '\x32', 
		'\t', '\x32', '\x4', '\x33', '\t', '\x33', '\x4', '\x34', '\t', '\x34', 
		'\x4', '\x35', '\t', '\x35', '\x4', '\x36', '\t', '\x36', '\x4', '\x37', 
		'\t', '\x37', '\x4', '\x38', '\t', '\x38', '\x4', '\x39', '\t', '\x39', 
		'\x4', ':', '\t', ':', '\x4', ';', '\t', ';', '\x4', '<', '\t', '<', '\x4', 
		'=', '\t', '=', '\x4', '>', '\t', '>', '\x4', '?', '\t', '?', '\x4', '@', 
		'\t', '@', '\x4', '\x41', '\t', '\x41', '\x4', '\x42', '\t', '\x42', '\x4', 
		'\x43', '\t', '\x43', '\x4', '\x44', '\t', '\x44', '\x4', '\x45', '\t', 
		'\x45', '\x4', '\x46', '\t', '\x46', '\x4', 'G', '\t', 'G', '\x4', 'H', 
		'\t', 'H', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\a', 
		'\x2', '\x96', '\n', '\x2', '\f', '\x2', '\xE', '\x2', '\x99', '\v', '\x2', 
		'\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', 
		'\x3', '\x3', '\x3', '\x3', '\a', '\x3', '\xA2', '\n', '\x3', '\f', '\x3', 
		'\xE', '\x3', '\xA5', '\v', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x5', '\x4', '\xB2', 
		'\n', '\x4', '\x3', '\x5', '\x3', '\x5', '\a', '\x5', '\xB6', '\n', '\x5', 
		'\f', '\x5', '\xE', '\x5', '\xB9', '\v', '\x5', '\x3', '\x5', '\x3', '\x5', 
		'\x3', '\x5', '\a', '\x5', '\xBE', '\n', '\x5', '\f', '\x5', '\xE', '\x5', 
		'\xC1', '\v', '\x5', '\x3', '\x5', '\x5', '\x5', '\xC4', '\n', '\x5', 
		'\x3', '\x6', '\x3', '\x6', '\x5', '\x6', '\xC8', '\n', '\x6', '\x3', 
		'\a', '\x6', '\a', '\xCB', '\n', '\a', '\r', '\a', '\xE', '\a', '\xCC', 
		'\x3', '\b', '\x6', '\b', '\xD0', '\n', '\b', '\r', '\b', '\xE', '\b', 
		'\xD1', '\x3', '\b', '\x3', '\b', '\a', '\b', '\xD6', '\n', '\b', '\f', 
		'\b', '\xE', '\b', '\xD9', '\v', '\b', '\x3', '\b', '\x5', '\b', '\xDC', 
		'\n', '\b', '\x3', '\b', '\x3', '\b', '\x6', '\b', '\xE0', '\n', '\b', 
		'\r', '\b', '\xE', '\b', '\xE1', '\x3', '\b', '\x5', '\b', '\xE5', '\n', 
		'\b', '\x3', '\b', '\x6', '\b', '\xE8', '\n', '\b', '\r', '\b', '\xE', 
		'\b', '\xE9', '\x3', '\b', '\x3', '\b', '\x5', '\b', '\xEE', '\n', '\b', 
		'\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', 
		'\n', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', 
		'\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', 
		'\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', 
		'\x10', '\x3', '\x10', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', 
		'\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x12', '\x3', 
		'\x12', '\x3', '\x12', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', 
		'\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x14', '\x3', '\x14', '\x3', 
		'\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x15', '\x3', '\x15', '\x3', 
		'\x15', '\x3', '\x15', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', 
		'\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x17', '\x3', 
		'\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x18', '\x3', 
		'\x18', '\x3', '\x18', '\x3', '\x18', '\x3', '\x19', '\x3', '\x19', '\x3', 
		'\x19', '\x3', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', '\x1A', '\x3', 
		'\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1B', '\x3', 
		'\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x3', 
		'\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1C', '\x3', '\x1C', '\x3', 
		'\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1D', '\x3', 
		'\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1E', '\x3', '\x1E', '\x3', 
		'\x1E', '\x3', '\x1F', '\x3', '\x1F', '\x3', '\x1F', '\x3', ' ', '\x3', 
		' ', '\x3', ' ', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '\"', '\x3', 
		'\"', '\x3', '\"', '\x3', '#', '\x3', '#', '\x3', '#', '\x3', '$', '\x3', 
		'$', '\x3', '%', '\x3', '%', '\x3', '&', '\x3', '&', '\x3', '\'', '\x3', 
		'\'', '\x3', '(', '\x3', '(', '\x3', ')', '\x3', ')', '\x3', '*', '\x3', 
		'*', '\x3', '+', '\x3', '+', '\x3', ',', '\x3', ',', '\x3', '-', '\x3', 
		'-', '\x3', '-', '\x3', '.', '\x3', '.', '\x3', '/', '\x3', '/', '\x3', 
		'/', '\x3', '\x30', '\x3', '\x30', '\x3', '\x31', '\x3', '\x31', '\x3', 
		'\x31', '\x3', '\x32', '\x3', '\x32', '\x3', '\x32', '\x3', '\x33', '\x3', 
		'\x33', '\x3', '\x34', '\x3', '\x34', '\x3', '\x34', '\x3', '\x35', '\x3', 
		'\x35', '\x3', '\x35', '\x3', '\x36', '\x3', '\x36', '\x3', '\x37', '\x3', 
		'\x37', '\x3', '\x38', '\x3', '\x38', '\x3', '\x38', '\x3', '\x39', '\x3', 
		'\x39', '\x3', ':', '\x3', ':', '\x3', ';', '\x3', ';', '\x3', '<', '\x3', 
		'<', '\x3', '<', '\x3', '=', '\x3', '=', '\x3', '>', '\x3', '>', '\x3', 
		'?', '\x3', '?', '\x3', '@', '\x3', '@', '\x3', '\x41', '\x3', '\x41', 
		'\x5', '\x41', '\x1AE', '\n', '\x41', '\x3', '\x41', '\x3', '\x41', '\x3', 
		'\x41', '\a', '\x41', '\x1B3', '\n', '\x41', '\f', '\x41', '\xE', '\x41', 
		'\x1B6', '\v', '\x41', '\x3', '\x42', '\x3', '\x42', '\x3', '\x42', '\x3', 
		'\x42', '\x3', '\x43', '\x6', '\x43', '\x1BD', '\n', '\x43', '\r', '\x43', 
		'\xE', '\x43', '\x1BE', '\x3', '\x43', '\x3', '\x43', '\x3', '\x44', '\x3', 
		'\x44', '\x3', '\x44', '\x3', '\x44', '\x3', '\x45', '\x3', '\x45', '\x3', 
		'\x46', '\x3', '\x46', '\x3', 'G', '\x3', 'G', '\x3', 'H', '\x3', 'H', 
		'\x5', 'H', '\x1CF', '\n', 'H', '\x3', 'H', '\x6', 'H', '\x1D2', '\n', 
		'H', '\r', 'H', '\xE', 'H', '\x1D3', '\x5', '\x97', '\xB7', '\xBF', '\x2', 
		'I', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', 
		'\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', 
		'\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', 
		'\x12', '#', '\x13', '%', '\x14', '\'', '\x15', ')', '\x16', '+', '\x17', 
		'-', '\x18', '/', '\x19', '\x31', '\x1A', '\x33', '\x1B', '\x35', '\x1C', 
		'\x37', '\x1D', '\x39', '\x1E', ';', '\x1F', '=', ' ', '?', '!', '\x41', 
		'\"', '\x43', '#', '\x45', '$', 'G', '%', 'I', '&', 'K', '\'', 'M', '(', 
		'O', ')', 'Q', '*', 'S', '+', 'U', ',', 'W', '-', 'Y', '.', '[', '/', 
		']', '\x30', '_', '\x31', '\x61', '\x32', '\x63', '\x33', '\x65', '\x34', 
		'g', '\x35', 'i', '\x36', 'k', '\x37', 'm', '\x38', 'o', '\x39', 'q', 
		':', 's', ';', 'u', '<', 'w', '=', 'y', '>', '{', '?', '}', '@', '\x7F', 
		'\x41', '\x81', '\x42', '\x83', '\x43', '\x85', '\x44', '\x87', '\x45', 
		'\x89', '\x2', '\x8B', '\x2', '\x8D', '\x2', '\x8F', '\x2', '\x3', '\x2', 
		'\t', '\x5', '\x2', '\f', '\f', '\xF', '\xF', '\x202A', '\x202B', '\x6', 
		'\x2', '\f', '\f', '\xF', '\xF', '$', '$', '^', '^', '\x5', '\x2', '\v', 
		'\f', '\xE', '\xF', '\"', '\"', '\x4', '\x2', '\x43', '\\', '\x63', '|', 
		'\x3', '\x2', '\x32', ';', '\x4', '\x2', 'G', 'G', 'g', 'g', '\x4', '\x2', 
		'-', '-', '/', '/', '\x2', '\x1E7', '\x2', '\x3', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x13', '\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x19', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '%', '\x3', '\x2', '\x2', '\x2', '\x2', '\'', 
		'\x3', '\x2', '\x2', '\x2', '\x2', ')', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'+', '\x3', '\x2', '\x2', '\x2', '\x2', '-', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '/', '\x3', '\x2', '\x2', '\x2', '\x2', '\x31', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x33', '\x3', '\x2', '\x2', '\x2', '\x2', '\x35', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x37', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x39', '\x3', '\x2', '\x2', '\x2', '\x2', ';', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '=', '\x3', '\x2', '\x2', '\x2', '\x2', '?', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x41', '\x3', '\x2', '\x2', '\x2', '\x2', '\x43', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x45', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'G', '\x3', '\x2', '\x2', '\x2', '\x2', 'I', '\x3', '\x2', '\x2', '\x2', 
		'\x2', 'K', '\x3', '\x2', '\x2', '\x2', '\x2', 'M', '\x3', '\x2', '\x2', 
		'\x2', '\x2', 'O', '\x3', '\x2', '\x2', '\x2', '\x2', 'Q', '\x3', '\x2', 
		'\x2', '\x2', '\x2', 'S', '\x3', '\x2', '\x2', '\x2', '\x2', 'U', '\x3', 
		'\x2', '\x2', '\x2', '\x2', 'W', '\x3', '\x2', '\x2', '\x2', '\x2', 'Y', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '[', '\x3', '\x2', '\x2', '\x2', '\x2', 
		']', '\x3', '\x2', '\x2', '\x2', '\x2', '_', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x61', '\x3', '\x2', '\x2', '\x2', '\x2', '\x63', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x65', '\x3', '\x2', '\x2', '\x2', '\x2', 'g', '\x3', 
		'\x2', '\x2', '\x2', '\x2', 'i', '\x3', '\x2', '\x2', '\x2', '\x2', 'k', 
		'\x3', '\x2', '\x2', '\x2', '\x2', 'm', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'o', '\x3', '\x2', '\x2', '\x2', '\x2', 'q', '\x3', '\x2', '\x2', '\x2', 
		'\x2', 's', '\x3', '\x2', '\x2', '\x2', '\x2', 'u', '\x3', '\x2', '\x2', 
		'\x2', '\x2', 'w', '\x3', '\x2', '\x2', '\x2', '\x2', 'y', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '{', '\x3', '\x2', '\x2', '\x2', '\x2', '}', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x7F', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x81', '\x3', '\x2', '\x2', '\x2', '\x2', '\x83', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x85', '\x3', '\x2', '\x2', '\x2', '\x2', '\x87', '\x3', 
		'\x2', '\x2', '\x2', '\x3', '\x91', '\x3', '\x2', '\x2', '\x2', '\x5', 
		'\x9F', '\x3', '\x2', '\x2', '\x2', '\a', '\xB1', '\x3', '\x2', '\x2', 
		'\x2', '\t', '\xC3', '\x3', '\x2', '\x2', '\x2', '\v', '\xC7', '\x3', 
		'\x2', '\x2', '\x2', '\r', '\xCA', '\x3', '\x2', '\x2', '\x2', '\xF', 
		'\xED', '\x3', '\x2', '\x2', '\x2', '\x11', '\xEF', '\x3', '\x2', '\x2', 
		'\x2', '\x13', '\xF1', '\x3', '\x2', '\x2', '\x2', '\x15', '\xF5', '\x3', 
		'\x2', '\x2', '\x2', '\x17', '\xF8', '\x3', '\x2', '\x2', '\x2', '\x19', 
		'\xFC', '\x3', '\x2', '\x2', '\x2', '\x1B', '\xFF', '\x3', '\x2', '\x2', 
		'\x2', '\x1D', '\x104', '\x3', '\x2', '\x2', '\x2', '\x1F', '\x10B', '\x3', 
		'\x2', '\x2', '\x2', '!', '\x110', '\x3', '\x2', '\x2', '\x2', '#', '\x117', 
		'\x3', '\x2', '\x2', '\x2', '%', '\x11A', '\x3', '\x2', '\x2', '\x2', 
		'\'', '\x120', '\x3', '\x2', '\x2', '\x2', ')', '\x125', '\x3', '\x2', 
		'\x2', '\x2', '+', '\x129', '\x3', '\x2', '\x2', '\x2', '-', '\x130', 
		'\x3', '\x2', '\x2', '\x2', '/', '\x135', '\x3', '\x2', '\x2', '\x2', 
		'\x31', '\x139', '\x3', '\x2', '\x2', '\x2', '\x33', '\x13F', '\x3', '\x2', 
		'\x2', '\x2', '\x35', '\x144', '\x3', '\x2', '\x2', '\x2', '\x37', '\x14D', 
		'\x3', '\x2', '\x2', '\x2', '\x39', '\x153', '\x3', '\x2', '\x2', '\x2', 
		';', '\x157', '\x3', '\x2', '\x2', '\x2', '=', '\x15A', '\x3', '\x2', 
		'\x2', '\x2', '?', '\x15D', '\x3', '\x2', '\x2', '\x2', '\x41', '\x160', 
		'\x3', '\x2', '\x2', '\x2', '\x43', '\x163', '\x3', '\x2', '\x2', '\x2', 
		'\x45', '\x166', '\x3', '\x2', '\x2', '\x2', 'G', '\x169', '\x3', '\x2', 
		'\x2', '\x2', 'I', '\x16B', '\x3', '\x2', '\x2', '\x2', 'K', '\x16D', 
		'\x3', '\x2', '\x2', '\x2', 'M', '\x16F', '\x3', '\x2', '\x2', '\x2', 
		'O', '\x171', '\x3', '\x2', '\x2', '\x2', 'Q', '\x173', '\x3', '\x2', 
		'\x2', '\x2', 'S', '\x175', '\x3', '\x2', '\x2', '\x2', 'U', '\x177', 
		'\x3', '\x2', '\x2', '\x2', 'W', '\x179', '\x3', '\x2', '\x2', '\x2', 
		'Y', '\x17B', '\x3', '\x2', '\x2', '\x2', '[', '\x17E', '\x3', '\x2', 
		'\x2', '\x2', ']', '\x180', '\x3', '\x2', '\x2', '\x2', '_', '\x183', 
		'\x3', '\x2', '\x2', '\x2', '\x61', '\x185', '\x3', '\x2', '\x2', '\x2', 
		'\x63', '\x188', '\x3', '\x2', '\x2', '\x2', '\x65', '\x18B', '\x3', '\x2', 
		'\x2', '\x2', 'g', '\x18D', '\x3', '\x2', '\x2', '\x2', 'i', '\x190', 
		'\x3', '\x2', '\x2', '\x2', 'k', '\x193', '\x3', '\x2', '\x2', '\x2', 
		'm', '\x195', '\x3', '\x2', '\x2', '\x2', 'o', '\x197', '\x3', '\x2', 
		'\x2', '\x2', 'q', '\x19A', '\x3', '\x2', '\x2', '\x2', 's', '\x19C', 
		'\x3', '\x2', '\x2', '\x2', 'u', '\x19E', '\x3', '\x2', '\x2', '\x2', 
		'w', '\x1A0', '\x3', '\x2', '\x2', '\x2', 'y', '\x1A3', '\x3', '\x2', 
		'\x2', '\x2', '{', '\x1A5', '\x3', '\x2', '\x2', '\x2', '}', '\x1A7', 
		'\x3', '\x2', '\x2', '\x2', '\x7F', '\x1A9', '\x3', '\x2', '\x2', '\x2', 
		'\x81', '\x1AD', '\x3', '\x2', '\x2', '\x2', '\x83', '\x1B7', '\x3', '\x2', 
		'\x2', '\x2', '\x85', '\x1BC', '\x3', '\x2', '\x2', '\x2', '\x87', '\x1C2', 
		'\x3', '\x2', '\x2', '\x2', '\x89', '\x1C6', '\x3', '\x2', '\x2', '\x2', 
		'\x8B', '\x1C8', '\x3', '\x2', '\x2', '\x2', '\x8D', '\x1CA', '\x3', '\x2', 
		'\x2', '\x2', '\x8F', '\x1CC', '\x3', '\x2', '\x2', '\x2', '\x91', '\x92', 
		'\a', '\x31', '\x2', '\x2', '\x92', '\x93', '\a', ',', '\x2', '\x2', '\x93', 
		'\x97', '\x3', '\x2', '\x2', '\x2', '\x94', '\x96', '\v', '\x2', '\x2', 
		'\x2', '\x95', '\x94', '\x3', '\x2', '\x2', '\x2', '\x96', '\x99', '\x3', 
		'\x2', '\x2', '\x2', '\x97', '\x98', '\x3', '\x2', '\x2', '\x2', '\x97', 
		'\x95', '\x3', '\x2', '\x2', '\x2', '\x98', '\x9A', '\x3', '\x2', '\x2', 
		'\x2', '\x99', '\x97', '\x3', '\x2', '\x2', '\x2', '\x9A', '\x9B', '\a', 
		',', '\x2', '\x2', '\x9B', '\x9C', '\a', '\x31', '\x2', '\x2', '\x9C', 
		'\x9D', '\x3', '\x2', '\x2', '\x2', '\x9D', '\x9E', '\b', '\x2', '\x2', 
		'\x2', '\x9E', '\x4', '\x3', '\x2', '\x2', '\x2', '\x9F', '\xA3', '\a', 
		'%', '\x2', '\x2', '\xA0', '\xA2', '\n', '\x2', '\x2', '\x2', '\xA1', 
		'\xA0', '\x3', '\x2', '\x2', '\x2', '\xA2', '\xA5', '\x3', '\x2', '\x2', 
		'\x2', '\xA3', '\xA1', '\x3', '\x2', '\x2', '\x2', '\xA3', '\xA4', '\x3', 
		'\x2', '\x2', '\x2', '\xA4', '\xA6', '\x3', '\x2', '\x2', '\x2', '\xA5', 
		'\xA3', '\x3', '\x2', '\x2', '\x2', '\xA6', '\xA7', '\b', '\x3', '\x2', 
		'\x2', '\xA7', '\x6', '\x3', '\x2', '\x2', '\x2', '\xA8', '\xA9', '\a', 
		'v', '\x2', '\x2', '\xA9', '\xAA', '\a', 't', '\x2', '\x2', '\xAA', '\xAB', 
		'\a', 'w', '\x2', '\x2', '\xAB', '\xB2', '\a', 'g', '\x2', '\x2', '\xAC', 
		'\xAD', '\a', 'h', '\x2', '\x2', '\xAD', '\xAE', '\a', '\x63', '\x2', 
		'\x2', '\xAE', '\xAF', '\a', 'n', '\x2', '\x2', '\xAF', '\xB0', '\a', 
		'u', '\x2', '\x2', '\xB0', '\xB2', '\a', 'g', '\x2', '\x2', '\xB1', '\xA8', 
		'\x3', '\x2', '\x2', '\x2', '\xB1', '\xAC', '\x3', '\x2', '\x2', '\x2', 
		'\xB2', '\b', '\x3', '\x2', '\x2', '\x2', '\xB3', '\xB7', '\a', '$', '\x2', 
		'\x2', '\xB4', '\xB6', '\n', '\x3', '\x2', '\x2', '\xB5', '\xB4', '\x3', 
		'\x2', '\x2', '\x2', '\xB6', '\xB9', '\x3', '\x2', '\x2', '\x2', '\xB7', 
		'\xB8', '\x3', '\x2', '\x2', '\x2', '\xB7', '\xB5', '\x3', '\x2', '\x2', 
		'\x2', '\xB8', '\xBA', '\x3', '\x2', '\x2', '\x2', '\xB9', '\xB7', '\x3', 
		'\x2', '\x2', '\x2', '\xBA', '\xC4', '\a', '$', '\x2', '\x2', '\xBB', 
		'\xBF', '\a', ')', '\x2', '\x2', '\xBC', '\xBE', '\n', '\x3', '\x2', '\x2', 
		'\xBD', '\xBC', '\x3', '\x2', '\x2', '\x2', '\xBE', '\xC1', '\x3', '\x2', 
		'\x2', '\x2', '\xBF', '\xC0', '\x3', '\x2', '\x2', '\x2', '\xBF', '\xBD', 
		'\x3', '\x2', '\x2', '\x2', '\xC0', '\xC2', '\x3', '\x2', '\x2', '\x2', 
		'\xC1', '\xBF', '\x3', '\x2', '\x2', '\x2', '\xC2', '\xC4', '\a', ')', 
		'\x2', '\x2', '\xC3', '\xB3', '\x3', '\x2', '\x2', '\x2', '\xC3', '\xBB', 
		'\x3', '\x2', '\x2', '\x2', '\xC4', '\n', '\x3', '\x2', '\x2', '\x2', 
		'\xC5', '\xC8', '\x5', '\r', '\a', '\x2', '\xC6', '\xC8', '\x5', '\xF', 
		'\b', '\x2', '\xC7', '\xC5', '\x3', '\x2', '\x2', '\x2', '\xC7', '\xC6', 
		'\x3', '\x2', '\x2', '\x2', '\xC8', '\f', '\x3', '\x2', '\x2', '\x2', 
		'\xC9', '\xCB', '\x5', '\x8B', '\x46', '\x2', '\xCA', '\xC9', '\x3', '\x2', 
		'\x2', '\x2', '\xCB', '\xCC', '\x3', '\x2', '\x2', '\x2', '\xCC', '\xCA', 
		'\x3', '\x2', '\x2', '\x2', '\xCC', '\xCD', '\x3', '\x2', '\x2', '\x2', 
		'\xCD', '\xE', '\x3', '\x2', '\x2', '\x2', '\xCE', '\xD0', '\x5', '\x8B', 
		'\x46', '\x2', '\xCF', '\xCE', '\x3', '\x2', '\x2', '\x2', '\xD0', '\xD1', 
		'\x3', '\x2', '\x2', '\x2', '\xD1', '\xCF', '\x3', '\x2', '\x2', '\x2', 
		'\xD1', '\xD2', '\x3', '\x2', '\x2', '\x2', '\xD2', '\xD3', '\x3', '\x2', 
		'\x2', '\x2', '\xD3', '\xD7', '\a', '\x30', '\x2', '\x2', '\xD4', '\xD6', 
		'\x5', '\x8B', '\x46', '\x2', '\xD5', '\xD4', '\x3', '\x2', '\x2', '\x2', 
		'\xD6', '\xD9', '\x3', '\x2', '\x2', '\x2', '\xD7', '\xD5', '\x3', '\x2', 
		'\x2', '\x2', '\xD7', '\xD8', '\x3', '\x2', '\x2', '\x2', '\xD8', '\xDB', 
		'\x3', '\x2', '\x2', '\x2', '\xD9', '\xD7', '\x3', '\x2', '\x2', '\x2', 
		'\xDA', '\xDC', '\x5', '\x8F', 'H', '\x2', '\xDB', '\xDA', '\x3', '\x2', 
		'\x2', '\x2', '\xDB', '\xDC', '\x3', '\x2', '\x2', '\x2', '\xDC', '\xEE', 
		'\x3', '\x2', '\x2', '\x2', '\xDD', '\xDF', '\a', '\x30', '\x2', '\x2', 
		'\xDE', '\xE0', '\x5', '\x8B', '\x46', '\x2', '\xDF', '\xDE', '\x3', '\x2', 
		'\x2', '\x2', '\xE0', '\xE1', '\x3', '\x2', '\x2', '\x2', '\xE1', '\xDF', 
		'\x3', '\x2', '\x2', '\x2', '\xE1', '\xE2', '\x3', '\x2', '\x2', '\x2', 
		'\xE2', '\xE4', '\x3', '\x2', '\x2', '\x2', '\xE3', '\xE5', '\x5', '\x8F', 
		'H', '\x2', '\xE4', '\xE3', '\x3', '\x2', '\x2', '\x2', '\xE4', '\xE5', 
		'\x3', '\x2', '\x2', '\x2', '\xE5', '\xEE', '\x3', '\x2', '\x2', '\x2', 
		'\xE6', '\xE8', '\x5', '\x8B', '\x46', '\x2', '\xE7', '\xE6', '\x3', '\x2', 
		'\x2', '\x2', '\xE8', '\xE9', '\x3', '\x2', '\x2', '\x2', '\xE9', '\xE7', 
		'\x3', '\x2', '\x2', '\x2', '\xE9', '\xEA', '\x3', '\x2', '\x2', '\x2', 
		'\xEA', '\xEB', '\x3', '\x2', '\x2', '\x2', '\xEB', '\xEC', '\x5', '\x8F', 
		'H', '\x2', '\xEC', '\xEE', '\x3', '\x2', '\x2', '\x2', '\xED', '\xCF', 
		'\x3', '\x2', '\x2', '\x2', '\xED', '\xDD', '\x3', '\x2', '\x2', '\x2', 
		'\xED', '\xE7', '\x3', '\x2', '\x2', '\x2', '\xEE', '\x10', '\x3', '\x2', 
		'\x2', '\x2', '\xEF', '\xF0', '\a', '\x30', '\x2', '\x2', '\xF0', '\x12', 
		'\x3', '\x2', '\x2', '\x2', '\xF1', '\xF2', '\a', '\x63', '\x2', '\x2', 
		'\xF2', '\xF3', '\a', 'p', '\x2', '\x2', '\xF3', '\xF4', '\a', '\x66', 
		'\x2', '\x2', '\xF4', '\x14', '\x3', '\x2', '\x2', '\x2', '\xF5', '\xF6', 
		'\a', 'q', '\x2', '\x2', '\xF6', '\xF7', '\a', 't', '\x2', '\x2', '\xF7', 
		'\x16', '\x3', '\x2', '\x2', '\x2', '\xF8', '\xF9', '\a', 'p', '\x2', 
		'\x2', '\xF9', '\xFA', '\a', 'q', '\x2', '\x2', '\xFA', '\xFB', '\a', 
		'v', '\x2', '\x2', '\xFB', '\x18', '\x3', '\x2', '\x2', '\x2', '\xFC', 
		'\xFD', '\a', 'k', '\x2', '\x2', '\xFD', '\xFE', '\a', 'h', '\x2', '\x2', 
		'\xFE', '\x1A', '\x3', '\x2', '\x2', '\x2', '\xFF', '\x100', '\a', 'g', 
		'\x2', '\x2', '\x100', '\x101', '\a', 'n', '\x2', '\x2', '\x101', '\x102', 
		'\a', 'u', '\x2', '\x2', '\x102', '\x103', '\a', 'g', '\x2', '\x2', '\x103', 
		'\x1C', '\x3', '\x2', '\x2', '\x2', '\x104', '\x105', '\a', 'g', '\x2', 
		'\x2', '\x105', '\x106', '\a', 'n', '\x2', '\x2', '\x106', '\x107', '\a', 
		'u', '\x2', '\x2', '\x107', '\x108', '\a', 'g', '\x2', '\x2', '\x108', 
		'\x109', '\a', 'k', '\x2', '\x2', '\x109', '\x10A', '\a', 'h', '\x2', 
		'\x2', '\x10A', '\x1E', '\x3', '\x2', '\x2', '\x2', '\x10B', '\x10C', 
		'\a', 'v', '\x2', '\x2', '\x10C', '\x10D', '\a', 'j', '\x2', '\x2', '\x10D', 
		'\x10E', '\a', 'g', '\x2', '\x2', '\x10E', '\x10F', '\a', 'p', '\x2', 
		'\x2', '\x10F', ' ', '\x3', '\x2', '\x2', '\x2', '\x110', '\x111', '\a', 
		'w', '\x2', '\x2', '\x111', '\x112', '\a', 'p', '\x2', '\x2', '\x112', 
		'\x113', '\a', 'n', '\x2', '\x2', '\x113', '\x114', '\a', 'g', '\x2', 
		'\x2', '\x114', '\x115', '\a', 'u', '\x2', '\x2', '\x115', '\x116', '\a', 
		'u', '\x2', '\x2', '\x116', '\"', '\x3', '\x2', '\x2', '\x2', '\x117', 
		'\x118', '\a', '\x66', '\x2', '\x2', '\x118', '\x119', '\a', 'q', '\x2', 
		'\x2', '\x119', '$', '\x3', '\x2', '\x2', '\x2', '\x11A', '\x11B', '\a', 
		'y', '\x2', '\x2', '\x11B', '\x11C', '\a', 'j', '\x2', '\x2', '\x11C', 
		'\x11D', '\a', 'k', '\x2', '\x2', '\x11D', '\x11E', '\a', 'n', '\x2', 
		'\x2', '\x11E', '\x11F', '\a', 'g', '\x2', '\x2', '\x11F', '&', '\x3', 
		'\x2', '\x2', '\x2', '\x120', '\x121', '\a', 'n', '\x2', '\x2', '\x121', 
		'\x122', '\a', 'q', '\x2', '\x2', '\x122', '\x123', '\a', 'q', '\x2', 
		'\x2', '\x123', '\x124', '\a', 'r', '\x2', '\x2', '\x124', '(', '\x3', 
		'\x2', '\x2', '\x2', '\x125', '\x126', '\a', 'h', '\x2', '\x2', '\x126', 
		'\x127', '\a', 'q', '\x2', '\x2', '\x127', '\x128', '\a', 't', '\x2', 
		'\x2', '\x128', '*', '\x3', '\x2', '\x2', '\x2', '\x129', '\x12A', '\a', 
		't', '\x2', '\x2', '\x12A', '\x12B', '\a', 'g', '\x2', '\x2', '\x12B', 
		'\x12C', '\a', 'v', '\x2', '\x2', '\x12C', '\x12D', '\a', 'w', '\x2', 
		'\x2', '\x12D', '\x12E', '\a', 't', '\x2', '\x2', '\x12E', '\x12F', '\a', 
		'p', '\x2', '\x2', '\x12F', ',', '\x3', '\x2', '\x2', '\x2', '\x130', 
		'\x131', '\a', 'h', '\x2', '\x2', '\x131', '\x132', '\a', 'w', '\x2', 
		'\x2', '\x132', '\x133', '\a', 'p', '\x2', '\x2', '\x133', '\x134', '\a', 
		'\x65', '\x2', '\x2', '\x134', '.', '\x3', '\x2', '\x2', '\x2', '\x135', 
		'\x136', '\a', 'g', '\x2', '\x2', '\x136', '\x137', '\a', 'p', '\x2', 
		'\x2', '\x137', '\x138', '\a', '\x66', '\x2', '\x2', '\x138', '\x30', 
		'\x3', '\x2', '\x2', '\x2', '\x139', '\x13A', '\a', '\x64', '\x2', '\x2', 
		'\x13A', '\x13B', '\a', 't', '\x2', '\x2', '\x13B', '\x13C', '\a', 'g', 
		'\x2', '\x2', '\x13C', '\x13D', '\a', '\x63', '\x2', '\x2', '\x13D', '\x13E', 
		'\a', 'm', '\x2', '\x2', '\x13E', '\x32', '\x3', '\x2', '\x2', '\x2', 
		'\x13F', '\x140', '\a', 'p', '\x2', '\x2', '\x140', '\x141', '\a', 'g', 
		'\x2', '\x2', '\x141', '\x142', '\a', 'z', '\x2', '\x2', '\x142', '\x143', 
		'\a', 'v', '\x2', '\x2', '\x143', '\x34', '\x3', '\x2', '\x2', '\x2', 
		'\x144', '\x145', '\a', '\x65', '\x2', '\x2', '\x145', '\x146', '\a', 
		'q', '\x2', '\x2', '\x146', '\x147', '\a', 'p', '\x2', '\x2', '\x147', 
		'\x148', '\a', 'v', '\x2', '\x2', '\x148', '\x149', '\a', 'k', '\x2', 
		'\x2', '\x149', '\x14A', '\a', 'p', '\x2', '\x2', '\x14A', '\x14B', '\a', 
		'w', '\x2', '\x2', '\x14B', '\x14C', '\a', 'g', '\x2', '\x2', '\x14C', 
		'\x36', '\x3', '\x2', '\x2', '\x2', '\x14D', '\x14E', '\a', 'r', '\x2', 
		'\x2', '\x14E', '\x14F', '\a', 't', '\x2', '\x2', '\x14F', '\x150', '\a', 
		'k', '\x2', '\x2', '\x150', '\x151', '\a', 'p', '\x2', '\x2', '\x151', 
		'\x152', '\a', 'v', '\x2', '\x2', '\x152', '\x38', '\x3', '\x2', '\x2', 
		'\x2', '\x153', '\x154', '\a', 'x', '\x2', '\x2', '\x154', '\x155', '\a', 
		'\x63', '\x2', '\x2', '\x155', '\x156', '\a', 'n', '\x2', '\x2', '\x156', 
		':', '\x3', '\x2', '\x2', '\x2', '\x157', '\x158', '\a', '-', '\x2', '\x2', 
		'\x158', '\x159', '\a', '-', '\x2', '\x2', '\x159', '<', '\x3', '\x2', 
		'\x2', '\x2', '\x15A', '\x15B', '\a', '/', '\x2', '\x2', '\x15B', '\x15C', 
		'\a', '/', '\x2', '\x2', '\x15C', '>', '\x3', '\x2', '\x2', '\x2', '\x15D', 
		'\x15E', '\a', ',', '\x2', '\x2', '\x15E', '\x15F', '\a', '?', '\x2', 
		'\x2', '\x15F', '@', '\x3', '\x2', '\x2', '\x2', '\x160', '\x161', '\a', 
		'-', '\x2', '\x2', '\x161', '\x162', '\a', '?', '\x2', '\x2', '\x162', 
		'\x42', '\x3', '\x2', '\x2', '\x2', '\x163', '\x164', '\a', '/', '\x2', 
		'\x2', '\x164', '\x165', '\a', '?', '\x2', '\x2', '\x165', '\x44', '\x3', 
		'\x2', '\x2', '\x2', '\x166', '\x167', '\a', '\x31', '\x2', '\x2', '\x167', 
		'\x168', '\a', '?', '\x2', '\x2', '\x168', '\x46', '\x3', '\x2', '\x2', 
		'\x2', '\x169', '\x16A', '\a', '=', '\x2', '\x2', '\x16A', 'H', '\x3', 
		'\x2', '\x2', '\x2', '\x16B', '\x16C', '\a', ',', '\x2', '\x2', '\x16C', 
		'J', '\x3', '\x2', '\x2', '\x2', '\x16D', '\x16E', '\a', '\x31', '\x2', 
		'\x2', '\x16E', 'L', '\x3', '\x2', '\x2', '\x2', '\x16F', '\x170', '\a', 
		'-', '\x2', '\x2', '\x170', 'N', '\x3', '\x2', '\x2', '\x2', '\x171', 
		'\x172', '\a', '/', '\x2', '\x2', '\x172', 'P', '\x3', '\x2', '\x2', '\x2', 
		'\x173', '\x174', '\a', '\'', '\x2', '\x2', '\x174', 'R', '\x3', '\x2', 
		'\x2', '\x2', '\x175', '\x176', '\a', '`', '\x2', '\x2', '\x176', 'T', 
		'\x3', '\x2', '\x2', '\x2', '\x177', '\x178', '\a', '(', '\x2', '\x2', 
		'\x178', 'V', '\x3', '\x2', '\x2', '\x2', '\x179', '\x17A', '\a', '@', 
		'\x2', '\x2', '\x17A', 'X', '\x3', '\x2', '\x2', '\x2', '\x17B', '\x17C', 
		'\a', '@', '\x2', '\x2', '\x17C', '\x17D', '\a', '?', '\x2', '\x2', '\x17D', 
		'Z', '\x3', '\x2', '\x2', '\x2', '\x17E', '\x17F', '\a', '>', '\x2', '\x2', 
		'\x17F', '\\', '\x3', '\x2', '\x2', '\x2', '\x180', '\x181', '\a', '>', 
		'\x2', '\x2', '\x181', '\x182', '\a', '?', '\x2', '\x2', '\x182', '^', 
		'\x3', '\x2', '\x2', '\x2', '\x183', '\x184', '\a', '?', '\x2', '\x2', 
		'\x184', '`', '\x3', '\x2', '\x2', '\x2', '\x185', '\x186', '\a', '<', 
		'\x2', '\x2', '\x186', '\x187', '\a', '?', '\x2', '\x2', '\x187', '\x62', 
		'\x3', '\x2', '\x2', '\x2', '\x188', '\x189', '\a', '#', '\x2', '\x2', 
		'\x189', '\x18A', '\a', '?', '\x2', '\x2', '\x18A', '\x64', '\x3', '\x2', 
		'\x2', '\x2', '\x18B', '\x18C', '\a', '#', '\x2', '\x2', '\x18C', '\x66', 
		'\x3', '\x2', '\x2', '\x2', '\x18D', '\x18E', '\a', '(', '\x2', '\x2', 
		'\x18E', '\x18F', '\a', '(', '\x2', '\x2', '\x18F', 'h', '\x3', '\x2', 
		'\x2', '\x2', '\x190', '\x191', '\a', '~', '\x2', '\x2', '\x191', '\x192', 
		'\a', '~', '\x2', '\x2', '\x192', 'j', '\x3', '\x2', '\x2', '\x2', '\x193', 
		'\x194', '\a', '<', '\x2', '\x2', '\x194', 'l', '\x3', '\x2', '\x2', '\x2', 
		'\x195', '\x196', '\a', '.', '\x2', '\x2', '\x196', 'n', '\x3', '\x2', 
		'\x2', '\x2', '\x197', '\x198', '\a', ',', '\x2', '\x2', '\x198', '\x199', 
		'\a', ',', '\x2', '\x2', '\x199', 'p', '\x3', '\x2', '\x2', '\x2', '\x19A', 
		'\x19B', '\a', '\x41', '\x2', '\x2', '\x19B', 'r', '\x3', '\x2', '\x2', 
		'\x2', '\x19C', '\x19D', '\a', '*', '\x2', '\x2', '\x19D', 't', '\x3', 
		'\x2', '\x2', '\x2', '\x19E', '\x19F', '\a', '+', '\x2', '\x2', '\x19F', 
		'v', '\x3', '\x2', '\x2', '\x2', '\x1A0', '\x1A1', '\a', '/', '\x2', '\x2', 
		'\x1A1', '\x1A2', '\a', '@', '\x2', '\x2', '\x1A2', 'x', '\x3', '\x2', 
		'\x2', '\x2', '\x1A3', '\x1A4', '\a', ']', '\x2', '\x2', '\x1A4', 'z', 
		'\x3', '\x2', '\x2', '\x2', '\x1A5', '\x1A6', '\a', '_', '\x2', '\x2', 
		'\x1A6', '|', '\x3', '\x2', '\x2', '\x2', '\x1A7', '\x1A8', '\a', '}', 
		'\x2', '\x2', '\x1A8', '~', '\x3', '\x2', '\x2', '\x2', '\x1A9', '\x1AA', 
		'\a', '\x7F', '\x2', '\x2', '\x1AA', '\x80', '\x3', '\x2', '\x2', '\x2', 
		'\x1AB', '\x1AE', '\x5', '\x89', '\x45', '\x2', '\x1AC', '\x1AE', '\x5', 
		'\x8D', 'G', '\x2', '\x1AD', '\x1AB', '\x3', '\x2', '\x2', '\x2', '\x1AD', 
		'\x1AC', '\x3', '\x2', '\x2', '\x2', '\x1AE', '\x1B4', '\x3', '\x2', '\x2', 
		'\x2', '\x1AF', '\x1B3', '\x5', '\x89', '\x45', '\x2', '\x1B0', '\x1B3', 
		'\x5', '\x8B', '\x46', '\x2', '\x1B1', '\x1B3', '\x5', '\x8D', 'G', '\x2', 
		'\x1B2', '\x1AF', '\x3', '\x2', '\x2', '\x2', '\x1B2', '\x1B0', '\x3', 
		'\x2', '\x2', '\x2', '\x1B2', '\x1B1', '\x3', '\x2', '\x2', '\x2', '\x1B3', 
		'\x1B6', '\x3', '\x2', '\x2', '\x2', '\x1B4', '\x1B2', '\x3', '\x2', '\x2', 
		'\x2', '\x1B4', '\x1B5', '\x3', '\x2', '\x2', '\x2', '\x1B5', '\x82', 
		'\x3', '\x2', '\x2', '\x2', '\x1B6', '\x1B4', '\x3', '\x2', '\x2', '\x2', 
		'\x1B7', '\x1B8', '\x5', 'y', '=', '\x2', '\x1B8', '\x1B9', '\x5', '\x81', 
		'\x41', '\x2', '\x1B9', '\x1BA', '\x5', '{', '>', '\x2', '\x1BA', '\x84', 
		'\x3', '\x2', '\x2', '\x2', '\x1BB', '\x1BD', '\t', '\x4', '\x2', '\x2', 
		'\x1BC', '\x1BB', '\x3', '\x2', '\x2', '\x2', '\x1BD', '\x1BE', '\x3', 
		'\x2', '\x2', '\x2', '\x1BE', '\x1BC', '\x3', '\x2', '\x2', '\x2', '\x1BE', 
		'\x1BF', '\x3', '\x2', '\x2', '\x2', '\x1BF', '\x1C0', '\x3', '\x2', '\x2', 
		'\x2', '\x1C0', '\x1C1', '\b', '\x43', '\x2', '\x2', '\x1C1', '\x86', 
		'\x3', '\x2', '\x2', '\x2', '\x1C2', '\x1C3', '\v', '\x2', '\x2', '\x2', 
		'\x1C3', '\x1C4', '\x3', '\x2', '\x2', '\x2', '\x1C4', '\x1C5', '\b', 
		'\x44', '\x2', '\x2', '\x1C5', '\x88', '\x3', '\x2', '\x2', '\x2', '\x1C6', 
		'\x1C7', '\t', '\x5', '\x2', '\x2', '\x1C7', '\x8A', '\x3', '\x2', '\x2', 
		'\x2', '\x1C8', '\x1C9', '\t', '\x6', '\x2', '\x2', '\x1C9', '\x8C', '\x3', 
		'\x2', '\x2', '\x2', '\x1CA', '\x1CB', '\a', '\x61', '\x2', '\x2', '\x1CB', 
		'\x8E', '\x3', '\x2', '\x2', '\x2', '\x1CC', '\x1CE', '\t', '\a', '\x2', 
		'\x2', '\x1CD', '\x1CF', '\t', '\b', '\x2', '\x2', '\x1CE', '\x1CD', '\x3', 
		'\x2', '\x2', '\x2', '\x1CE', '\x1CF', '\x3', '\x2', '\x2', '\x2', '\x1CF', 
		'\x1D1', '\x3', '\x2', '\x2', '\x2', '\x1D0', '\x1D2', '\x4', '\x32', 
		';', '\x2', '\x1D1', '\x1D0', '\x3', '\x2', '\x2', '\x2', '\x1D2', '\x1D3', 
		'\x3', '\x2', '\x2', '\x2', '\x1D3', '\x1D1', '\x3', '\x2', '\x2', '\x2', 
		'\x1D3', '\x1D4', '\x3', '\x2', '\x2', '\x2', '\x1D4', '\x90', '\x3', 
		'\x2', '\x2', '\x2', '\x18', '\x2', '\x97', '\xA3', '\xB1', '\xB7', '\xBF', 
		'\xC3', '\xC7', '\xCC', '\xD1', '\xD7', '\xDB', '\xE1', '\xE4', '\xE9', 
		'\xED', '\x1AD', '\x1B2', '\x1B4', '\x1BE', '\x1CE', '\x1D3', '\x3', '\x2', 
		'\x3', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace Orchid.Parser
