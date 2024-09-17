grammar Expr;

expr returns [int value] 
     : term '+' expr        {$value = $term.value + $expr.value;}
     | term                 {$value = $term.value;}
     ;
term returns [int value] 
     : fact '*' term        {$value = $fact.value * $term.value;}
     | fact                 {$value = $fact.value;}
     ;
fact returns [int value] 
     : '('expr')'           {$value = $expr.value;}
     | DIGIT                {$value = Int32.Parse($DIGIT.text);}
     ;

DIGIT : [0-9]+;
WS : [ \t]+ -> skip ;


// 2+3*(44+55)