using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    enum TimeFrame { Year, TwoEars, Long }
    internal class ResearchTeam
    {
        string _theme;
        string _org;
        int _regNumb;
        TimeFrame _timeFrame;
        Paper[] _papers;
        //TimeFrame p = TimeFrame.Year;

        //Конструктор с параметрами
        public ResearchTeam(string _theme, string _person, int _regNumb, TimeFrame _timeFrame)
        {

        }
        public ResearchTeam()
        {
            _theme = " Тема публикации";
            _org = " Организация";
            _regNumb = 0;
            _timeFrame = TimeFrame.Year;
            _papers = new Paper[0];
        }
        //Свойства
        public string Theme
        {
            get { return _theme; }
            set { _theme = value; }
        }
        public string Org
        {
            get { return _org; }
            set { _org = value; }
        }
        public int RegNumb
        {
            get { return _regNumb; }
            set { _regNumb = value; }
        }
        public TimeFrame TimeFrame
        {
            get { return _timeFrame; }
            set { _timeFrame = value; }
        }
        public Paper[] Paper
        {
            get { return _papers; }
            set { _papers = value; }
        }
        public Paper PaperGet
        {
            //if (papers == null)
            get { return _papers[_papers.Length - 1]; } //Сделать самую позднюю
        }
        public void AddPapers(params Paper[] papers)
        {
            Paper[] tmp = new Paper[_papers.Length + papers.Length];

            for (int i=0; i < _papers.Length; i++)
            {
                tmp[i] = _papers[i];
            }
           for (int i=0; i < papers.Length; i++ )
            {
                tmp[_papers.Length+i] = papers[i];
            }
           _papers = tmp  ;

            //определить размер нового массива = размер _паперс + паперс
            //создать новый массив с рассчитанным размером
            //скопировать туда сначала старые данные (_паперс)
            //с той позиции, где остановились, докопировать элементы нового массива
            //подменяем значение ссылки _паперс = новый массив
            //скопирова
            // papers.ToString(); 

        }
        public string ToFullString()
        {
            string _str = $"{Theme} {Org} {RegNumb} {TimeFrame} {Paper}";
            return _str;
        }
    }
}
