namespace Full_Stack_dotnet_Developement_Bootcamp;
public class TryCatchMethod
{
    public void MyMethod1()
    {
        try
        {
            int num1 = 10;
            int num2 = 0;
            int Result = num1/num2;
            Console.WriteLine("Resut is = "+Result);
            throw new ArgumentException("New  Exception"); // Throwing an exception from a method
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Divided by Zero Error Ocured(In MyMethod1)");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("I'm  in the Finally Block mai to chuga he");
        }
        
    }
}
