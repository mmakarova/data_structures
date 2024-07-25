using DataStructure;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class Program
{
    public static void Main()
    {
        //Входные данные для Stepik
        //5
        //4 -1 4 1 1
        //string input1 = string.Empty;
        //string input2 = string.Empty;
        //input1 = Console.ReadLine();
        //input2 = Console.ReadLine();
        //TreeHeight th = new TreeHeight(Convert.ToInt32(input1), input2);

        //Console.WriteLine(th.GetHeight());

        string input1 = string.Empty;
        List<string>? packages = null;
        input1 = Console.ReadLine();
        int number = Convert.ToInt32(input1.Split(' ')[1]);
        for (int i = 0; i < number; i++) {
            if (i == 0) { packages = new List<string>(); }
            string? package = Console.ReadLine();
            packages.Add(package);
        }
        StautsOfNetPackages queue = new StautsOfNetPackages(input1, packages);
        var output = String.Join(Environment.NewLine, queue.GetOutputString());

        Console.WriteLine(output);
    }

}

