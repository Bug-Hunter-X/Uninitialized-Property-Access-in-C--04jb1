public class ExampleClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public ExampleClass()
    {
        MyProperty = 0; // Or any other appropriate default value
    }

    public void MyMethod()
    {
        int value = MyProperty; // Now MyProperty will have a defined value
    }
}