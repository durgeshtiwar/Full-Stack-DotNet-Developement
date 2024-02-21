namespace Full_Stack_dotnet_Developement_Bootcamp;

public class Collection
{
    //Array
    int[] Array1 = new int[5];
    public void insert()
    {
        Array1[0]=5;
        Array1[1]=6;
        Array1[2]=7;
        Array1[3]=8;
        Array1[4]=9;
    }
    public void upDate()
    {
        Array1[3]=10;
    }
    public void read()
    {
        Console.WriteLine("Elements in the array are:");
        foreach(int i in Array1)
            Console.Write(i + " ");
    }
    public void delete()
    {
        Array1[2]=0;
    }   
}