int[] arr1 = new int[10];
int i, j;
for (i = 0; i < 10; i++)
{
    Console.WriteLine("Enter The value");
    arr1[i] = Convert.ToInt32(Console.ReadLine());
}
for (j = 0; j < 10; j++)
{
    Console.WriteLine(arr1[j]);
}
Console.ReadLine();