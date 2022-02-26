using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace ConsoleApp2

{


    class Program
    {
        
        static void Main()
        {
            ResearchTeam team = new ResearchTeam();
             Paper paper = new Paper();
            paper.Name = "111111"; 
             Paper paper2 = new Paper();
            paper2.Name = "22222";

            Paper[] ppps = new Paper[2];
            ppps[0] = paper;
            ppps[1] = paper2;

            team.AddPapers(ppps);
            team.AddPapers(ppps);

            Console.WriteLine();
            Person obj = new Person();
            Paper obj2 = new Paper();
            Console.WriteLine(obj2.ToFullString());

        }
    }

}






























//static void Function(string txtOne, string txtTwo)
//{
//    Console.WriteLine($"строка = {txtOne} строка = {txtTwo}");
//}
//    Console.WriteLine($"Сторона a ={a} Сторона b { b} Сторона c ={c}");
//    //Console.WriteLine("Сторона a ="+ a+ "Сторона b ="+ b+ "Сторона c ="+ c );
//    //string txt=Console.ReadLine();
//    // //a=double.Parse(txt);
//    // //txt=Console.ReadLine();
//    // b = double.Parse(txt);
//    //txt=Console.ReadLine();
//    //c = double.Parse(txt);
//    if ((a == b) && (b == c))
//    {
//        Console.WriteLine("Треугольник равносторонний");

//    }
//    else
//        Console.WriteLine("Треугольник  не равносторонний");
//public static void Main(string[] args)
//{
//    IsLeapYear(1994);


//    IsLeapYear(12, 11, 14);
//    Console.WriteLine("vvedite b");
//    string txt = Console.ReadLine();
//    double b = double.Parse(txt);
//    IsLeapYear(11, b, 11);

//}
