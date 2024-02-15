Console.WriteLine("Please Enter First Student Name");
string firstStudent = Console.ReadLine();
Console.WriteLine("Enter Math1 No.");
int math1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter English1 No.");
int english1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter SST1 No.");
int sst1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Science1 No.");
int science1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Please Enter second Student Name");
string secondStudent = Console.ReadLine();
Console.WriteLine("Enter Math2 No.");
int math2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter English2 No.");
int english2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter SST2 No.");
int sst2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Science2 No.");
int science2 = Convert.ToInt32(Console.ReadLine());

int total1 = math1+english1+sst1+science1;
int total2 = math2+english2+sst2+science2;

Console.WriteLine("Total Marks Of First Student is"+ total1);
Console.WriteLine("Total Marks Of Second Student is"+ total2);
if (total1>total2)
{
    Console.WriteLine("First Student got Maximum Marks which is "+total1+" and his name is "+firstStudent);
}
else
{
    Console.WriteLine("Second Student got Maximum Marks which is "+total2+" and his name is "+secondStudent);
}