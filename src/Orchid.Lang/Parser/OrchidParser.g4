parser grammar OrchidParser;

options {
    tokenVocab = OrchidLexer;
}

program 
    : statementList EOF
    ;

statementList
    : statement+
    ;

statement 
    : iterationStatement
    | declarationStatement
    | assignmentStatement
    | block    
    | ifStatement
    | functionDeclaration
    | functionCall
    | returnStatement
    | printStatement
    | prefixStatement
    | postfixStatement
    | assignmentOperatorStatement
    ;

block
    : Do statementList End
    ;

arrowFunctions
    : '{' formalParameterList '->' (statementList|singleExpression) '}'
    ;

expressionStatement
    : expressionSequence
    ;

assignmentOperatorStatement
    : identifier assignmentOperators singleExpression
    ;

functionDeclaration
    : Function identifier '(' formalParameterList ')' body=statementList End
    | Function identifier body=statementList End
    | Function identifier '(' formalParameterList ')' '->' expr=singleExpression
    | Function identifier '->' expr=singleExpression
    ;

formalParameterList
    : Name? (',' Name)*
    ;

ifStatement
    : If singleExpression Then statementList (Else statementList)? 
    | If singleExpression Then statementList (ElseIf singleExpression Then statementList)* (Else statementList)? End
    ;

returnStatement
    : Return singleExpression
    ;

printStatement
    : Print '(' singleExpression ')'
    ;

assignmentStatement
    : <assoc=right> identifier ':=' singleExpression
    ;

declarationStatement
    : <assoc=right> Val identifier ':=' singleExpression
    ;

iterationStatement
    : Do statementList While singleExpression            #DoStatement
    | While singleExpression Do statementList Loop       #WhileStatement
    | For (singleExpression|variableDeclarationList|declarationStatement) ';' singleExpression ';' (singleExpression|statement) ';' statementList Next #ForStatement
    ;

variableDeclarationList
    : identifier ':=' singleExpression
    ;

expressionSequence
    : singleExpression (',' singleExpression)*
    ;

prefixStatement
    : prefixPostfixOps identifier
    ;

postfixStatement
    : identifier prefixPostfixOps
    ;

singleExpression
    : <assoc=right> left=singleExpression '**' right=singleExpression       #PowerExpression
    | left=singleExpression op=multiplicativeOperators right=singleExpression  #MultiplicativeExpression
    | left=singleExpression op=additiveOperators right=singleExpression     #AdditiveExpression
    | left=singleExpression op=comparisonOperators right=singleExpression   #RelationalExpression
    | left=singleExpression op=logicalAndOperators right=singleExpression   #LogicalAndExpression
    | left=singleExpression op=logicalOrOperators right=singleExpression    #LogicalOrExpression
    | cond=singleExpression '?' then=singleExpression ':' else=singleExpression    #TernaryExpression
    | '!' right=singleExpression                                                  #NotExpression
    | '-' right=singleExpression                                                  #UnaryMinusExpression
    | '+' right=singleExpression                                                  #UnaryPlusExpression
    | result=singleExpression Unless unless=singleExpression Else else=singleExpression   #UnlessExpression
    | result=singleExpression If if=singleExpression Else else=singleExpression           #IfExpression
    | arrowFunctions                                                        #ArrowFunctionExpression
    | id=identifier op=assignmentOperators expr=singleExpression            #AssignmentOperatorExpression
    | functionCall                                                          #FunctionCallExpression
    | identifier                                                            #IdentifierExpression
    | literal                                                               #LiteralExpression
    | arrayLiteral                                                          #ArrayLiteralExpression
    | op=prefixPostfixOps identifier                                           #PrefixExpression
    | identifier op=prefixPostfixOps                                           #PostfixExpression
    | '(' singleExpression ')'                                              #ParenthesizedExpression
    ;

multiplicativeOperators
    :  '*' | '/' | '%'
    ;

additiveOperators
    : '+' | '-'
    ;

prefixPostfixOps
    : '++' | '--'
    ;

logicalAndOperators
    : '&&' | 'and'
    ;

logicalOrOperators
    : '||' | 'or'
    ;

comparisonOperators
    : '!='|'='|'<' | '>' | '<=' | '>='
    ;

assignmentOperators
    : MinusEq | PlusEq | MulEq | DivEq
    ;

functionCall
    : Name '(' ')'
    | Name '(' expressionSequence ')'
    ;

identifier
    : Name
    | Variable
    ;

arrayLiteral
    : '[' expressionSequence ']'
    ;

literal
    : NumericLiteral
    | BooleanLiteral
    | StringLiteral
    ;

eos
    : SemiColon
    | EOF
    ;

