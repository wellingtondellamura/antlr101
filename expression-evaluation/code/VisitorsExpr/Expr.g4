grammar Expr;

expr : term '+' expr      #exprAdd       
     | term               #exprTerm
     ;
term : fact '*' term     #termMult   
     | fact              #termFact
     ;
fact : '('expr')'        #factExpr
     | DIGIT             #factDigit
     ;

DIGIT : [0-9]+;
SUM   : '+';
WS : [ \t]+ -> skip ;


// 2+3*(44+55)