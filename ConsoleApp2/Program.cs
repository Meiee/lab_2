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
            ResearchTeam theme = new ResearchTeam();
            ResearchTeam org = new ResearchTeam();
            ResearchTeam regNumb = new ResearchTeam();
            ResearchTeam timeFrame = new ResearchTeam();
            ResearchTeam paper = new ResearchTeam();

            theme.Theme = "Какая-то публикация";
            org.Org = "Какая-то организация";
            regNumb.RegNumb = 2;
            timeFrame.TimeFrame = 0;

            Console.WriteLine(theme.Theme.ToString(), org.Org.ToString(), regNumb.RegNumb.ToString(), timeFrame.TimeFrame.ToString(), paper.ToString());

            theme.Theme.AddPapers();


            //Paper paperr1 = new Paper();
            //paperr1.Name = "111111";
            //Paper paperr2 = new Paper();
            //paperr2.Name = "22222";

            //Paper[] ppps = new Paper[2];
            //ppps[0] = paper;
            //ppps[1] = paper2;

            //team.AddPapers(ppps);
            //team.AddPapers(ppps);
            //Console.WriteLine(team.ToShortString());

            //Console.WriteLine();
            //Paper obj1 = new Paper();
            //Paper obj2 = new Paper();
            //Console.WriteLine(obj2.ToFullString());

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
