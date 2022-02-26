using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Paper
    {       
        //Конструктор по умолчанию
        public Paper()
        {
            Name = "Имя";
            Person = new Person();
            Date = new DateTime(1888, 08, 8); // год - месяц - день
        }
//Конструктор с параметрами
        public Paper(string _name, string _person, DateTime _date)
        {

        }
 //Свойства
        public string Name
        
             { get; set; }
        
        public  Person Person

        { get; set; }
        public DateTime Date
        {
            get; set;
        }
 //Свойства закончились

        public string ToFullString()
        {
            // date.ToShortDateString();//преобразование даты в строку
            Paper Information2 = new Paper();
            string str2 = Information2.Name + " " + Information2.Person + " "+ Information2.Date;
            return str2;
        }
    }
}
