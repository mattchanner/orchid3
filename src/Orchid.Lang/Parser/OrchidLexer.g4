lexer grammar OrchidLexer;

MultiLineComment:               '/*' .*? '*/'             -> channel(HIDDEN);
SingleLineComment:              '#' ~[\r\n\u2028\u2029]* -> channel(HIDDEN);

BooleanLiteral
    : 'true'
    | 'false'
    ;

StringLiteral
    : '"' ~["\\\r\n]*? '"' 
    | '\'' ~["\\\r\n]*? '\''
    ;


NumericLiteral
    : Integer
    | Float
    ;

Integer
    : DIGIT+ 
    ;

Float               
    : DIGIT+ '.' DIGIT* EXPONENT?
    | '.' DIGIT+ EXPONENT?
    | DIGIT+ EXPONENT
    ;

Dot                 : '.';

And                 : 'and' ;
Or                  : 'or' ;
Not                 : 'not' ;

If                  : 'if';
Else                : 'else';
ElseIf              : 'elseif';
Then                : 'then';
Unless              : 'unless';

Do                  : 'do';
While               : 'while';
Loop                : 'loop';
For                 : 'for';
Return              : 'return';
Function            : 'func';
End                 : 'end';
Break               : 'break';
Next                : 'next';
Continue            : 'continue';
Print               : 'print';
Val                 : 'val';

PlusPlus            : '++';
MinusMinus          : '--';
MulEq               : '*=';
PlusEq              : '+=';
MinusEq             : '-=';
DivEq               : '/=';

SemiColon           : ';';
Mul                 : '*' ;
Div                 : '/' ;
Plus                : '+' ;
Sub                 : '-' ;
Mod                 : '%' ;
Pow                 : '^' ;
Amp                 : '&' ;

Gt                  : '>' ;
Gte                 : '>=' ;
Lt                  : '<' ;
Lte                 : '<=' ;
Eq                  : '=' ;
Assign              : ':=';
NotEq               : '!=' ;
UnaryNot            : '!';
LogicalAnd          : '&&';
LogicalOr           : '||';
Colon               : ':' ;
Comma               : ',' ;
PowerOp             : '**';
Question            : '?';
OpenRound           : '(' ;
CloseRound          : ')' ;
Arrow               : '->';
OpenSquare          : '[' ;
CloseSquare         : ']' ;

OpenCurly           : '{' ;
CloseCurly          : '}' ;

Name                : (LETTER|UNDERSCORE) (LETTER|DIGIT|UNDERSCORE)* ;
Variable            : OpenSquare Name CloseSquare ;

WhiteSpace          : [ \t\f\r\n]+ -> channel(HIDDEN); // skip whitespaces
Discardable         : . -> channel(HIDDEN); // keeping whitespace tokenised makes it easier for syntax highlighting

fragment LETTER     : [a-zA-Z] ;
fragment DIGIT      : [0-9] ;
fragment UNDERSCORE : '_' ;
fragment EXPONENT   : ('e'|'E') ('+'|'-')? ('0'..'9')+ ;

