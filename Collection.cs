using System.Collections;

namespace Full_Stack_dotnet_Developement_Bootcamp;

public class Collection
{
    //Array
    // int[] Array1 = new int[5];
    // public void insert()
    // {
    //     Array1[0]=5;
    //     Array1[1]=6;
    //     Array1[2]=7;
    //     Array1[3]=8;
    //     Array1[4]=9;
    // }
    // public void upDate()
    // {
    //     Array1[3]=10;
    // }
    // public void read()
    // {
    //     Console.WriteLine("Elements in the array are:");
    //     foreach(int i in Array1)
    //         Console.Write(i + " ");
    // }
    // public void delete()
    // {
    //     Array1[2]=0;
    // }   


    //Arraylist

    ArrayList ArrayList1 = new ArrayList();
    public void insert()
    {
        ArrayList1.Add(5);
        ArrayList1.Add("Durgesh");
        ArrayList1.Add(5.8);
        ArrayList1.Add(true);
        ArrayList1.Add("Shubham");
    }
    public void upDate()
    {
        ArrayList1[1]="Durgesh Tiwari";
        ArrayList1[4]="Sbhubham Tiwar";
    }
    public void read()
    {
        Console.WriteLine("\nElements in the ArrayList are:");
        foreach(object i in ArrayList1)
        {
            Console.Write(i + " ");
        }
    }
    public void delete()
    {
        ArrayList1[4]=null;
    }   
}