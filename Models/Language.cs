using System;

namespace website.Models
{
    public class ProgrammingLanguage
    {
        public ProgrammingLanguage(string Name, DateTime StartDate)
        {
            _Name = Name;
            _StartDate = StartDate;
        }

        private string _Name;
        public string Name
        {
            get { return _Name;}
            set { _Name = value;}
        }

        private DateTime _StartDate;
        public DateTime StartDate
        {
            get { return _StartDate;}
            set { _StartDate = value;}
        }
        
        
    }
}