namespace VisitorsExpr
{
    using System;
    using VisitorsExpr.Grammar;
    using Antlr4.Runtime;
    using Antlr4.Runtime.Tree;

    public class EvalVisitor : ExprBaseVisitor<int>
    {
        public override int VisitExprAdd(ExprParser.ExprAddContext context)
        {
            int left = Visit(context.expr());
            int right = Visit(context.term());
            return left + right;
        }

        public override int VisitExprTerm(ExprParser.ExprTermContext context)
        {
            return Visit(context.term());
        }

        public override int VisitTermMult(ExprParser.TermMultContext context)
        {
            int left = Visit(context.term());
            int right = Visit(context.fact());
            return left * right;
        }

        public override int VisitTermFact(ExprParser.TermFactContext context)
        {
            return Visit(context.fact());
        }

        public override int VisitFactExpr(ExprParser.FactExprContext context)
        {
            return Visit(context.expr());
        }

        public override int VisitFactDigit(ExprParser.FactDigitContext context)
        {
            return int.Parse(context.DIGIT().GetText());
        }
    }
}