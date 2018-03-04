// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, John Gough, QUT 2005-2014
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.5.2
// Machine:  DESKTOP-0A7SJHH
// DateTime: 4/03/2018 9:47:30 PM
// UserName: arune
// Input file <parser.y - 4/03/2018 9:47:25 PM>

// options: lines gplex

using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Text;
using QUT.Gppg;

namespace GPLexTutorial
{
public enum Tokens {
    error=127,EOF=128,NUMBER=129,IDENT=130,IF=131,ELSE=132,
    INT=133,BOOL=134};

public struct ValueType
#line 4 "parser.y"
{
    public int num;
    public string name;
}
#line default
// Abstract base class for GPLEX scanners
[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
public abstract class ScanBase : AbstractScanner<ValueType,LexLocation> {
  private LexLocation __yylloc = new LexLocation();
  public override LexLocation yylloc { get { return __yylloc; } set { __yylloc = value; } }
  protected virtual bool yywrap() { return true; }
}

// Utility class for encapsulating token information
[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
public class ScanObj {
  public int token;
  public ValueType yylval;
  public LexLocation yylloc;
  public ScanObj( int t, ValueType val, LexLocation loc ) {
    this.token = t; this.yylval = val; this.yylloc = loc;
  }
}

[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
public class Parser: ShiftReduceParser<ValueType, LexLocation>
{
#pragma warning disable 649
  private static Dictionary<int, string> aliases;
#pragma warning restore 649
  private static Rule[] rules = new Rule[16];
  private static State[] states = new State[30];
  private static string[] nonTerms = new string[] {
      "Program", "$accept", "Statement", "Expression", "StatementList", "Type", 
      };

  static Parser() {
    states[0] = new State(new int[]{131,4,123,11,129,23,130,24,133,28,134,29},new int[]{-1,1,-3,3,-4,15,-6,25});
    states[1] = new State(new int[]{128,2});
    states[2] = new State(-1);
    states[3] = new State(-2);
    states[4] = new State(new int[]{40,5});
    states[5] = new State(new int[]{129,23,130,24},new int[]{-4,6});
    states[6] = new State(new int[]{41,7,61,17,43,19,60,21});
    states[7] = new State(new int[]{131,4,123,11,129,23,130,24,133,28,134,29},new int[]{-3,8,-4,15,-6,25});
    states[8] = new State(new int[]{132,9});
    states[9] = new State(new int[]{131,4,123,11,129,23,130,24,133,28,134,29},new int[]{-3,10,-4,15,-6,25});
    states[10] = new State(-3);
    states[11] = new State(-10,new int[]{-5,12});
    states[12] = new State(new int[]{125,13,131,4,123,11,129,23,130,24,133,28,134,29},new int[]{-3,14,-4,15,-6,25});
    states[13] = new State(-4);
    states[14] = new State(-9);
    states[15] = new State(new int[]{59,16,61,17,43,19,60,21});
    states[16] = new State(-5);
    states[17] = new State(new int[]{129,23,130,24},new int[]{-4,18});
    states[18] = new State(new int[]{61,-13,43,19,60,21,59,-13,41,-13});
    states[19] = new State(new int[]{129,23,130,24},new int[]{-4,20});
    states[20] = new State(-14);
    states[21] = new State(new int[]{129,23,130,24},new int[]{-4,22});
    states[22] = new State(new int[]{61,-15,43,19,41,-15,59,-15});
    states[23] = new State(-11);
    states[24] = new State(-12);
    states[25] = new State(new int[]{130,26});
    states[26] = new State(new int[]{59,27});
    states[27] = new State(-6);
    states[28] = new State(-7);
    states[29] = new State(-8);

    for (int sNo = 0; sNo < states.Length; sNo++) states[sNo].number = sNo;

    rules[1] = new Rule(-2, new int[]{-1,128});
    rules[2] = new Rule(-1, new int[]{-3});
    rules[3] = new Rule(-3, new int[]{131,40,-4,41,-3,132,-3});
    rules[4] = new Rule(-3, new int[]{123,-5,125});
    rules[5] = new Rule(-3, new int[]{-4,59});
    rules[6] = new Rule(-3, new int[]{-6,130,59});
    rules[7] = new Rule(-6, new int[]{133});
    rules[8] = new Rule(-6, new int[]{134});
    rules[9] = new Rule(-5, new int[]{-5,-3});
    rules[10] = new Rule(-5, new int[]{});
    rules[11] = new Rule(-4, new int[]{129});
    rules[12] = new Rule(-4, new int[]{130});
    rules[13] = new Rule(-4, new int[]{-4,61,-4});
    rules[14] = new Rule(-4, new int[]{-4,43,-4});
    rules[15] = new Rule(-4, new int[]{-4,60,-4});
  }

  protected override void Initialize() {
    this.InitSpecialTokens((int)Tokens.error, (int)Tokens.EOF);
    this.InitStates(states);
    this.InitRules(rules);
    this.InitNonTerminals(nonTerms);
  }

  protected override void DoAction(int action)
  {
#pragma warning disable 162, 1522
    switch (action)
    {
    }
#pragma warning restore 162, 1522
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliases != null && aliases.ContainsKey(terminal))
        return aliases[terminal];
    else if (((Tokens)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((Tokens)terminal).ToString();
    else
        return CharToString((char)terminal);
  }

#line 44 "parser.y"

public Parser(Scanner scanner) : base(scanner)
{
}

#line default
}
}
