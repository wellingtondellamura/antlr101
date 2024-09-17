grammar Expr;

expr returns [int value] 
     : term '+' expr      #exprAdd       
     | term               #exprTerm
     ;
term returns [int value] 
     : fact '*' term     #termMult   
     | fact              #termFact
     ;
fact returns [int value] 
     : '('expr')'        #factExpr
     | DIGIT             #factDigit
     ;

DIGIT : [0-9]+;
WS : [ \t]+ -> skip ;


// 2+3*(44+55)