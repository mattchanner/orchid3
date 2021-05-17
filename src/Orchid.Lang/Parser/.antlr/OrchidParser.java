// Generated from c:\Source\github\Orchid3\src\Orchid.Lang\Parser\OrchidParser.g4 by ANTLR 4.8
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class OrchidParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.8", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		MultiLineComment=1, SingleLineComment=2, BooleanLiteral=3, StringLiteral=4, 
		NumericLiteral=5, Integer=6, Float=7, Dot=8, And=9, Or=10, Not=11, If=12, 
		Else=13, ElseIf=14, Then=15, Unless=16, Do=17, While=18, For=19, Return=20, 
		Function=21, End=22, Break=23, Continue=24, SemiColon=25, Mul=26, Div=27, 
		Plus=28, Sub=29, Mod=30, Pow=31, Amp=32, Gt=33, Gte=34, Lt=35, Lte=36, 
		Eq=37, Assign=38, NotEq=39, UnaryNot=40, LogicalAnd=41, LogicalOr=42, 
		Colon=43, Comma=44, PowerOp=45, Question=46, OpenRound=47, CloseRound=48, 
		Arrow=49, OpenSquare=50, CloseSquare=51, OpenCurly=52, CloseCurly=53, 
		Name=54, Variable=55, WhiteSpace=56, Discardable=57;
	public static final int
		RULE_program = 0, RULE_statementList = 1, RULE_statement = 2, RULE_block = 3, 
		RULE_arrowFunctions = 4, RULE_expressionStatement = 5, RULE_declaration = 6, 
		RULE_functionDeclaration = 7, RULE_variableStatement = 8, RULE_formalParameterList = 9, 
		RULE_ifStatement = 10, RULE_returnStatement = 11, RULE_assignmentStatement = 12, 
		RULE_iterationStatement = 13, RULE_variableDeclarationList = 14, RULE_expressionSequence = 15, 
		RULE_singleExpression = 16, RULE_multiplicativeOperators = 17, RULE_additiveOperators = 18, 
		RULE_logicalAndOperators = 19, RULE_logicalOrOperators = 20, RULE_comparisonOperators = 21, 
		RULE_function = 22, RULE_identifier = 23, RULE_arrayLiteral = 24, RULE_literal = 25, 
		RULE_eos = 26;
	private static String[] makeRuleNames() {
		return new String[] {
			"program", "statementList", "statement", "block", "arrowFunctions", "expressionStatement", 
			"declaration", "functionDeclaration", "variableStatement", "formalParameterList", 
			"ifStatement", "returnStatement", "assignmentStatement", "iterationStatement", 
			"variableDeclarationList", "expressionSequence", "singleExpression", 
			"multiplicativeOperators", "additiveOperators", "logicalAndOperators", 
			"logicalOrOperators", "comparisonOperators", "function", "identifier", 
			"arrayLiteral", "literal", "eos"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, null, null, null, null, null, null, null, "'.'", "'and'", "'or'", 
			"'not'", "'if'", "'else'", "'elseif'", "'then'", "'unless'", "'do'", 
			"'while'", "'for'", "'return'", "'func'", "'end'", "'break'", "'continue'", 
			"';'", "'*'", "'/'", "'+'", "'-'", "'%'", "'^'", "'&'", "'>'", "'>='", 
			"'<'", "'<='", "'='", "':='", "'!='", "'!'", "'&&'", "'||'", "':'", "','", 
			"'**'", "'?'", "'('", "')'", "'=>'", "'['", "']'", "'{'", "'}'"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, "MultiLineComment", "SingleLineComment", "BooleanLiteral", "StringLiteral", 
			"NumericLiteral", "Integer", "Float", "Dot", "And", "Or", "Not", "If", 
			"Else", "ElseIf", "Then", "Unless", "Do", "While", "For", "Return", "Function", 
			"End", "Break", "Continue", "SemiColon", "Mul", "Div", "Plus", "Sub", 
			"Mod", "Pow", "Amp", "Gt", "Gte", "Lt", "Lte", "Eq", "Assign", "NotEq", 
			"UnaryNot", "LogicalAnd", "LogicalOr", "Colon", "Comma", "PowerOp", "Question", 
			"OpenRound", "CloseRound", "Arrow", "OpenSquare", "CloseSquare", "OpenCurly", 
			"CloseCurly", "Name", "Variable", "WhiteSpace", "Discardable"
		};
	}
	private static final String[] _SYMBOLIC_NAMES = makeSymbolicNames();
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}

	@Override
	public String getGrammarFileName() { return "OrchidParser.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public OrchidParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	public static class ProgramContext extends ParserRuleContext {
		public StatementListContext statementList() {
			return getRuleContext(StatementListContext.class,0);
		}
		public TerminalNode EOF() { return getToken(OrchidParser.EOF, 0); }
		public ProgramContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_program; }
	}

	public final ProgramContext program() throws RecognitionException {
		ProgramContext _localctx = new ProgramContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_program);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(54);
			statementList();
			setState(55);
			match(EOF);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class StatementListContext extends ParserRuleContext {
		public List<StatementContext> statement() {
			return getRuleContexts(StatementContext.class);
		}
		public StatementContext statement(int i) {
			return getRuleContext(StatementContext.class,i);
		}
		public StatementListContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_statementList; }
	}

	public final StatementListContext statementList() throws RecognitionException {
		StatementListContext _localctx = new StatementListContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_statementList);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(58); 
			_errHandler.sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					setState(57);
					statement();
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				setState(60); 
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,0,_ctx);
			} while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class StatementContext extends ParserRuleContext {
		public IterationStatementContext iterationStatement() {
			return getRuleContext(IterationStatementContext.class,0);
		}
		public AssignmentStatementContext assignmentStatement() {
			return getRuleContext(AssignmentStatementContext.class,0);
		}
		public BlockContext block() {
			return getRuleContext(BlockContext.class,0);
		}
		public IfStatementContext ifStatement() {
			return getRuleContext(IfStatementContext.class,0);
		}
		public FunctionDeclarationContext functionDeclaration() {
			return getRuleContext(FunctionDeclarationContext.class,0);
		}
		public DeclarationContext declaration() {
			return getRuleContext(DeclarationContext.class,0);
		}
		public ReturnStatementContext returnStatement() {
			return getRuleContext(ReturnStatementContext.class,0);
		}
		public StatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_statement; }
	}

	public final StatementContext statement() throws RecognitionException {
		StatementContext _localctx = new StatementContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_statement);
		try {
			setState(69);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,1,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(62);
				iterationStatement();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(63);
				assignmentStatement();
				}
				break;
			case 3:
				enterOuterAlt(_localctx, 3);
				{
				setState(64);
				block();
				}
				break;
			case 4:
				enterOuterAlt(_localctx, 4);
				{
				setState(65);
				ifStatement();
				}
				break;
			case 5:
				enterOuterAlt(_localctx, 5);
				{
				setState(66);
				functionDeclaration();
				}
				break;
			case 6:
				enterOuterAlt(_localctx, 6);
				{
				setState(67);
				declaration();
				}
				break;
			case 7:
				enterOuterAlt(_localctx, 7);
				{
				setState(68);
				returnStatement();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class BlockContext extends ParserRuleContext {
		public TerminalNode Do() { return getToken(OrchidParser.Do, 0); }
		public StatementListContext statementList() {
			return getRuleContext(StatementListContext.class,0);
		}
		public TerminalNode End() { return getToken(OrchidParser.End, 0); }
		public BlockContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_block; }
	}

	public final BlockContext block() throws RecognitionException {
		BlockContext _localctx = new BlockContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_block);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(71);
			match(Do);
			setState(72);
			statementList();
			setState(73);
			match(End);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ArrowFunctionsContext extends ParserRuleContext {
		public TerminalNode OpenRound() { return getToken(OrchidParser.OpenRound, 0); }
		public FormalParameterListContext formalParameterList() {
			return getRuleContext(FormalParameterListContext.class,0);
		}
		public TerminalNode CloseRound() { return getToken(OrchidParser.CloseRound, 0); }
		public TerminalNode Arrow() { return getToken(OrchidParser.Arrow, 0); }
		public TerminalNode Do() { return getToken(OrchidParser.Do, 0); }
		public StatementListContext statementList() {
			return getRuleContext(StatementListContext.class,0);
		}
		public TerminalNode End() { return getToken(OrchidParser.End, 0); }
		public ArrowFunctionsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_arrowFunctions; }
	}

	public final ArrowFunctionsContext arrowFunctions() throws RecognitionException {
		ArrowFunctionsContext _localctx = new ArrowFunctionsContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_arrowFunctions);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(75);
			match(OpenRound);
			setState(76);
			formalParameterList();
			setState(77);
			match(CloseRound);
			setState(78);
			match(Arrow);
			setState(79);
			match(Do);
			setState(80);
			statementList();
			setState(81);
			match(End);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ExpressionStatementContext extends ParserRuleContext {
		public ExpressionSequenceContext expressionSequence() {
			return getRuleContext(ExpressionSequenceContext.class,0);
		}
		public ExpressionStatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_expressionStatement; }
	}

	public final ExpressionStatementContext expressionStatement() throws RecognitionException {
		ExpressionStatementContext _localctx = new ExpressionStatementContext(_ctx, getState());
		enterRule(_localctx, 10, RULE_expressionStatement);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(83);
			expressionSequence();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class DeclarationContext extends ParserRuleContext {
		public VariableStatementContext variableStatement() {
			return getRuleContext(VariableStatementContext.class,0);
		}
		public FunctionDeclarationContext functionDeclaration() {
			return getRuleContext(FunctionDeclarationContext.class,0);
		}
		public DeclarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_declaration; }
	}

	public final DeclarationContext declaration() throws RecognitionException {
		DeclarationContext _localctx = new DeclarationContext(_ctx, getState());
		enterRule(_localctx, 12, RULE_declaration);
		try {
			setState(87);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case Name:
			case Variable:
				enterOuterAlt(_localctx, 1);
				{
				setState(85);
				variableStatement();
				}
				break;
			case Function:
				enterOuterAlt(_localctx, 2);
				{
				setState(86);
				functionDeclaration();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class FunctionDeclarationContext extends ParserRuleContext {
		public TerminalNode Function() { return getToken(OrchidParser.Function, 0); }
		public IdentifierContext identifier() {
			return getRuleContext(IdentifierContext.class,0);
		}
		public TerminalNode OpenRound() { return getToken(OrchidParser.OpenRound, 0); }
		public FormalParameterListContext formalParameterList() {
			return getRuleContext(FormalParameterListContext.class,0);
		}
		public TerminalNode CloseRound() { return getToken(OrchidParser.CloseRound, 0); }
		public TerminalNode Do() { return getToken(OrchidParser.Do, 0); }
		public StatementListContext statementList() {
			return getRuleContext(StatementListContext.class,0);
		}
		public TerminalNode End() { return getToken(OrchidParser.End, 0); }
		public FunctionDeclarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_functionDeclaration; }
	}

	public final FunctionDeclarationContext functionDeclaration() throws RecognitionException {
		FunctionDeclarationContext _localctx = new FunctionDeclarationContext(_ctx, getState());
		enterRule(_localctx, 14, RULE_functionDeclaration);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(89);
			match(Function);
			setState(90);
			identifier();
			setState(91);
			match(OpenRound);
			setState(92);
			formalParameterList();
			setState(93);
			match(CloseRound);
			setState(94);
			match(Do);
			setState(95);
			statementList();
			setState(96);
			match(End);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class VariableStatementContext extends ParserRuleContext {
		public IdentifierContext identifier() {
			return getRuleContext(IdentifierContext.class,0);
		}
		public TerminalNode Assign() { return getToken(OrchidParser.Assign, 0); }
		public SingleExpressionContext singleExpression() {
			return getRuleContext(SingleExpressionContext.class,0);
		}
		public VariableStatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_variableStatement; }
	}

	public final VariableStatementContext variableStatement() throws RecognitionException {
		VariableStatementContext _localctx = new VariableStatementContext(_ctx, getState());
		enterRule(_localctx, 16, RULE_variableStatement);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(98);
			identifier();
			setState(99);
			match(Assign);
			setState(100);
			singleExpression(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class FormalParameterListContext extends ParserRuleContext {
		public List<TerminalNode> Name() { return getTokens(OrchidParser.Name); }
		public TerminalNode Name(int i) {
			return getToken(OrchidParser.Name, i);
		}
		public List<TerminalNode> Comma() { return getTokens(OrchidParser.Comma); }
		public TerminalNode Comma(int i) {
			return getToken(OrchidParser.Comma, i);
		}
		public FormalParameterListContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_formalParameterList; }
	}

	public final FormalParameterListContext formalParameterList() throws RecognitionException {
		FormalParameterListContext _localctx = new FormalParameterListContext(_ctx, getState());
		enterRule(_localctx, 18, RULE_formalParameterList);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(102);
			match(Name);
			setState(107);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==Comma) {
				{
				{
				setState(103);
				match(Comma);
				setState(104);
				match(Name);
				}
				}
				setState(109);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class IfStatementContext extends ParserRuleContext {
		public TerminalNode If() { return getToken(OrchidParser.If, 0); }
		public List<SingleExpressionContext> singleExpression() {
			return getRuleContexts(SingleExpressionContext.class);
		}
		public SingleExpressionContext singleExpression(int i) {
			return getRuleContext(SingleExpressionContext.class,i);
		}
		public List<TerminalNode> Then() { return getTokens(OrchidParser.Then); }
		public TerminalNode Then(int i) {
			return getToken(OrchidParser.Then, i);
		}
		public List<StatementListContext> statementList() {
			return getRuleContexts(StatementListContext.class);
		}
		public StatementListContext statementList(int i) {
			return getRuleContext(StatementListContext.class,i);
		}
		public TerminalNode Else() { return getToken(OrchidParser.Else, 0); }
		public TerminalNode End() { return getToken(OrchidParser.End, 0); }
		public List<TerminalNode> ElseIf() { return getTokens(OrchidParser.ElseIf); }
		public TerminalNode ElseIf(int i) {
			return getToken(OrchidParser.ElseIf, i);
		}
		public IfStatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_ifStatement; }
	}

	public final IfStatementContext ifStatement() throws RecognitionException {
		IfStatementContext _localctx = new IfStatementContext(_ctx, getState());
		enterRule(_localctx, 20, RULE_ifStatement);
		int _la;
		try {
			setState(138);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,7,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(110);
				match(If);
				setState(111);
				singleExpression(0);
				setState(112);
				match(Then);
				setState(113);
				statementList();
				setState(116);
				_errHandler.sync(this);
				switch ( getInterpreter().adaptivePredict(_input,4,_ctx) ) {
				case 1:
					{
					setState(114);
					match(Else);
					setState(115);
					statementList();
					}
					break;
				}
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(118);
				match(If);
				setState(119);
				singleExpression(0);
				setState(120);
				match(Then);
				setState(121);
				statementList();
				setState(129);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while (_la==ElseIf) {
					{
					{
					setState(122);
					match(ElseIf);
					setState(123);
					singleExpression(0);
					setState(124);
					match(Then);
					setState(125);
					statementList();
					}
					}
					setState(131);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				setState(134);
				_errHandler.sync(this);
				_la = _input.LA(1);
				if (_la==Else) {
					{
					setState(132);
					match(Else);
					setState(133);
					statementList();
					}
				}

				setState(136);
				match(End);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ReturnStatementContext extends ParserRuleContext {
		public TerminalNode Return() { return getToken(OrchidParser.Return, 0); }
		public SingleExpressionContext singleExpression() {
			return getRuleContext(SingleExpressionContext.class,0);
		}
		public ReturnStatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_returnStatement; }
	}

	public final ReturnStatementContext returnStatement() throws RecognitionException {
		ReturnStatementContext _localctx = new ReturnStatementContext(_ctx, getState());
		enterRule(_localctx, 22, RULE_returnStatement);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(140);
			match(Return);
			setState(141);
			singleExpression(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class AssignmentStatementContext extends ParserRuleContext {
		public IdentifierContext identifier() {
			return getRuleContext(IdentifierContext.class,0);
		}
		public TerminalNode Assign() { return getToken(OrchidParser.Assign, 0); }
		public SingleExpressionContext singleExpression() {
			return getRuleContext(SingleExpressionContext.class,0);
		}
		public AssignmentStatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_assignmentStatement; }
	}

	public final AssignmentStatementContext assignmentStatement() throws RecognitionException {
		AssignmentStatementContext _localctx = new AssignmentStatementContext(_ctx, getState());
		enterRule(_localctx, 24, RULE_assignmentStatement);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(143);
			identifier();
			setState(144);
			match(Assign);
			setState(145);
			singleExpression(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class IterationStatementContext extends ParserRuleContext {
		public IterationStatementContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_iterationStatement; }
	 
		public IterationStatementContext() { }
		public void copyFrom(IterationStatementContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class DoStatementContext extends IterationStatementContext {
		public TerminalNode Do() { return getToken(OrchidParser.Do, 0); }
		public StatementListContext statementList() {
			return getRuleContext(StatementListContext.class,0);
		}
		public TerminalNode While() { return getToken(OrchidParser.While, 0); }
		public SingleExpressionContext singleExpression() {
			return getRuleContext(SingleExpressionContext.class,0);
		}
		public TerminalNode End() { return getToken(OrchidParser.End, 0); }
		public DoStatementContext(IterationStatementContext ctx) { copyFrom(ctx); }
	}
	public static class WhileStatementContext extends IterationStatementContext {
		public TerminalNode While() { return getToken(OrchidParser.While, 0); }
		public SingleExpressionContext singleExpression() {
			return getRuleContext(SingleExpressionContext.class,0);
		}
		public TerminalNode Do() { return getToken(OrchidParser.Do, 0); }
		public StatementListContext statementList() {
			return getRuleContext(StatementListContext.class,0);
		}
		public TerminalNode End() { return getToken(OrchidParser.End, 0); }
		public WhileStatementContext(IterationStatementContext ctx) { copyFrom(ctx); }
	}
	public static class ForStatementContext extends IterationStatementContext {
		public TerminalNode For() { return getToken(OrchidParser.For, 0); }
		public List<TerminalNode> SemiColon() { return getTokens(OrchidParser.SemiColon); }
		public TerminalNode SemiColon(int i) {
			return getToken(OrchidParser.SemiColon, i);
		}
		public List<SingleExpressionContext> singleExpression() {
			return getRuleContexts(SingleExpressionContext.class);
		}
		public SingleExpressionContext singleExpression(int i) {
			return getRuleContext(SingleExpressionContext.class,i);
		}
		public TerminalNode Do() { return getToken(OrchidParser.Do, 0); }
		public StatementListContext statementList() {
			return getRuleContext(StatementListContext.class,0);
		}
		public TerminalNode End() { return getToken(OrchidParser.End, 0); }
		public VariableDeclarationListContext variableDeclarationList() {
			return getRuleContext(VariableDeclarationListContext.class,0);
		}
		public ForStatementContext(IterationStatementContext ctx) { copyFrom(ctx); }
	}

	public final IterationStatementContext iterationStatement() throws RecognitionException {
		IterationStatementContext _localctx = new IterationStatementContext(_ctx, getState());
		enterRule(_localctx, 26, RULE_iterationStatement);
		try {
			setState(172);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case Do:
				_localctx = new DoStatementContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(147);
				match(Do);
				setState(148);
				statementList();
				setState(149);
				match(While);
				setState(150);
				singleExpression(0);
				setState(151);
				match(End);
				}
				break;
			case While:
				_localctx = new WhileStatementContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(153);
				match(While);
				setState(154);
				singleExpression(0);
				setState(155);
				match(Do);
				setState(156);
				statementList();
				setState(157);
				match(End);
				}
				break;
			case For:
				_localctx = new ForStatementContext(_localctx);
				enterOuterAlt(_localctx, 3);
				{
				setState(159);
				match(For);
				setState(162);
				_errHandler.sync(this);
				switch ( getInterpreter().adaptivePredict(_input,8,_ctx) ) {
				case 1:
					{
					setState(160);
					singleExpression(0);
					}
					break;
				case 2:
					{
					setState(161);
					variableDeclarationList();
					}
					break;
				}
				setState(164);
				match(SemiColon);
				setState(165);
				singleExpression(0);
				setState(166);
				match(SemiColon);
				setState(167);
				singleExpression(0);
				setState(168);
				match(Do);
				setState(169);
				statementList();
				setState(170);
				match(End);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class VariableDeclarationListContext extends ParserRuleContext {
		public IdentifierContext identifier() {
			return getRuleContext(IdentifierContext.class,0);
		}
		public TerminalNode Assign() { return getToken(OrchidParser.Assign, 0); }
		public SingleExpressionContext singleExpression() {
			return getRuleContext(SingleExpressionContext.class,0);
		}
		public VariableDeclarationListContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_variableDeclarationList; }
	}

	public final VariableDeclarationListContext variableDeclarationList() throws RecognitionException {
		VariableDeclarationListContext _localctx = new VariableDeclarationListContext(_ctx, getState());
		enterRule(_localctx, 28, RULE_variableDeclarationList);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(174);
			identifier();
			setState(175);
			match(Assign);
			setState(176);
			singleExpression(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ExpressionSequenceContext extends ParserRuleContext {
		public List<SingleExpressionContext> singleExpression() {
			return getRuleContexts(SingleExpressionContext.class);
		}
		public SingleExpressionContext singleExpression(int i) {
			return getRuleContext(SingleExpressionContext.class,i);
		}
		public List<TerminalNode> Comma() { return getTokens(OrchidParser.Comma); }
		public TerminalNode Comma(int i) {
			return getToken(OrchidParser.Comma, i);
		}
		public ExpressionSequenceContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_expressionSequence; }
	}

	public final ExpressionSequenceContext expressionSequence() throws RecognitionException {
		ExpressionSequenceContext _localctx = new ExpressionSequenceContext(_ctx, getState());
		enterRule(_localctx, 30, RULE_expressionSequence);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(178);
			singleExpression(0);
			setState(183);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==Comma) {
				{
				{
				setState(179);
				match(Comma);
				setState(180);
				singleExpression(0);
				}
				}
				setState(185);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class SingleExpressionContext extends ParserRuleContext {
		public SingleExpressionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_singleExpression; }
	 
		public SingleExpressionContext() { }
		public void copyFrom(SingleExpressionContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class AdditiveExpressionContext extends SingleExpressionContext {
		public List<SingleExpressionContext> singleExpression() {
			return getRuleContexts(SingleExpressionContext.class);
		}
		public SingleExpressionContext singleExpression(int i) {
			return getRuleContext(SingleExpressionContext.class,i);
		}
		public AdditiveOperatorsContext additiveOperators() {
			return getRuleContext(AdditiveOperatorsContext.class,0);
		}
		public AdditiveExpressionContext(SingleExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class RelationalExpressionContext extends SingleExpressionContext {
		public List<SingleExpressionContext> singleExpression() {
			return getRuleContexts(SingleExpressionContext.class);
		}
		public SingleExpressionContext singleExpression(int i) {
			return getRuleContext(SingleExpressionContext.class,i);
		}
		public ComparisonOperatorsContext comparisonOperators() {
			return getRuleContext(ComparisonOperatorsContext.class,0);
		}
		public RelationalExpressionContext(SingleExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class TernaryExpressionContext extends SingleExpressionContext {
		public List<SingleExpressionContext> singleExpression() {
			return getRuleContexts(SingleExpressionContext.class);
		}
		public SingleExpressionContext singleExpression(int i) {
			return getRuleContext(SingleExpressionContext.class,i);
		}
		public TerminalNode Question() { return getToken(OrchidParser.Question, 0); }
		public TerminalNode Colon() { return getToken(OrchidParser.Colon, 0); }
		public TernaryExpressionContext(SingleExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class LogicalAndExpressionContext extends SingleExpressionContext {
		public List<SingleExpressionContext> singleExpression() {
			return getRuleContexts(SingleExpressionContext.class);
		}
		public SingleExpressionContext singleExpression(int i) {
			return getRuleContext(SingleExpressionContext.class,i);
		}
		public LogicalAndOperatorsContext logicalAndOperators() {
			return getRuleContext(LogicalAndOperatorsContext.class,0);
		}
		public LogicalAndExpressionContext(SingleExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class PowerExpressionContext extends SingleExpressionContext {
		public List<SingleExpressionContext> singleExpression() {
			return getRuleContexts(SingleExpressionContext.class);
		}
		public SingleExpressionContext singleExpression(int i) {
			return getRuleContext(SingleExpressionContext.class,i);
		}
		public TerminalNode PowerOp() { return getToken(OrchidParser.PowerOp, 0); }
		public PowerExpressionContext(SingleExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class UnlessExpressionContext extends SingleExpressionContext {
		public List<SingleExpressionContext> singleExpression() {
			return getRuleContexts(SingleExpressionContext.class);
		}
		public SingleExpressionContext singleExpression(int i) {
			return getRuleContext(SingleExpressionContext.class,i);
		}
		public TerminalNode Unless() { return getToken(OrchidParser.Unless, 0); }
		public UnlessExpressionContext(SingleExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class LiteralExpressionContext extends SingleExpressionContext {
		public LiteralContext literal() {
			return getRuleContext(LiteralContext.class,0);
		}
		public LiteralExpressionContext(SingleExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class LogicalOrExpressionContext extends SingleExpressionContext {
		public List<SingleExpressionContext> singleExpression() {
			return getRuleContexts(SingleExpressionContext.class);
		}
		public SingleExpressionContext singleExpression(int i) {
			return getRuleContext(SingleExpressionContext.class,i);
		}
		public LogicalOrOperatorsContext logicalOrOperators() {
			return getRuleContext(LogicalOrOperatorsContext.class,0);
		}
		public LogicalOrExpressionContext(SingleExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class ArrayLiteralExpressionContext extends SingleExpressionContext {
		public ArrayLiteralContext arrayLiteral() {
			return getRuleContext(ArrayLiteralContext.class,0);
		}
		public ArrayLiteralExpressionContext(SingleExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class ParenethesizedExpressionContext extends SingleExpressionContext {
		public TerminalNode OpenRound() { return getToken(OrchidParser.OpenRound, 0); }
		public SingleExpressionContext singleExpression() {
			return getRuleContext(SingleExpressionContext.class,0);
		}
		public TerminalNode CloseRound() { return getToken(OrchidParser.CloseRound, 0); }
		public ParenethesizedExpressionContext(SingleExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class NotExpressionContext extends SingleExpressionContext {
		public TerminalNode UnaryNot() { return getToken(OrchidParser.UnaryNot, 0); }
		public SingleExpressionContext singleExpression() {
			return getRuleContext(SingleExpressionContext.class,0);
		}
		public NotExpressionContext(SingleExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class FunctionCallExpressionContext extends SingleExpressionContext {
		public FunctionContext function() {
			return getRuleContext(FunctionContext.class,0);
		}
		public FunctionCallExpressionContext(SingleExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class IdentifierExpressionContext extends SingleExpressionContext {
		public IdentifierContext identifier() {
			return getRuleContext(IdentifierContext.class,0);
		}
		public IdentifierExpressionContext(SingleExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class UnaryMinusExpressionContext extends SingleExpressionContext {
		public TerminalNode Sub() { return getToken(OrchidParser.Sub, 0); }
		public SingleExpressionContext singleExpression() {
			return getRuleContext(SingleExpressionContext.class,0);
		}
		public UnaryMinusExpressionContext(SingleExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class UnaryPlusExpressionContext extends SingleExpressionContext {
		public TerminalNode Plus() { return getToken(OrchidParser.Plus, 0); }
		public SingleExpressionContext singleExpression() {
			return getRuleContext(SingleExpressionContext.class,0);
		}
		public UnaryPlusExpressionContext(SingleExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class ArrowFunctionExpressionContext extends SingleExpressionContext {
		public ArrowFunctionsContext arrowFunctions() {
			return getRuleContext(ArrowFunctionsContext.class,0);
		}
		public ArrowFunctionExpressionContext(SingleExpressionContext ctx) { copyFrom(ctx); }
	}
	public static class MultiplicativeExpressionContext extends SingleExpressionContext {
		public List<SingleExpressionContext> singleExpression() {
			return getRuleContexts(SingleExpressionContext.class);
		}
		public SingleExpressionContext singleExpression(int i) {
			return getRuleContext(SingleExpressionContext.class,i);
		}
		public MultiplicativeOperatorsContext multiplicativeOperators() {
			return getRuleContext(MultiplicativeOperatorsContext.class,0);
		}
		public MultiplicativeExpressionContext(SingleExpressionContext ctx) { copyFrom(ctx); }
	}

	public final SingleExpressionContext singleExpression() throws RecognitionException {
		return singleExpression(0);
	}

	private SingleExpressionContext singleExpression(int _p) throws RecognitionException {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = getState();
		SingleExpressionContext _localctx = new SingleExpressionContext(_ctx, _parentState);
		SingleExpressionContext _prevctx = _localctx;
		int _startState = 32;
		enterRecursionRule(_localctx, 32, RULE_singleExpression, _p);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(202);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,11,_ctx) ) {
			case 1:
				{
				_localctx = new FunctionCallExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;

				setState(187);
				function();
				}
				break;
			case 2:
				{
				_localctx = new ArrowFunctionExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(188);
				arrowFunctions();
				}
				break;
			case 3:
				{
				_localctx = new NotExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(189);
				match(UnaryNot);
				setState(190);
				singleExpression(8);
				}
				break;
			case 4:
				{
				_localctx = new UnaryMinusExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(191);
				match(Sub);
				setState(192);
				singleExpression(7);
				}
				break;
			case 5:
				{
				_localctx = new UnaryPlusExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(193);
				match(Plus);
				setState(194);
				singleExpression(6);
				}
				break;
			case 6:
				{
				_localctx = new IdentifierExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(195);
				identifier();
				}
				break;
			case 7:
				{
				_localctx = new LiteralExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(196);
				literal();
				}
				break;
			case 8:
				{
				_localctx = new ArrayLiteralExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(197);
				arrayLiteral();
				}
				break;
			case 9:
				{
				_localctx = new ParenethesizedExpressionContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(198);
				match(OpenRound);
				setState(199);
				singleExpression(0);
				setState(200);
				match(CloseRound);
				}
				break;
			}
			_ctx.stop = _input.LT(-1);
			setState(238);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,13,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					setState(236);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,12,_ctx) ) {
					case 1:
						{
						_localctx = new UnlessExpressionContext(new SingleExpressionContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_singleExpression);
						setState(204);
						if (!(precpred(_ctx, 16))) throw new FailedPredicateException(this, "precpred(_ctx, 16)");
						setState(205);
						match(Unless);
						setState(206);
						singleExpression(17);
						}
						break;
					case 2:
						{
						_localctx = new MultiplicativeExpressionContext(new SingleExpressionContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_singleExpression);
						setState(207);
						if (!(precpred(_ctx, 14))) throw new FailedPredicateException(this, "precpred(_ctx, 14)");
						setState(208);
						multiplicativeOperators();
						setState(209);
						singleExpression(15);
						}
						break;
					case 3:
						{
						_localctx = new AdditiveExpressionContext(new SingleExpressionContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_singleExpression);
						setState(211);
						if (!(precpred(_ctx, 13))) throw new FailedPredicateException(this, "precpred(_ctx, 13)");
						setState(212);
						additiveOperators();
						setState(213);
						singleExpression(14);
						}
						break;
					case 4:
						{
						_localctx = new RelationalExpressionContext(new SingleExpressionContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_singleExpression);
						setState(215);
						if (!(precpred(_ctx, 12))) throw new FailedPredicateException(this, "precpred(_ctx, 12)");
						setState(216);
						comparisonOperators();
						setState(217);
						singleExpression(13);
						}
						break;
					case 5:
						{
						_localctx = new LogicalAndExpressionContext(new SingleExpressionContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_singleExpression);
						setState(219);
						if (!(precpred(_ctx, 11))) throw new FailedPredicateException(this, "precpred(_ctx, 11)");
						setState(220);
						logicalAndOperators();
						setState(221);
						singleExpression(12);
						}
						break;
					case 6:
						{
						_localctx = new LogicalOrExpressionContext(new SingleExpressionContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_singleExpression);
						setState(223);
						if (!(precpred(_ctx, 10))) throw new FailedPredicateException(this, "precpred(_ctx, 10)");
						setState(224);
						logicalOrOperators();
						setState(225);
						singleExpression(11);
						}
						break;
					case 7:
						{
						_localctx = new TernaryExpressionContext(new SingleExpressionContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_singleExpression);
						setState(227);
						if (!(precpred(_ctx, 9))) throw new FailedPredicateException(this, "precpred(_ctx, 9)");
						setState(228);
						match(Question);
						setState(229);
						singleExpression(0);
						setState(230);
						match(Colon);
						setState(231);
						singleExpression(10);
						}
						break;
					case 8:
						{
						_localctx = new PowerExpressionContext(new SingleExpressionContext(_parentctx, _parentState));
						pushNewRecursionContext(_localctx, _startState, RULE_singleExpression);
						setState(233);
						if (!(precpred(_ctx, 5))) throw new FailedPredicateException(this, "precpred(_ctx, 5)");
						setState(234);
						match(PowerOp);
						setState(235);
						singleExpression(5);
						}
						break;
					}
					} 
				}
				setState(240);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,13,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			unrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public static class MultiplicativeOperatorsContext extends ParserRuleContext {
		public TerminalNode Mul() { return getToken(OrchidParser.Mul, 0); }
		public TerminalNode Div() { return getToken(OrchidParser.Div, 0); }
		public TerminalNode Mod() { return getToken(OrchidParser.Mod, 0); }
		public MultiplicativeOperatorsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_multiplicativeOperators; }
	}

	public final MultiplicativeOperatorsContext multiplicativeOperators() throws RecognitionException {
		MultiplicativeOperatorsContext _localctx = new MultiplicativeOperatorsContext(_ctx, getState());
		enterRule(_localctx, 34, RULE_multiplicativeOperators);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(241);
			_la = _input.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Mul) | (1L << Div) | (1L << Mod))) != 0)) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class AdditiveOperatorsContext extends ParserRuleContext {
		public TerminalNode Plus() { return getToken(OrchidParser.Plus, 0); }
		public TerminalNode Sub() { return getToken(OrchidParser.Sub, 0); }
		public AdditiveOperatorsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_additiveOperators; }
	}

	public final AdditiveOperatorsContext additiveOperators() throws RecognitionException {
		AdditiveOperatorsContext _localctx = new AdditiveOperatorsContext(_ctx, getState());
		enterRule(_localctx, 36, RULE_additiveOperators);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(243);
			_la = _input.LA(1);
			if ( !(_la==Plus || _la==Sub) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class LogicalAndOperatorsContext extends ParserRuleContext {
		public TerminalNode LogicalAnd() { return getToken(OrchidParser.LogicalAnd, 0); }
		public TerminalNode And() { return getToken(OrchidParser.And, 0); }
		public LogicalAndOperatorsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_logicalAndOperators; }
	}

	public final LogicalAndOperatorsContext logicalAndOperators() throws RecognitionException {
		LogicalAndOperatorsContext _localctx = new LogicalAndOperatorsContext(_ctx, getState());
		enterRule(_localctx, 38, RULE_logicalAndOperators);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(245);
			_la = _input.LA(1);
			if ( !(_la==And || _la==LogicalAnd) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class LogicalOrOperatorsContext extends ParserRuleContext {
		public TerminalNode LogicalOr() { return getToken(OrchidParser.LogicalOr, 0); }
		public TerminalNode Or() { return getToken(OrchidParser.Or, 0); }
		public LogicalOrOperatorsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_logicalOrOperators; }
	}

	public final LogicalOrOperatorsContext logicalOrOperators() throws RecognitionException {
		LogicalOrOperatorsContext _localctx = new LogicalOrOperatorsContext(_ctx, getState());
		enterRule(_localctx, 40, RULE_logicalOrOperators);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(247);
			_la = _input.LA(1);
			if ( !(_la==Or || _la==LogicalOr) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ComparisonOperatorsContext extends ParserRuleContext {
		public TerminalNode NotEq() { return getToken(OrchidParser.NotEq, 0); }
		public TerminalNode Eq() { return getToken(OrchidParser.Eq, 0); }
		public TerminalNode Lt() { return getToken(OrchidParser.Lt, 0); }
		public TerminalNode Gt() { return getToken(OrchidParser.Gt, 0); }
		public TerminalNode Lte() { return getToken(OrchidParser.Lte, 0); }
		public TerminalNode Gte() { return getToken(OrchidParser.Gte, 0); }
		public ComparisonOperatorsContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_comparisonOperators; }
	}

	public final ComparisonOperatorsContext comparisonOperators() throws RecognitionException {
		ComparisonOperatorsContext _localctx = new ComparisonOperatorsContext(_ctx, getState());
		enterRule(_localctx, 42, RULE_comparisonOperators);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(249);
			_la = _input.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Gt) | (1L << Gte) | (1L << Lt) | (1L << Lte) | (1L << Eq) | (1L << NotEq))) != 0)) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class FunctionContext extends ParserRuleContext {
		public TerminalNode Name() { return getToken(OrchidParser.Name, 0); }
		public TerminalNode OpenRound() { return getToken(OrchidParser.OpenRound, 0); }
		public ExpressionSequenceContext expressionSequence() {
			return getRuleContext(ExpressionSequenceContext.class,0);
		}
		public TerminalNode CloseRound() { return getToken(OrchidParser.CloseRound, 0); }
		public FunctionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_function; }
	}

	public final FunctionContext function() throws RecognitionException {
		FunctionContext _localctx = new FunctionContext(_ctx, getState());
		enterRule(_localctx, 44, RULE_function);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(251);
			match(Name);
			setState(252);
			match(OpenRound);
			setState(253);
			expressionSequence();
			setState(254);
			match(CloseRound);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class IdentifierContext extends ParserRuleContext {
		public TerminalNode Name() { return getToken(OrchidParser.Name, 0); }
		public TerminalNode Variable() { return getToken(OrchidParser.Variable, 0); }
		public IdentifierContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_identifier; }
	}

	public final IdentifierContext identifier() throws RecognitionException {
		IdentifierContext _localctx = new IdentifierContext(_ctx, getState());
		enterRule(_localctx, 46, RULE_identifier);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(256);
			_la = _input.LA(1);
			if ( !(_la==Name || _la==Variable) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ArrayLiteralContext extends ParserRuleContext {
		public TerminalNode OpenSquare() { return getToken(OrchidParser.OpenSquare, 0); }
		public ExpressionSequenceContext expressionSequence() {
			return getRuleContext(ExpressionSequenceContext.class,0);
		}
		public TerminalNode CloseSquare() { return getToken(OrchidParser.CloseSquare, 0); }
		public ArrayLiteralContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_arrayLiteral; }
	}

	public final ArrayLiteralContext arrayLiteral() throws RecognitionException {
		ArrayLiteralContext _localctx = new ArrayLiteralContext(_ctx, getState());
		enterRule(_localctx, 48, RULE_arrayLiteral);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(258);
			match(OpenSquare);
			setState(259);
			expressionSequence();
			setState(260);
			match(CloseSquare);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class LiteralContext extends ParserRuleContext {
		public TerminalNode NumericLiteral() { return getToken(OrchidParser.NumericLiteral, 0); }
		public TerminalNode BooleanLiteral() { return getToken(OrchidParser.BooleanLiteral, 0); }
		public TerminalNode StringLiteral() { return getToken(OrchidParser.StringLiteral, 0); }
		public LiteralContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_literal; }
	}

	public final LiteralContext literal() throws RecognitionException {
		LiteralContext _localctx = new LiteralContext(_ctx, getState());
		enterRule(_localctx, 50, RULE_literal);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(262);
			_la = _input.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << BooleanLiteral) | (1L << StringLiteral) | (1L << NumericLiteral))) != 0)) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class EosContext extends ParserRuleContext {
		public TerminalNode SemiColon() { return getToken(OrchidParser.SemiColon, 0); }
		public TerminalNode EOF() { return getToken(OrchidParser.EOF, 0); }
		public EosContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_eos; }
	}

	public final EosContext eos() throws RecognitionException {
		EosContext _localctx = new EosContext(_ctx, getState());
		enterRule(_localctx, 52, RULE_eos);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(264);
			_la = _input.LA(1);
			if ( !(_la==EOF || _la==SemiColon) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public boolean sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 16:
			return singleExpression_sempred((SingleExpressionContext)_localctx, predIndex);
		}
		return true;
	}
	private boolean singleExpression_sempred(SingleExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0:
			return precpred(_ctx, 16);
		case 1:
			return precpred(_ctx, 14);
		case 2:
			return precpred(_ctx, 13);
		case 3:
			return precpred(_ctx, 12);
		case 4:
			return precpred(_ctx, 11);
		case 5:
			return precpred(_ctx, 10);
		case 6:
			return precpred(_ctx, 9);
		case 7:
			return precpred(_ctx, 5);
		}
		return true;
	}

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3;\u010d\4\2\t\2\4"+
		"\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13\t"+
		"\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22\t\22"+
		"\4\23\t\23\4\24\t\24\4\25\t\25\4\26\t\26\4\27\t\27\4\30\t\30\4\31\t\31"+
		"\4\32\t\32\4\33\t\33\4\34\t\34\3\2\3\2\3\2\3\3\6\3=\n\3\r\3\16\3>\3\4"+
		"\3\4\3\4\3\4\3\4\3\4\3\4\5\4H\n\4\3\5\3\5\3\5\3\5\3\6\3\6\3\6\3\6\3\6"+
		"\3\6\3\6\3\6\3\7\3\7\3\b\3\b\5\bZ\n\b\3\t\3\t\3\t\3\t\3\t\3\t\3\t\3\t"+
		"\3\t\3\n\3\n\3\n\3\n\3\13\3\13\3\13\7\13l\n\13\f\13\16\13o\13\13\3\f\3"+
		"\f\3\f\3\f\3\f\3\f\5\fw\n\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\7\f\u0082"+
		"\n\f\f\f\16\f\u0085\13\f\3\f\3\f\5\f\u0089\n\f\3\f\3\f\5\f\u008d\n\f\3"+
		"\r\3\r\3\r\3\16\3\16\3\16\3\16\3\17\3\17\3\17\3\17\3\17\3\17\3\17\3\17"+
		"\3\17\3\17\3\17\3\17\3\17\3\17\3\17\5\17\u00a5\n\17\3\17\3\17\3\17\3\17"+
		"\3\17\3\17\3\17\3\17\5\17\u00af\n\17\3\20\3\20\3\20\3\20\3\21\3\21\3\21"+
		"\7\21\u00b8\n\21\f\21\16\21\u00bb\13\21\3\22\3\22\3\22\3\22\3\22\3\22"+
		"\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3\22\5\22\u00cd\n\22\3\22"+
		"\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3\22"+
		"\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3\22\3\22"+
		"\3\22\3\22\3\22\7\22\u00ef\n\22\f\22\16\22\u00f2\13\22\3\23\3\23\3\24"+
		"\3\24\3\25\3\25\3\26\3\26\3\27\3\27\3\30\3\30\3\30\3\30\3\30\3\31\3\31"+
		"\3\32\3\32\3\32\3\32\3\33\3\33\3\34\3\34\3\34\2\3\"\35\2\4\6\b\n\f\16"+
		"\20\22\24\26\30\32\34\36 \"$&(*,.\60\62\64\66\2\n\4\2\34\35  \3\2\36\37"+
		"\4\2\13\13++\4\2\f\f,,\4\2#\'))\3\289\3\2\5\7\3\3\33\33\2\u0112\28\3\2"+
		"\2\2\4<\3\2\2\2\6G\3\2\2\2\bI\3\2\2\2\nM\3\2\2\2\fU\3\2\2\2\16Y\3\2\2"+
		"\2\20[\3\2\2\2\22d\3\2\2\2\24h\3\2\2\2\26\u008c\3\2\2\2\30\u008e\3\2\2"+
		"\2\32\u0091\3\2\2\2\34\u00ae\3\2\2\2\36\u00b0\3\2\2\2 \u00b4\3\2\2\2\""+
		"\u00cc\3\2\2\2$\u00f3\3\2\2\2&\u00f5\3\2\2\2(\u00f7\3\2\2\2*\u00f9\3\2"+
		"\2\2,\u00fb\3\2\2\2.\u00fd\3\2\2\2\60\u0102\3\2\2\2\62\u0104\3\2\2\2\64"+
		"\u0108\3\2\2\2\66\u010a\3\2\2\289\5\4\3\29:\7\2\2\3:\3\3\2\2\2;=\5\6\4"+
		"\2<;\3\2\2\2=>\3\2\2\2><\3\2\2\2>?\3\2\2\2?\5\3\2\2\2@H\5\34\17\2AH\5"+
		"\32\16\2BH\5\b\5\2CH\5\26\f\2DH\5\20\t\2EH\5\16\b\2FH\5\30\r\2G@\3\2\2"+
		"\2GA\3\2\2\2GB\3\2\2\2GC\3\2\2\2GD\3\2\2\2GE\3\2\2\2GF\3\2\2\2H\7\3\2"+
		"\2\2IJ\7\23\2\2JK\5\4\3\2KL\7\30\2\2L\t\3\2\2\2MN\7\61\2\2NO\5\24\13\2"+
		"OP\7\62\2\2PQ\7\63\2\2QR\7\23\2\2RS\5\4\3\2ST\7\30\2\2T\13\3\2\2\2UV\5"+
		" \21\2V\r\3\2\2\2WZ\5\22\n\2XZ\5\20\t\2YW\3\2\2\2YX\3\2\2\2Z\17\3\2\2"+
		"\2[\\\7\27\2\2\\]\5\60\31\2]^\7\61\2\2^_\5\24\13\2_`\7\62\2\2`a\7\23\2"+
		"\2ab\5\4\3\2bc\7\30\2\2c\21\3\2\2\2de\5\60\31\2ef\7(\2\2fg\5\"\22\2g\23"+
		"\3\2\2\2hm\78\2\2ij\7.\2\2jl\78\2\2ki\3\2\2\2lo\3\2\2\2mk\3\2\2\2mn\3"+
		"\2\2\2n\25\3\2\2\2om\3\2\2\2pq\7\16\2\2qr\5\"\22\2rs\7\21\2\2sv\5\4\3"+
		"\2tu\7\17\2\2uw\5\4\3\2vt\3\2\2\2vw\3\2\2\2w\u008d\3\2\2\2xy\7\16\2\2"+
		"yz\5\"\22\2z{\7\21\2\2{\u0083\5\4\3\2|}\7\20\2\2}~\5\"\22\2~\177\7\21"+
		"\2\2\177\u0080\5\4\3\2\u0080\u0082\3\2\2\2\u0081|\3\2\2\2\u0082\u0085"+
		"\3\2\2\2\u0083\u0081\3\2\2\2\u0083\u0084\3\2\2\2\u0084\u0088\3\2\2\2\u0085"+
		"\u0083\3\2\2\2\u0086\u0087\7\17\2\2\u0087\u0089\5\4\3\2\u0088\u0086\3"+
		"\2\2\2\u0088\u0089\3\2\2\2\u0089\u008a\3\2\2\2\u008a\u008b\7\30\2\2\u008b"+
		"\u008d\3\2\2\2\u008cp\3\2\2\2\u008cx\3\2\2\2\u008d\27\3\2\2\2\u008e\u008f"+
		"\7\26\2\2\u008f\u0090\5\"\22\2\u0090\31\3\2\2\2\u0091\u0092\5\60\31\2"+
		"\u0092\u0093\7(\2\2\u0093\u0094\5\"\22\2\u0094\33\3\2\2\2\u0095\u0096"+
		"\7\23\2\2\u0096\u0097\5\4\3\2\u0097\u0098\7\24\2\2\u0098\u0099\5\"\22"+
		"\2\u0099\u009a\7\30\2\2\u009a\u00af\3\2\2\2\u009b\u009c\7\24\2\2\u009c"+
		"\u009d\5\"\22\2\u009d\u009e\7\23\2\2\u009e\u009f\5\4\3\2\u009f\u00a0\7"+
		"\30\2\2\u00a0\u00af\3\2\2\2\u00a1\u00a4\7\25\2\2\u00a2\u00a5\5\"\22\2"+
		"\u00a3\u00a5\5\36\20\2\u00a4\u00a2\3\2\2\2\u00a4\u00a3\3\2\2\2\u00a5\u00a6"+
		"\3\2\2\2\u00a6\u00a7\7\33\2\2\u00a7\u00a8\5\"\22\2\u00a8\u00a9\7\33\2"+
		"\2\u00a9\u00aa\5\"\22\2\u00aa\u00ab\7\23\2\2\u00ab\u00ac\5\4\3\2\u00ac"+
		"\u00ad\7\30\2\2\u00ad\u00af\3\2\2\2\u00ae\u0095\3\2\2\2\u00ae\u009b\3"+
		"\2\2\2\u00ae\u00a1\3\2\2\2\u00af\35\3\2\2\2\u00b0\u00b1\5\60\31\2\u00b1"+
		"\u00b2\7(\2\2\u00b2\u00b3\5\"\22\2\u00b3\37\3\2\2\2\u00b4\u00b9\5\"\22"+
		"\2\u00b5\u00b6\7.\2\2\u00b6\u00b8\5\"\22\2\u00b7\u00b5\3\2\2\2\u00b8\u00bb"+
		"\3\2\2\2\u00b9\u00b7\3\2\2\2\u00b9\u00ba\3\2\2\2\u00ba!\3\2\2\2\u00bb"+
		"\u00b9\3\2\2\2\u00bc\u00bd\b\22\1\2\u00bd\u00cd\5.\30\2\u00be\u00cd\5"+
		"\n\6\2\u00bf\u00c0\7*\2\2\u00c0\u00cd\5\"\22\n\u00c1\u00c2\7\37\2\2\u00c2"+
		"\u00cd\5\"\22\t\u00c3\u00c4\7\36\2\2\u00c4\u00cd\5\"\22\b\u00c5\u00cd"+
		"\5\60\31\2\u00c6\u00cd\5\64\33\2\u00c7\u00cd\5\62\32\2\u00c8\u00c9\7\61"+
		"\2\2\u00c9\u00ca\5\"\22\2\u00ca\u00cb\7\62\2\2\u00cb\u00cd\3\2\2\2\u00cc"+
		"\u00bc\3\2\2\2\u00cc\u00be\3\2\2\2\u00cc\u00bf\3\2\2\2\u00cc\u00c1\3\2"+
		"\2\2\u00cc\u00c3\3\2\2\2\u00cc\u00c5\3\2\2\2\u00cc\u00c6\3\2\2\2\u00cc"+
		"\u00c7\3\2\2\2\u00cc\u00c8\3\2\2\2\u00cd\u00f0\3\2\2\2\u00ce\u00cf\f\22"+
		"\2\2\u00cf\u00d0\7\22\2\2\u00d0\u00ef\5\"\22\23\u00d1\u00d2\f\20\2\2\u00d2"+
		"\u00d3\5$\23\2\u00d3\u00d4\5\"\22\21\u00d4\u00ef\3\2\2\2\u00d5\u00d6\f"+
		"\17\2\2\u00d6\u00d7\5&\24\2\u00d7\u00d8\5\"\22\20\u00d8\u00ef\3\2\2\2"+
		"\u00d9\u00da\f\16\2\2\u00da\u00db\5,\27\2\u00db\u00dc\5\"\22\17\u00dc"+
		"\u00ef\3\2\2\2\u00dd\u00de\f\r\2\2\u00de\u00df\5(\25\2\u00df\u00e0\5\""+
		"\22\16\u00e0\u00ef\3\2\2\2\u00e1\u00e2\f\f\2\2\u00e2\u00e3\5*\26\2\u00e3"+
		"\u00e4\5\"\22\r\u00e4\u00ef\3\2\2\2\u00e5\u00e6\f\13\2\2\u00e6\u00e7\7"+
		"\60\2\2\u00e7\u00e8\5\"\22\2\u00e8\u00e9\7-\2\2\u00e9\u00ea\5\"\22\f\u00ea"+
		"\u00ef\3\2\2\2\u00eb\u00ec\f\7\2\2\u00ec\u00ed\7/\2\2\u00ed\u00ef\5\""+
		"\22\7\u00ee\u00ce\3\2\2\2\u00ee\u00d1\3\2\2\2\u00ee\u00d5\3\2\2\2\u00ee"+
		"\u00d9\3\2\2\2\u00ee\u00dd\3\2\2\2\u00ee\u00e1\3\2\2\2\u00ee\u00e5\3\2"+
		"\2\2\u00ee\u00eb\3\2\2\2\u00ef\u00f2\3\2\2\2\u00f0\u00ee\3\2\2\2\u00f0"+
		"\u00f1\3\2\2\2\u00f1#\3\2\2\2\u00f2\u00f0\3\2\2\2\u00f3\u00f4\t\2\2\2"+
		"\u00f4%\3\2\2\2\u00f5\u00f6\t\3\2\2\u00f6\'\3\2\2\2\u00f7\u00f8\t\4\2"+
		"\2\u00f8)\3\2\2\2\u00f9\u00fa\t\5\2\2\u00fa+\3\2\2\2\u00fb\u00fc\t\6\2"+
		"\2\u00fc-\3\2\2\2\u00fd\u00fe\78\2\2\u00fe\u00ff\7\61\2\2\u00ff\u0100"+
		"\5 \21\2\u0100\u0101\7\62\2\2\u0101/\3\2\2\2\u0102\u0103\t\7\2\2\u0103"+
		"\61\3\2\2\2\u0104\u0105\7\64\2\2\u0105\u0106\5 \21\2\u0106\u0107\7\65"+
		"\2\2\u0107\63\3\2\2\2\u0108\u0109\t\b\2\2\u0109\65\3\2\2\2\u010a\u010b"+
		"\t\t\2\2\u010b\67\3\2\2\2\20>GYmv\u0083\u0088\u008c\u00a4\u00ae\u00b9"+
		"\u00cc\u00ee\u00f0";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}