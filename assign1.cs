// Console.WriteLine("Please Enter First Student Name");
// string firstStudent = Console.ReadLine();
// Console.WriteLine("Enter Math1 No.");
// int math1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter English1 No.");
// int english1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter SST1 No.");
// int sst1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter Science1 No.");
// int science1 = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine("Please Enter second Student Name");
// string secondStudent = Console.ReadLine();
// Console.WriteLine("Enter Math2 No.");
// int math2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter English2 No.");
// int english2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter SST2 No.");
// int sst2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter Science2 No.");
// int science2 = Convert.ToInt32(Console.ReadLine());

// int total1 = math1+english1+sst1+science1;
// int total2 = math2+english2+sst2+science2;

// Console.WriteLine("Total Marks Of First Student is"+ total1);
// Console.WriteLine("Total Marks Of Second Student is"+ total2);
// if (total1>total2)
// {
//     Console.WriteLine("First Student got Maximum Marks which is "+total1+" and his name is "+firstStudent);
// }
// else
// {
//     Console.WriteLine("Second Student got Maximum Marks which is "+total2+" and his name is "+secondStudent);
// }

// int[] arr = new int[10];
// for (int i = 0; i < 10; i++)
// {
//     Console.Write("Enter no.");
//     arr[i]= Convert.ToInt32(Console.ReadLine());
// }
// for (int i = 0; i < 10; i++)
// {
//     Console.Write(arr[i]+"\n");
// }
// Console.ReadLine();


// 21. Write a program in C# Sharp to display the sum of the series [ 9 + 99 + 999 + 9999 ...].
// Test Data :

// Console.WriteLine("Enter the no .of terms you want to add in series");
// int num =Convert.ToInt32(Console.ReadLine());
// int j = 9, sum=0;
// for (int i = 0; i < num; i++)
// {
//     sum = sum + j ;
//     j= j*10 + 9;
// }
// Console.WriteLine("The Sum of Series is = "+sum);
// Console.ReadLine();

using addition;
using life;

Number a = new Number();
a.x = 7;
a.y = 5;
Console.WriteLine("Sum = " + a.add(a.x, a.y));
Console.ReadLine();

Human Durgesh = new Human();
Durgesh.Name = "Durgesh";
Durgesh.Age = 20;
Durgesh.Gender = "Male";
Durgesh.Qualification = "B.tech";
Durgesh.Nationality = "Indian";
Durgesh.eat("Rice and Daal");
Durgesh.Introduction();
Console.ReadLine();
