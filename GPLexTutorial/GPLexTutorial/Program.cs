﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPLexTutorial
{


    //public enum Tokens {
    //    error=127,EOF=128,NUMBER=129,IDENT=130,IF=131,ELSE=132,
    //    INT=133,BOOL=134};
    public enum Tokens
    {
        error = 127,
        NUMBER = 258,
        IDENT = 259,
        IF = 260,
        ELSE = 261,
        INT = 262,
        BOOL = 263,
        EOF = 264
    };

    //public struct MyValueType
    //{
    //    public int num;
    //    public string name;
    //};
    //public abstract class ScanBase
    //{
    //    public MyValueType yylval;
    //    public abstract int yylex();
    //    protected virtual bool yywrap() { return true; }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            Scanner scanner = new Scanner(new System.IO.FileStream(args[0], System.IO.FileMode.Open));
            //Parser parser = new Parser(scanner);
            //parser.Parse();

            Tokens token;
            do
            {
                //int x = scanner.yylex();
                token = (Tokens)scanner.yylex();
                switch (token)
                {
                    case Tokens.NUMBER:
                        Console.WriteLine("NUMBER ({0})", scanner.yylval.num);
                        break;
                    case Tokens.IDENT:
                        Console.WriteLine("IDENT ({0})", scanner.yylval.name);
                        break;
                    case Tokens.IF:
                        Console.WriteLine("IF");
                        break;
                    case Tokens.ELSE:
                        Console.WriteLine("ELSE");
                        break;
                    case Tokens.INT:
                        Console.WriteLine("INT");
                        break;
                    case Tokens.BOOL:
                        Console.WriteLine("BOOL");
                        break;
                    case Tokens.EOF:
                        Console.WriteLine("EOF");
                        break;
                    default:
                        Console.WriteLine("'{0}'", (char)token);
                        break;
                }
            }
            while (token != Tokens.EOF);
            Console.Read();
        }
    }
}
