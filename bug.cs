public class ExampleClass
{
    private int _myField;

    public int MyProperty
    {
        get { return _myField; }
        set { _myField = value; }
    }

    public void MyMethod()
    {
        // Some code here that might throw an exception
        try
        {
            // ...
        }
        catch (Exception ex)
        {
            // Handle exception
            Console.WriteLine("Exception caught: " + ex.Message);
            //Do not rethrow the exception, this is the error
        }
    }
}