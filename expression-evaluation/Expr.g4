grammar Expr;

prog : (expr NEWLINE)*;
expr : expr '+' term | term;
term : term '*' fact | fact;
fact : '('expr')' | DIGIT;

NEWLINE : [\r\n]+;
DIGIT : [0-9]+ ;
WS : [ \t]+ -> skip ;
