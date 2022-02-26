using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Person
    {

        string Name;
        string SoName;
        //DateTime date; // год - месяц - день
        public Person()
        {
            Name = "Имя";
            SoName = "Фамилия";
            //date = new DateTime(1999, 09, 9); // год - месяц - день
            //Console.WriteLine(date); // 9.09.1999 0:00:00
        }
        public Person(string Name, string SoName, DateTime date)
        {

        }

        //Cвойства
        public string _Name
        {
            get { return Name; }
            set { Name = value; }
        }

        public string _SoName
        {
            get { return SoName; }
            set { SoName = value; }
        }

        //public DateTime _date
        //{
        //    get { return date; }
        //    set { date = value; }
        //}
        //Свойства закончились

        //public int SetData(DateTime date)
        //      {
        //          this.date = date;
        //      }
        //      public DateTime GetDate(DateTime date)
        //      {
        //          return date;
        //      }

        //      public string GetName(string Name)
        //      {

        //          return Name;
        //      }
        //      public string GetSoName(string SoName)
        //      {
        //          return SoName;
        //      }

        public string ToFullString()
        {
            // date.ToShortDateString();//преобразование даты в строку
            Person Information = new Person();
        string str = Information._Name + " " + Information._SoName + " ";// + Information._date;
            return str;
        }
        public string ToShortString()
        {
            // date.ToShortDateString();//преобразование даты в строку
            Person Information = new Person();
            string str = Information._Name + " " + Information._SoName;
            return str;
        }
    }
