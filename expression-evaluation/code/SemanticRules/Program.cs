﻿using System;
using SemanticRules.Grammar;
using Antlr4.Runtime;

namespace SemanticRules
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
                var res = parser.expr();
                Console.WriteLine(res.value);
            } while (question != "");
        }
    }
}