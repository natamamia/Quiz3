using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// b. ასწავლებლის კლასი უნდა შეიცავდეს მასწავლების სახელს და გვარს და იმ საგნების სიას რომელსაც ასწავლის.
// რთ მასწავლებელს არ უნდა შეეძლოს 3 ზე მეტი საგნის სწავლება. ლასს განუსაზღვრეთ საგნის დამატების და შეცვლის მეთოდები.

namespace Quiz3Ex1.TeacherInfo
{
    internal class Teacher
    {

        public string _firstName;
        public string _lastName;
        public string _subjectMajor;


        public Teacher(string firstName, string lastName, string subjectMajor)
        { 
            this._firstName = firstName; 
            this._lastName = lastName; 
            this._subjectMajor = subjectMajor; 
        }

        public override string ToString()
        {
            return $"{_firstName} {_lastName} {_subjectMajor}";
        }

    }
}
