

namespace ListenersExpr
{
    
    using Antlr4.Runtime.Misc;
    using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
    using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
    using IToken = Antlr4.Runtime.IToken;
    using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;
    using ListenersExpr.Grammar;

    public class EvalListener : ExprBaseListener {
        public override void EnterExprAdd([NotNull] ExprParser.ExprAddContext context) {
            var left = int.Parse(context.expr(0).value);
            var right = int.Parse(context.expr(1).value);
            context.value = (left + right).ToString();
        }

        public override void EnterExprTerm([NotNull] ExprParser.ExprTermContext context) {
            context.value = context.expr().value;
        }

        public override void EnterTermMult([NotNull] ExprParser.TermMultContext context) {
            var left = int.Parse(context.term().value);
            var right = int.Parse(context.expr().value);
            context.value = (left * right).ToString();
        }

        public override void EnterTermFact([NotNull] ExprParser.TermFactContext context) {
            context.value = context.DIGIT().GetText();
        }

        public EnterFactExpr([NotNull] ExprParser.FactExprContext context) {
            context.value = context.expr().value;
        }
    }

}