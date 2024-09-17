//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Expr.g4 by ANTLR 4.13.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace ListenersExpr.Grammar {
using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.2")]
[System.CLSCompliant(false)]
public partial class ExprParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, DIGIT=5, WS=6;
	public const int
		RULE_expr = 0, RULE_term = 1, RULE_fact = 2;
	public static readonly string[] ruleNames = {
		"expr", "term", "fact"
	};

	private static readonly string[] _LiteralNames = {
		null, "'+'", "'*'", "'('", "')'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, "DIGIT", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Expr.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static ExprParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public ExprParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public ExprParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class ExprContext : ParserRuleContext {
		public int value;
		public ExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expr; } }
	 
		public ExprContext() { }
		public virtual void CopyFrom(ExprContext context) {
			base.CopyFrom(context);
			this.value = context.value;
		}
	}
	public partial class ExprAddContext : ExprContext {
		[System.Diagnostics.DebuggerNonUserCode] public TermContext term() {
			return GetRuleContext<TermContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public ExprAddContext(ExprContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IExprListener typedListener = listener as IExprListener;
			if (typedListener != null) typedListener.EnterExprAdd(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IExprListener typedListener = listener as IExprListener;
			if (typedListener != null) typedListener.ExitExprAdd(this);
		}
	}
	public partial class ExprTermContext : ExprContext {
		[System.Diagnostics.DebuggerNonUserCode] public TermContext term() {
			return GetRuleContext<TermContext>(0);
		}
		public ExprTermContext(ExprContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IExprListener typedListener = listener as IExprListener;
			if (typedListener != null) typedListener.EnterExprTerm(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IExprListener typedListener = listener as IExprListener;
			if (typedListener != null) typedListener.ExitExprTerm(this);
		}
	}

	[RuleVersion(0)]
	public ExprContext expr() {
		ExprContext _localctx = new ExprContext(Context, State);
		EnterRule(_localctx, 0, RULE_expr);
		try {
			State = 11;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,0,Context) ) {
			case 1:
				_localctx = new ExprAddContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 6;
				term();
				State = 7;
				Match(T__0);
				State = 8;
				expr();
				}
				break;
			case 2:
				_localctx = new ExprTermContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 10;
				term();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TermContext : ParserRuleContext {
		public int value;
		public TermContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_term; } }
	 
		public TermContext() { }
		public virtual void CopyFrom(TermContext context) {
			base.CopyFrom(context);
			this.value = context.value;
		}
	}
	public partial class TermMultContext : TermContext {
		[System.Diagnostics.DebuggerNonUserCode] public FactContext fact() {
			return GetRuleContext<FactContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TermContext term() {
			return GetRuleContext<TermContext>(0);
		}
		public TermMultContext(TermContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IExprListener typedListener = listener as IExprListener;
			if (typedListener != null) typedListener.EnterTermMult(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IExprListener typedListener = listener as IExprListener;
			if (typedListener != null) typedListener.ExitTermMult(this);
		}
	}
	public partial class TermFactContext : TermContext {
		[System.Diagnostics.DebuggerNonUserCode] public FactContext fact() {
			return GetRuleContext<FactContext>(0);
		}
		public TermFactContext(TermContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IExprListener typedListener = listener as IExprListener;
			if (typedListener != null) typedListener.EnterTermFact(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IExprListener typedListener = listener as IExprListener;
			if (typedListener != null) typedListener.ExitTermFact(this);
		}
	}

	[RuleVersion(0)]
	public TermContext term() {
		TermContext _localctx = new TermContext(Context, State);
		EnterRule(_localctx, 2, RULE_term);
		try {
			State = 18;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,1,Context) ) {
			case 1:
				_localctx = new TermMultContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 13;
				fact();
				State = 14;
				Match(T__1);
				State = 15;
				term();
				}
				break;
			case 2:
				_localctx = new TermFactContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 17;
				fact();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FactContext : ParserRuleContext {
		public int value;
		public FactContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_fact; } }
	 
		public FactContext() { }
		public virtual void CopyFrom(FactContext context) {
			base.CopyFrom(context);
			this.value = context.value;
		}
	}
	public partial class FactDigitContext : FactContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DIGIT() { return GetToken(ExprParser.DIGIT, 0); }
		public FactDigitContext(FactContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IExprListener typedListener = listener as IExprListener;
			if (typedListener != null) typedListener.EnterFactDigit(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IExprListener typedListener = listener as IExprListener;
			if (typedListener != null) typedListener.ExitFactDigit(this);
		}
	}
	public partial class FactExprContext : FactContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public FactExprContext(FactContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IExprListener typedListener = listener as IExprListener;
			if (typedListener != null) typedListener.EnterFactExpr(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IExprListener typedListener = listener as IExprListener;
			if (typedListener != null) typedListener.ExitFactExpr(this);
		}
	}

	[RuleVersion(0)]
	public FactContext fact() {
		FactContext _localctx = new FactContext(Context, State);
		EnterRule(_localctx, 4, RULE_fact);
		try {
			State = 25;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__2:
				_localctx = new FactExprContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 20;
				Match(T__2);
				State = 21;
				expr();
				State = 22;
				Match(T__3);
				}
				break;
			case DIGIT:
				_localctx = new FactDigitContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 24;
				Match(DIGIT);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static int[] _serializedATN = {
		4,1,6,28,2,0,7,0,2,1,7,1,2,2,7,2,1,0,1,0,1,0,1,0,1,0,3,0,12,8,0,1,1,1,
		1,1,1,1,1,1,1,3,1,19,8,1,1,2,1,2,1,2,1,2,1,2,3,2,26,8,2,1,2,0,0,3,0,2,
		4,0,0,27,0,11,1,0,0,0,2,18,1,0,0,0,4,25,1,0,0,0,6,7,3,2,1,0,7,8,5,1,0,
		0,8,9,3,0,0,0,9,12,1,0,0,0,10,12,3,2,1,0,11,6,1,0,0,0,11,10,1,0,0,0,12,
		1,1,0,0,0,13,14,3,4,2,0,14,15,5,2,0,0,15,16,3,2,1,0,16,19,1,0,0,0,17,19,
		3,4,2,0,18,13,1,0,0,0,18,17,1,0,0,0,19,3,1,0,0,0,20,21,5,3,0,0,21,22,3,
		0,0,0,22,23,5,4,0,0,23,26,1,0,0,0,24,26,5,5,0,0,25,20,1,0,0,0,25,24,1,
		0,0,0,26,5,1,0,0,0,3,11,18,25
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace ListenersExpr.Grammar
