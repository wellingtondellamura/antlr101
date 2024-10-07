using System;
using VisitorsExpr.Grammar;
using Antlr4.Runtime;

namespace VisitorsExpr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String question = "";
            do {  //REPL READ EVAL PRINT LOOP
                Console.Write(">>> ");
                question = Console.ReadLine();
                
                var stream = CharStreams.fromString(question);
                var lexer = new ExprLexer(stream);
                var tokenStream = new BufferedTokenStream(lexer);
                var parser = new ExprParser(tokenStream);     

                var derivationTree = parser.expr();
            
                var visitor = new EvalVisitor();
                Console.WriteLine(visitor.Visit(derivationTree));
            } while (question != "");
        }
    }
}