namespace Full_Stack_dotnet_Developement_Bootcamp;
public class Generic_Collection
{
    //List
    // List<int> List1 = new List<int>();
    // public void insert()
    // {
    //     List1.Add(1);
    //     List1.Add(2);
    //     List1.Add(3);
    //     List1.Add(4);
    //     List1.Add(6);
    // }
    // public void upDate()
    // {
    //     List1[4]=5;
    // }
    // public void read()
    // {
    //     Console.WriteLine("\nElements in the List are:");
    //     foreach (var item in List1)
    //     {
    //         Console.WriteLine("Vlaue of  list is : " +item);
    //     }
    // }
    // public void delete()
    // {
    //     List1.RemoveAt(4);
    // }


    //Dictionary

    // Dictionary <int,string> Dictionary1 = new Dictionary<int,string>();
    // public void insert()
    // {
    //     Dictionary1.Add(1,"Durgesh Tiwari");
    //     Dictionary1.Add(2,"B.Tech.");
    //     Dictionary1.Add(3,"2006480100019");
    //     Dictionary1.Add(4,"true");
    //     Dictionary1.Add(5,"DateTime");
    // }
    // public void upDate()
    // {
    //     Dictionary1[1]="Durgesh Pratap Tiwari";
    //     Dictionary1[4]="DateTime.Now";
    // }
    // public void read()
    // {
    //     Console.WriteLine("\nElements in the Dictionary are:");
    //     foreach(var i in Dictionary1)
    //     {
    //         Console.Write("Key is "+i.Key+" and Value is "+i.Value+'\n');
    //     }
    // }
    // public void delete()
    // {
    //     Dictionary1.Remove(4);
    //     Dictionary1.Clear();
    // }   


    //Stack
    Stack <string> stack1 = new Stack<string>();
    public void insert()
    {
        stack1.Push("Durgesh Tiwari");
        stack1.Push("B.Tech");
        stack1.Push("2006480100019");
        stack1.Push("true");
        stack1.Push("DateTime");
    }
    public void check()
    {
        if (stack1.Contains("Durgesh Pratap Tiwari"))
        {
            Console.WriteLine("Element exists in the Stack.\n");
        }
        else
        {
            Console.WriteLine("Element are notexists in the Stack.\n");
        }
    }
    public void read()
    {
        Console.WriteLine("\nElements in the Stack are:");
        foreach(var i in stack1)
        {
            Console.Write(i+"\n");
            
        }
    }
    public void delete()
    {
        stack1.Pop();
    }   

}