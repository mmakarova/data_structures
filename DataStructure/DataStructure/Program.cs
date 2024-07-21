using DataStructure;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        //Если скобки в s расставлены правильно, выведите
        //строку “Success". В противном случае выведите индекс (используя индексацию с единицы) первой закрывающей скобки, для
        //которой нет соответствующей открывающей. Если такой нет,
        //выведите индекс первой открывающей скобки, для которой нет
        //соответствующей закрывающей.

        //stack.count = 0 -->success
        //index первой из closeSymbols у которой нет открывающейся. верхняя в стеке открывающаяся <> текущей
        //index первой из openSymbols У которой нет закрывающейся

        //string input = string.Empty;
        //input = Console.ReadLine();
        //int count = IsBalanced(input);
        //Console.WriteLine(count == 0 ? "Sucusses" : count);
        Console.WriteLine("1- IsBalanced(\"{\") == 1 - " + StackToCheckBracketsBalance.IsBalanced("{"));
        Console.WriteLine("1- IsBalanced(\"{[}\") == 3 - " + StackToCheckBracketsBalance.IsBalanced("{[}"));
        Console.WriteLine("1- IsBalanced(\"foo(bar[i);\") == 10 - " + StackToCheckBracketsBalance.IsBalanced("foo(bar[i);"));
        Console.WriteLine("2- IsBalanced(\"[](){([])})\") == 0 " + StackToCheckBracketsBalance.IsBalanced("([](){([])})"));
        Console.WriteLine("3- IsBalanced(\"()[]}\") == 5) " + StackToCheckBracketsBalance.IsBalanced("()[]}"));
        Console.WriteLine("4- IsBalanced(\"{{{[][][]\") == 3 " + StackToCheckBracketsBalance.IsBalanced("{{{[][][]"));
        Console.WriteLine("5- IsBalanced(\"{*{{}\") == 3 " + StackToCheckBracketsBalance.IsBalanced("{*{{}"));
        Console.WriteLine("6- IsBalanced(\"[[***\") == 2 " + StackToCheckBracketsBalance.IsBalanced("[[***"));
        Console.WriteLine("7- IsBalanced(\"{*}\") == 0 " + StackToCheckBracketsBalance.IsBalanced("{*}"));
        Console.WriteLine("8- IsBalanced(\"{{{**[][][]\") == 3 " + StackToCheckBracketsBalance.IsBalanced("{{{**[][][]"));
        Console.WriteLine("9- IsBalanced(\"*{}\") == 0 " + StackToCheckBracketsBalance.IsBalanced("*{}"));        
        Console.WriteLine("1- IsBalanced(\"[]([]\") == 3 - " + StackToCheckBracketsBalance.IsBalanced("[]([]"));
        Console.WriteLine("1- IsBalanced(\"{{{[][][]\") == 3 - " + StackToCheckBracketsBalance.IsBalanced("{{{[][][]"));       
    }

    public class BracketIndex
    {
        public int Index { get; set; }
        public char Bracket { get; set; }
    }
}

