using Complex;

Transform num1 = new Transform();
num1.img = 5;
num1.real = 8;
num1.SetComplexNumber(num1.real, num1.img);
num1.PrintComplexNumber();
Transform num2 = new Transform();
num1.img = 10;
num1.real =18;
num1.SetComplexNumber(num1.real, num1.img);
num1.PrintComplexNumber();
Console.ReadLine();