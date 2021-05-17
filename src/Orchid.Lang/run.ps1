push-location Parser
antlr4 OrchidLexer.g4 -Dlanguage=CSharp -listener -visitor -package Orchid.Parser
antlr4 OrchidParser.g4 -Dlanguage=CSharp -listener -visitor -package Orchid.Parser

if (Test-Path -Path j -eq $false) {
    mkdir j
}

cp OrchidParser.g4 j/OrchidParser.g4
cp OrchidLexer.g4 j/OrchidLexer.g4
push-location j
antlr4 OrchidLexer.g4 -listener -visitor
antlr4 OrchidParser.g4 -listener -visitor
javac Orchid*.java
grun Orchid program ..\expr.orchid -gui
pop-location
pop-location
#dotnet run