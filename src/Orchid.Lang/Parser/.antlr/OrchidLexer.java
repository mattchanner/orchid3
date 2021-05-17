// Generated from c:\Source\github\Orchid3\src\Orchid.Lang\Parser\OrchidLexer.g4 by ANTLR 4.8
import org.antlr.v4.runtime.Lexer;
import org.antlr.v4.runtime.CharStream;
import org.antlr.v4.runtime.Token;
import org.antlr.v4.runtime.TokenStream;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.misc.*;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class OrchidLexer extends Lexer {
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
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	private static String[] makeRuleNames() {
		return new String[] {
			"MultiLineComment", "SingleLineComment", "BooleanLiteral", "StringLiteral", 
			"NumericLiteral", "Integer", "Float", "Dot", "And", "Or", "Not", "If", 
			"Else", "ElseIf", "Then", "Unless", "Do", "While", "For", "Return", "Function", 
			"End", "Break", "Continue", "SemiColon", "Mul", "Div", "Plus", "Sub", 
			"Mod", "Pow", "Amp", "Gt", "Gte", "Lt", "Lte", "Eq", "Assign", "NotEq", 
			"UnaryNot", "LogicalAnd", "LogicalOr", "Colon", "Comma", "PowerOp", "Question", 
			"OpenRound", "CloseRound", "Arrow", "OpenSquare", "CloseSquare", "OpenCurly", 
			"CloseCurly", "Name", "Variable", "WhiteSpace", "Discardable", "LETTER", 
			"DIGIT", "EXPONENT"
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


	public OrchidLexer(CharStream input) {
		super(input);
		_interp = new LexerATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@Override
	public String getGrammarFileName() { return "OrchidLexer.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public String[] getChannelNames() { return channelNames; }

	@Override
	public String[] getModeNames() { return modeNames; }

	@Override
	public ATN getATN() { return _ATN; }

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\2;\u0193\b\1\4\2\t"+
		"\2\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13"+
		"\t\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22\t\22"+
		"\4\23\t\23\4\24\t\24\4\25\t\25\4\26\t\26\4\27\t\27\4\30\t\30\4\31\t\31"+
		"\4\32\t\32\4\33\t\33\4\34\t\34\4\35\t\35\4\36\t\36\4\37\t\37\4 \t \4!"+
		"\t!\4\"\t\"\4#\t#\4$\t$\4%\t%\4&\t&\4\'\t\'\4(\t(\4)\t)\4*\t*\4+\t+\4"+
		",\t,\4-\t-\4.\t.\4/\t/\4\60\t\60\4\61\t\61\4\62\t\62\4\63\t\63\4\64\t"+
		"\64\4\65\t\65\4\66\t\66\4\67\t\67\48\t8\49\t9\4:\t:\4;\t;\4<\t<\4=\t="+
		"\3\2\3\2\3\2\3\2\7\2\u0080\n\2\f\2\16\2\u0083\13\2\3\2\3\2\3\2\3\2\3\2"+
		"\3\3\3\3\7\3\u008c\n\3\f\3\16\3\u008f\13\3\3\3\3\3\3\4\3\4\3\4\3\4\3\4"+
		"\3\4\3\4\3\4\3\4\5\4\u009c\n\4\3\5\3\5\7\5\u00a0\n\5\f\5\16\5\u00a3\13"+
		"\5\3\5\3\5\3\5\7\5\u00a8\n\5\f\5\16\5\u00ab\13\5\3\5\5\5\u00ae\n\5\3\6"+
		"\3\6\5\6\u00b2\n\6\3\7\6\7\u00b5\n\7\r\7\16\7\u00b6\3\b\6\b\u00ba\n\b"+
		"\r\b\16\b\u00bb\3\b\3\b\7\b\u00c0\n\b\f\b\16\b\u00c3\13\b\3\b\5\b\u00c6"+
		"\n\b\3\b\3\b\6\b\u00ca\n\b\r\b\16\b\u00cb\3\b\5\b\u00cf\n\b\3\b\6\b\u00d2"+
		"\n\b\r\b\16\b\u00d3\3\b\3\b\5\b\u00d8\n\b\3\t\3\t\3\n\3\n\3\n\3\n\3\13"+
		"\3\13\3\13\3\f\3\f\3\f\3\f\3\r\3\r\3\r\3\16\3\16\3\16\3\16\3\16\3\17\3"+
		"\17\3\17\3\17\3\17\3\17\3\17\3\20\3\20\3\20\3\20\3\20\3\21\3\21\3\21\3"+
		"\21\3\21\3\21\3\21\3\22\3\22\3\22\3\23\3\23\3\23\3\23\3\23\3\23\3\24\3"+
		"\24\3\24\3\24\3\25\3\25\3\25\3\25\3\25\3\25\3\25\3\26\3\26\3\26\3\26\3"+
		"\26\3\27\3\27\3\27\3\27\3\30\3\30\3\30\3\30\3\30\3\30\3\31\3\31\3\31\3"+
		"\31\3\31\3\31\3\31\3\31\3\31\3\32\3\32\3\33\3\33\3\34\3\34\3\35\3\35\3"+
		"\36\3\36\3\37\3\37\3 \3 \3!\3!\3\"\3\"\3#\3#\3#\3$\3$\3%\3%\3%\3&\3&\3"+
		"\'\3\'\3\'\3(\3(\3(\3)\3)\3*\3*\3*\3+\3+\3+\3,\3,\3-\3-\3.\3.\3.\3/\3"+
		"/\3\60\3\60\3\61\3\61\3\62\3\62\3\62\3\63\3\63\3\64\3\64\3\65\3\65\3\66"+
		"\3\66\3\67\3\67\3\67\7\67\u0173\n\67\f\67\16\67\u0176\13\67\38\38\38\3"+
		"8\39\69\u017d\n9\r9\169\u017e\39\39\3:\3:\3:\3:\3;\3;\3<\3<\3=\3=\5=\u018d"+
		"\n=\3=\6=\u0190\n=\r=\16=\u0191\5\u0081\u00a1\u00a9\2>\3\3\5\4\7\5\t\6"+
		"\13\7\r\b\17\t\21\n\23\13\25\f\27\r\31\16\33\17\35\20\37\21!\22#\23%\24"+
		"\'\25)\26+\27-\30/\31\61\32\63\33\65\34\67\359\36;\37= ?!A\"C#E$G%I&K"+
		"\'M(O)Q*S+U,W-Y.[/]\60_\61a\62c\63e\64g\65i\66k\67m8o9q:s;u\2w\2y\2\3"+
		"\2\t\5\2\f\f\17\17\u202a\u202b\6\2\f\f\17\17$$^^\5\2\13\f\16\17\"\"\4"+
		"\2C\\c|\3\2\62;\4\2GGgg\4\2--//\2\u01a4\2\3\3\2\2\2\2\5\3\2\2\2\2\7\3"+
		"\2\2\2\2\t\3\2\2\2\2\13\3\2\2\2\2\r\3\2\2\2\2\17\3\2\2\2\2\21\3\2\2\2"+
		"\2\23\3\2\2\2\2\25\3\2\2\2\2\27\3\2\2\2\2\31\3\2\2\2\2\33\3\2\2\2\2\35"+
		"\3\2\2\2\2\37\3\2\2\2\2!\3\2\2\2\2#\3\2\2\2\2%\3\2\2\2\2\'\3\2\2\2\2)"+
		"\3\2\2\2\2+\3\2\2\2\2-\3\2\2\2\2/\3\2\2\2\2\61\3\2\2\2\2\63\3\2\2\2\2"+
		"\65\3\2\2\2\2\67\3\2\2\2\29\3\2\2\2\2;\3\2\2\2\2=\3\2\2\2\2?\3\2\2\2\2"+
		"A\3\2\2\2\2C\3\2\2\2\2E\3\2\2\2\2G\3\2\2\2\2I\3\2\2\2\2K\3\2\2\2\2M\3"+
		"\2\2\2\2O\3\2\2\2\2Q\3\2\2\2\2S\3\2\2\2\2U\3\2\2\2\2W\3\2\2\2\2Y\3\2\2"+
		"\2\2[\3\2\2\2\2]\3\2\2\2\2_\3\2\2\2\2a\3\2\2\2\2c\3\2\2\2\2e\3\2\2\2\2"+
		"g\3\2\2\2\2i\3\2\2\2\2k\3\2\2\2\2m\3\2\2\2\2o\3\2\2\2\2q\3\2\2\2\2s\3"+
		"\2\2\2\3{\3\2\2\2\5\u0089\3\2\2\2\7\u009b\3\2\2\2\t\u00ad\3\2\2\2\13\u00b1"+
		"\3\2\2\2\r\u00b4\3\2\2\2\17\u00d7\3\2\2\2\21\u00d9\3\2\2\2\23\u00db\3"+
		"\2\2\2\25\u00df\3\2\2\2\27\u00e2\3\2\2\2\31\u00e6\3\2\2\2\33\u00e9\3\2"+
		"\2\2\35\u00ee\3\2\2\2\37\u00f5\3\2\2\2!\u00fa\3\2\2\2#\u0101\3\2\2\2%"+
		"\u0104\3\2\2\2\'\u010a\3\2\2\2)\u010e\3\2\2\2+\u0115\3\2\2\2-\u011a\3"+
		"\2\2\2/\u011e\3\2\2\2\61\u0124\3\2\2\2\63\u012d\3\2\2\2\65\u012f\3\2\2"+
		"\2\67\u0131\3\2\2\29\u0133\3\2\2\2;\u0135\3\2\2\2=\u0137\3\2\2\2?\u0139"+
		"\3\2\2\2A\u013b\3\2\2\2C\u013d\3\2\2\2E\u013f\3\2\2\2G\u0142\3\2\2\2I"+
		"\u0144\3\2\2\2K\u0147\3\2\2\2M\u0149\3\2\2\2O\u014c\3\2\2\2Q\u014f\3\2"+
		"\2\2S\u0151\3\2\2\2U\u0154\3\2\2\2W\u0157\3\2\2\2Y\u0159\3\2\2\2[\u015b"+
		"\3\2\2\2]\u015e\3\2\2\2_\u0160\3\2\2\2a\u0162\3\2\2\2c\u0164\3\2\2\2e"+
		"\u0167\3\2\2\2g\u0169\3\2\2\2i\u016b\3\2\2\2k\u016d\3\2\2\2m\u016f\3\2"+
		"\2\2o\u0177\3\2\2\2q\u017c\3\2\2\2s\u0182\3\2\2\2u\u0186\3\2\2\2w\u0188"+
		"\3\2\2\2y\u018a\3\2\2\2{|\7\61\2\2|}\7,\2\2}\u0081\3\2\2\2~\u0080\13\2"+
		"\2\2\177~\3\2\2\2\u0080\u0083\3\2\2\2\u0081\u0082\3\2\2\2\u0081\177\3"+
		"\2\2\2\u0082\u0084\3\2\2\2\u0083\u0081\3\2\2\2\u0084\u0085\7,\2\2\u0085"+
		"\u0086\7\61\2\2\u0086\u0087\3\2\2\2\u0087\u0088\b\2\2\2\u0088\4\3\2\2"+
		"\2\u0089\u008d\7%\2\2\u008a\u008c\n\2\2\2\u008b\u008a\3\2\2\2\u008c\u008f"+
		"\3\2\2\2\u008d\u008b\3\2\2\2\u008d\u008e\3\2\2\2\u008e\u0090\3\2\2\2\u008f"+
		"\u008d\3\2\2\2\u0090\u0091\b\3\2\2\u0091\6\3\2\2\2\u0092\u0093\7v\2\2"+
		"\u0093\u0094\7t\2\2\u0094\u0095\7w\2\2\u0095\u009c\7g\2\2\u0096\u0097"+
		"\7h\2\2\u0097\u0098\7c\2\2\u0098\u0099\7n\2\2\u0099\u009a\7u\2\2\u009a"+
		"\u009c\7g\2\2\u009b\u0092\3\2\2\2\u009b\u0096\3\2\2\2\u009c\b\3\2\2\2"+
		"\u009d\u00a1\7$\2\2\u009e\u00a0\n\3\2\2\u009f\u009e\3\2\2\2\u00a0\u00a3"+
		"\3\2\2\2\u00a1\u00a2\3\2\2\2\u00a1\u009f\3\2\2\2\u00a2\u00a4\3\2\2\2\u00a3"+
		"\u00a1\3\2\2\2\u00a4\u00ae\7$\2\2\u00a5\u00a9\7)\2\2\u00a6\u00a8\n\3\2"+
		"\2\u00a7\u00a6\3\2\2\2\u00a8\u00ab\3\2\2\2\u00a9\u00aa\3\2\2\2\u00a9\u00a7"+
		"\3\2\2\2\u00aa\u00ac\3\2\2\2\u00ab\u00a9\3\2\2\2\u00ac\u00ae\7)\2\2\u00ad"+
		"\u009d\3\2\2\2\u00ad\u00a5\3\2\2\2\u00ae\n\3\2\2\2\u00af\u00b2\5\r\7\2"+
		"\u00b0\u00b2\5\17\b\2\u00b1\u00af\3\2\2\2\u00b1\u00b0\3\2\2\2\u00b2\f"+
		"\3\2\2\2\u00b3\u00b5\5w<\2\u00b4\u00b3\3\2\2\2\u00b5\u00b6\3\2\2\2\u00b6"+
		"\u00b4\3\2\2\2\u00b6\u00b7\3\2\2\2\u00b7\16\3\2\2\2\u00b8\u00ba\5w<\2"+
		"\u00b9\u00b8\3\2\2\2\u00ba\u00bb\3\2\2\2\u00bb\u00b9\3\2\2\2\u00bb\u00bc"+
		"\3\2\2\2\u00bc\u00bd\3\2\2\2\u00bd\u00c1\7\60\2\2\u00be\u00c0\5w<\2\u00bf"+
		"\u00be\3\2\2\2\u00c0\u00c3\3\2\2\2\u00c1\u00bf\3\2\2\2\u00c1\u00c2\3\2"+
		"\2\2\u00c2\u00c5\3\2\2\2\u00c3\u00c1\3\2\2\2\u00c4\u00c6\5y=\2\u00c5\u00c4"+
		"\3\2\2\2\u00c5\u00c6\3\2\2\2\u00c6\u00d8\3\2\2\2\u00c7\u00c9\7\60\2\2"+
		"\u00c8\u00ca\5w<\2\u00c9\u00c8\3\2\2\2\u00ca\u00cb\3\2\2\2\u00cb\u00c9"+
		"\3\2\2\2\u00cb\u00cc\3\2\2\2\u00cc\u00ce\3\2\2\2\u00cd\u00cf\5y=\2\u00ce"+
		"\u00cd\3\2\2\2\u00ce\u00cf\3\2\2\2\u00cf\u00d8\3\2\2\2\u00d0\u00d2\5w"+
		"<\2\u00d1\u00d0\3\2\2\2\u00d2\u00d3\3\2\2\2\u00d3\u00d1\3\2\2\2\u00d3"+
		"\u00d4\3\2\2\2\u00d4\u00d5\3\2\2\2\u00d5\u00d6\5y=\2\u00d6\u00d8\3\2\2"+
		"\2\u00d7\u00b9\3\2\2\2\u00d7\u00c7\3\2\2\2\u00d7\u00d1\3\2\2\2\u00d8\20"+
		"\3\2\2\2\u00d9\u00da\7\60\2\2\u00da\22\3\2\2\2\u00db\u00dc\7c\2\2\u00dc"+
		"\u00dd\7p\2\2\u00dd\u00de\7f\2\2\u00de\24\3\2\2\2\u00df\u00e0\7q\2\2\u00e0"+
		"\u00e1\7t\2\2\u00e1\26\3\2\2\2\u00e2\u00e3\7p\2\2\u00e3\u00e4\7q\2\2\u00e4"+
		"\u00e5\7v\2\2\u00e5\30\3\2\2\2\u00e6\u00e7\7k\2\2\u00e7\u00e8\7h\2\2\u00e8"+
		"\32\3\2\2\2\u00e9\u00ea\7g\2\2\u00ea\u00eb\7n\2\2\u00eb\u00ec\7u\2\2\u00ec"+
		"\u00ed\7g\2\2\u00ed\34\3\2\2\2\u00ee\u00ef\7g\2\2\u00ef\u00f0\7n\2\2\u00f0"+
		"\u00f1\7u\2\2\u00f1\u00f2\7g\2\2\u00f2\u00f3\7k\2\2\u00f3\u00f4\7h\2\2"+
		"\u00f4\36\3\2\2\2\u00f5\u00f6\7v\2\2\u00f6\u00f7\7j\2\2\u00f7\u00f8\7"+
		"g\2\2\u00f8\u00f9\7p\2\2\u00f9 \3\2\2\2\u00fa\u00fb\7w\2\2\u00fb\u00fc"+
		"\7p\2\2\u00fc\u00fd\7n\2\2\u00fd\u00fe\7g\2\2\u00fe\u00ff\7u\2\2\u00ff"+
		"\u0100\7u\2\2\u0100\"\3\2\2\2\u0101\u0102\7f\2\2\u0102\u0103\7q\2\2\u0103"+
		"$\3\2\2\2\u0104\u0105\7y\2\2\u0105\u0106\7j\2\2\u0106\u0107\7k\2\2\u0107"+
		"\u0108\7n\2\2\u0108\u0109\7g\2\2\u0109&\3\2\2\2\u010a\u010b\7h\2\2\u010b"+
		"\u010c\7q\2\2\u010c\u010d\7t\2\2\u010d(\3\2\2\2\u010e\u010f\7t\2\2\u010f"+
		"\u0110\7g\2\2\u0110\u0111\7v\2\2\u0111\u0112\7w\2\2\u0112\u0113\7t\2\2"+
		"\u0113\u0114\7p\2\2\u0114*\3\2\2\2\u0115\u0116\7h\2\2\u0116\u0117\7w\2"+
		"\2\u0117\u0118\7p\2\2\u0118\u0119\7e\2\2\u0119,\3\2\2\2\u011a\u011b\7"+
		"g\2\2\u011b\u011c\7p\2\2\u011c\u011d\7f\2\2\u011d.\3\2\2\2\u011e\u011f"+
		"\7d\2\2\u011f\u0120\7t\2\2\u0120\u0121\7g\2\2\u0121\u0122\7c\2\2\u0122"+
		"\u0123\7m\2\2\u0123\60\3\2\2\2\u0124\u0125\7e\2\2\u0125\u0126\7q\2\2\u0126"+
		"\u0127\7p\2\2\u0127\u0128\7v\2\2\u0128\u0129\7k\2\2\u0129\u012a\7p\2\2"+
		"\u012a\u012b\7w\2\2\u012b\u012c\7g\2\2\u012c\62\3\2\2\2\u012d\u012e\7"+
		"=\2\2\u012e\64\3\2\2\2\u012f\u0130\7,\2\2\u0130\66\3\2\2\2\u0131\u0132"+
		"\7\61\2\2\u01328\3\2\2\2\u0133\u0134\7-\2\2\u0134:\3\2\2\2\u0135\u0136"+
		"\7/\2\2\u0136<\3\2\2\2\u0137\u0138\7\'\2\2\u0138>\3\2\2\2\u0139\u013a"+
		"\7`\2\2\u013a@\3\2\2\2\u013b\u013c\7(\2\2\u013cB\3\2\2\2\u013d\u013e\7"+
		"@\2\2\u013eD\3\2\2\2\u013f\u0140\7@\2\2\u0140\u0141\7?\2\2\u0141F\3\2"+
		"\2\2\u0142\u0143\7>\2\2\u0143H\3\2\2\2\u0144\u0145\7>\2\2\u0145\u0146"+
		"\7?\2\2\u0146J\3\2\2\2\u0147\u0148\7?\2\2\u0148L\3\2\2\2\u0149\u014a\7"+
		"<\2\2\u014a\u014b\7?\2\2\u014bN\3\2\2\2\u014c\u014d\7#\2\2\u014d\u014e"+
		"\7?\2\2\u014eP\3\2\2\2\u014f\u0150\7#\2\2\u0150R\3\2\2\2\u0151\u0152\7"+
		"(\2\2\u0152\u0153\7(\2\2\u0153T\3\2\2\2\u0154\u0155\7~\2\2\u0155\u0156"+
		"\7~\2\2\u0156V\3\2\2\2\u0157\u0158\7<\2\2\u0158X\3\2\2\2\u0159\u015a\7"+
		".\2\2\u015aZ\3\2\2\2\u015b\u015c\7,\2\2\u015c\u015d\7,\2\2\u015d\\\3\2"+
		"\2\2\u015e\u015f\7A\2\2\u015f^\3\2\2\2\u0160\u0161\7*\2\2\u0161`\3\2\2"+
		"\2\u0162\u0163\7+\2\2\u0163b\3\2\2\2\u0164\u0165\7?\2\2\u0165\u0166\7"+
		"@\2\2\u0166d\3\2\2\2\u0167\u0168\7]\2\2\u0168f\3\2\2\2\u0169\u016a\7_"+
		"\2\2\u016ah\3\2\2\2\u016b\u016c\7}\2\2\u016cj\3\2\2\2\u016d\u016e\7\177"+
		"\2\2\u016el\3\2\2\2\u016f\u0174\5u;\2\u0170\u0173\5u;\2\u0171\u0173\5"+
		"w<\2\u0172\u0170\3\2\2\2\u0172\u0171\3\2\2\2\u0173\u0176\3\2\2\2\u0174"+
		"\u0172\3\2\2\2\u0174\u0175\3\2\2\2\u0175n\3\2\2\2\u0176\u0174\3\2\2\2"+
		"\u0177\u0178\5e\63\2\u0178\u0179\5m\67\2\u0179\u017a\5g\64\2\u017ap\3"+
		"\2\2\2\u017b\u017d\t\4\2\2\u017c\u017b\3\2\2\2\u017d\u017e\3\2\2\2\u017e"+
		"\u017c\3\2\2\2\u017e\u017f\3\2\2\2\u017f\u0180\3\2\2\2\u0180\u0181\b9"+
		"\2\2\u0181r\3\2\2\2\u0182\u0183\13\2\2\2\u0183\u0184\3\2\2\2\u0184\u0185"+
		"\b:\2\2\u0185t\3\2\2\2\u0186\u0187\t\5\2\2\u0187v\3\2\2\2\u0188\u0189"+
		"\t\6\2\2\u0189x\3\2\2\2\u018a\u018c\t\7\2\2\u018b\u018d\t\b\2\2\u018c"+
		"\u018b\3\2\2\2\u018c\u018d\3\2\2\2\u018d\u018f\3\2\2\2\u018e\u0190\4\62"+
		";\2\u018f\u018e\3\2\2\2\u0190\u0191\3\2\2\2\u0191\u018f\3\2\2\2\u0191"+
		"\u0192\3\2\2\2\u0192z\3\2\2\2\27\2\u0081\u008d\u009b\u00a1\u00a9\u00ad"+
		"\u00b1\u00b6\u00bb\u00c1\u00c5\u00cb\u00ce\u00d3\u00d7\u0172\u0174\u017e"+
		"\u018c\u0191\3\2\3\2";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}