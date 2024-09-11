using System;
using SemanticRules.Grammar;
using Antlr4.Runtime;

namespace SemanticRules
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stream = CharStreams.fromString("1 + 2 * 3\n");
            var lexer = new ExprLexer(stream);
            var tokenStream = new BufferedTokenStream(lexer);
            var parser = new ExprParser(tokenStream);    

            var res = parser.prog();
            Console.WriteLine(res.ToStringTree(parser));
        }
    }
}