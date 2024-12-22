public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that is not yet initialized can lead to unexpected behavior.
        int value = MyProperty; // This might return 0, but it is not explicitly set
    }
}