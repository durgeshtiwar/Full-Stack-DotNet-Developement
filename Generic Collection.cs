namespace Full_Stack_dotnet_Developement_Bootcamp;
public class Generic_Collection
{
    //List
    List<int> List1 = new List<int>();
    public void insert()
    {
        List1.Add(1);
        List1.Add(2);
        List1.Add(3);
        List1.Add(4);
        List1.Add(6);
    }
    public void upDate()
    {
        List1[4]=5;
    }
    public void read()
    {
        Console.WriteLine("\nElements in the List are:");
        foreach (var item in List1)
        {
            Console.WriteLine("Vlaue of  list is : " +item);
        }
    }
    public void delete()
    {
        List1.RemoveAt(4);
    }
}