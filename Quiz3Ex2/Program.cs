// 2. ექმენით Custom Queue- ჯენერიკ იმპლემენტიაცია განუსაზღვრეთ კონსტრუქტორი პარამეტრიანი და უპარამეტროც.
//  ნდა შეიძებოდეს ქიუს ზომის შემოწმება ცარიელია თუ არა. ნდა იყოს ელემენტის დამატების და წაშლის მეთოდები.
//  ანარჩენი მეთოდები შეგიძლიათ დაამატოთ სურვილისამებრ.


using Quiz3Ex2.CustomQueue;
using System.Collections.Generic;

public class CustomQueue
{

    MyQueue<int> queue = new MyQueue<int>();



    Console.WriteLine(queue.Size());
    public CustomQueue()
    {


    }



}
