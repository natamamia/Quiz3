// 3. ემოდის გამოსახულება სტრინგის სახით. 
// დაწერეთ პროგრამა რომელიც ამ გამოსახულების შედეგს გამოთვლის (არითმეტიკული ოპერაციები ჩავთვალოთ რომ გვაქვს მხოლოდ + - * ) 
// მაგ: “((1+2)*(3+4))*(5*(8+9))”


Console.WriteLine("Stack");
Stack<string> stack = new Stack<string>();

stack.Push("(");
stack.Push(")");
stack.Push("+");
stack.Push("-");
stack.Push("*");

stack.Push("1");
stack.Push("2");
stack.Push("3"); 
stack.Push("4");
stack.Push("5");
stack.Push("8");
stack.Push("9");

while(stack.Count != 0)
{

}