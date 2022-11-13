using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//c. აგნის კლასი უნდა შეიცავდეს საგნის დასახელებას, წინაპირობებეს (იმ საგნებს რომელიც არის წინაპირობა ახალი საგნის ასარჩევად), 
// კრედიტის რაოდენობას და საგანზე მაქსიმალური სტუდენტების რაოდენობას.

namespace Quiz3Ex1.SubjectInfo
{
     
    internal class Subject 
    {
        public string _subjectName;
        public string _java;
        public int _credit;
        public int _maxStudent;
        
        public Subject(string subjectName, string java, int credit, int maxStudent)
        {
            this._subjectName = subjectName;
            this._java = java;
            this._credit = credit;
            this._maxStudent = maxStudent;

        }

        public override string ToString()
        {
            return $"{_subjectName} {_java} {_credit} {_maxStudent}";
        }
    }
}
