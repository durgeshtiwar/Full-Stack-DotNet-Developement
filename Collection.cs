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

    // ArrayList ArrayList1 = new ArrayList();
    // public void insert()
    // {
    //     ArrayList1.Add(5);
    //     ArrayList1.Add("Durgesh");
    //     ArrayList1.Add(5.8);
    //     ArrayList1.Add(true);
    //     ArrayList1.Add("Shubham");
    // }
    // public void upDate()
    // {
    //     ArrayList1[1]="Durgesh Tiwari";
    //     ArrayList1[4]="Sbhubham Tiwar";
    // }
    // public void read()
    // {
    //     Console.WriteLine("\nElements in the ArrayList are:");
    //     foreach(object i in ArrayList1)
    //     {
    //         Console.Write(i + " ");
    //     }
    // }
    // public void delete()
    // {
    //     ArrayList1[4]=null;
    // }   

    //HashTable


    // Hashtable HashTable1 = new Hashtable();
    // public void insert()
    // {
    //     HashTable1.Add(1,"Durgesh Tiwari");
    //     HashTable1.Add(2,"B.Tech.");
    //     HashTable1.Add(3,2006480100019);
    //     HashTable1.Add("isStudent",true);
    //     HashTable1.Add(4,DateTime.Now);
    // }
    // public void upDate()
    // {
    //     HashTable1[1]="Durgesh Pratap Tiwari";
    //     HashTable1[4]=DateTime.Now;
    // }
    // public void read()
    // {
    //     Console.WriteLine("\nElements in the HashTable are:");
    //     foreach(DictionaryEntry i in HashTable1)
    //     {
    //         Console.Write("Key is "+i.Key+" and Value is "+i.Value+'\n');
    //     }
    // }
    // public void delete()
    // {
    //     HashTable1.Remove(4);
    //     HashTable1.Clear();
    // }   

    //Stack


    // Stack stack1 = new Stack();
    // public void insert()
    // {
    //     stack1.Push("Durgesh Tiwari");
    //     stack1.Push("B.Tech");
    //     stack1.Push(2006480100019);
    //     stack1.Push(true);
    //     stack1.Push(DateTime.Now);
    // }
    // public void check()
    // {
    //     if (stack1.Contains("Durgesh Pratap Tiwari"))
    //     {
    //         Console.WriteLine("Element exists in the Stack.\n");
    //     }
    //     else
    //     {
    //         Console.WriteLine("Element exists in the Stack.\n");
    //     }
    // }
    // public void read()
    // {
    //     Console.WriteLine("\nElements in the Stack are:");
    //     foreach(var i in stack1)
    //     {
    //         Console.Write(i+"\n");
            
    //     }
    // }
    // public void delete()
    // {
    //     stack1.Pop();
    // }   


    
    Queue Queue1 = new Queue();
    public void insert()
    {
        Queue1.Enqueue("Durgesh Tiwari");
        Queue1.Enqueue("B.Tech");
        Queue1.Enqueue(2006480100019);
        Queue1.Enqueue(true);
        Queue1.Enqueue(DateTime.Now);
    }
    public void check()
    {
        if (Queue1.Contains("Durgesh Pratap Tiwari"))
        {
            Console.WriteLine("Element exists in the Queue.\n");
        }
        else
        {
            Console.WriteLine("Element not exists in the Queue.\n");
        }
    }
    public void read()
    {
        Console.WriteLine("\nElements in the Stack are:");
        foreach(var i in Queue1)
        {
            Console.Write(i+"\n");
            
        }
    }
    public void delete()
    {
        Queue1.Dequeue();
    }   
}