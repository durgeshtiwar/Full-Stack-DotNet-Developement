// using Complex;

// Transform num1 = new Transform();
// num1.SetComplexNumber(5,8);
// num1.PrintComplexNumber();
// Transform num2 = new Transform();
// num1.SetComplexNumber(10,18);
// num1.PrintComplexNumber();
// Console.ReadLine();

using Timejone;

Time time = new Time();
Time time1 = new Time();
time.setTime(66,34,72);
time1.setTime(67,35,73);
time.showTime();
time.add(time1);
Console.ReadLine();
