

namespace ListenersExpr
{
    
    using Antlr4.Runtime.Misc;
    using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
    using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
    using IToken = Antlr4.Runtime.IToken;
    using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;
    using ListenersExpr.Grammar;

    public class EvalListener : ExprBaseListener {

        
        public override void ExitExprTerm([NotNull] ExprParser.ExprTermContext context) {
            context.value = context.term().value;
        }

        public override void ExitExprAdd([NotNull] ExprParser.ExprAddContext context) {
            context.value = context.term().value + context.expr().value;
        }

        public override void ExitTermMult([NotNull] ExprParser.TermMultContext context) {
            context.value = context.fact().value * context.term().value;
        }

        public override void ExitTermFact([NotNull] ExprParser.TermFactContext context) {
            context.value = context.fact().value;
        }

        public override void ExitFactExpr([NotNull] ExprParser.FactExprContext context) {
            context.value = context.expr().value;
        }

        public override void ExitFactDigit([NotNull] ExprParser.FactDigitContext context) {
            context.value = int.Parse(context.DIGIT().GetText());
        }

    }

}