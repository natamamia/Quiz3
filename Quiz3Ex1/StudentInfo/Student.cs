using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// a. ტუდენტის კლასში უნდა არსეობდეს ინფორმაცია სტუდენტის სახელი გვარი პირადი ნომერი (პირადი ნომერი არ უნდა აღემატებოდეს 11 ციფრს),
// საგნების ჩამონათვალს და სემესტრების შესახებ ინფორმაციას.(ეს ცალკე კლასად შეგიძლიათ აღწეროთ).
// ექმენით property რომელიც გამოტანს სახელს და გვარს ერთად.

// ტუდენტს არ უნდა შეეძოს 35 GPA ზე მეტის აღება.
// ექმენით მეთოდები რომელიც გამოიტანს სემესტრის ან სემესტრების საგნების ჩამონათვალს და ლექტორების შესახებ ინფორმაციას.
// ტუდენტ კლასს ასევე უნდა ჰქონდეს მეთოდები რომელიც დაამატებს სემესტრს და ამ სემესტრის საგნებს.
//  ნ კონკრეტულ სემესტრში დაამატებს საგანს.

namespace Quiz3Ex1.StudentInfo
{
    internal class Student
    {
        public string _firstName;
        public string _lastName; 
        public int _personalNumber;
        public string _subjectMajor;
        public int _term;
        
        public Student(string firstName, string lastName, int personalNumber, string subjectMajor, int term)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._personalNumber = personalNumber;
            this._subjectMajor = subjectMajor;
            this._term = term;
        }

        public override string ToString()
        {
            return $"{_firstName} {_lastName} {_personalNumber} {_subjectMajor} {_term}";
        }
    }
}
