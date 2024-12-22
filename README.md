# Uninitialized Property Access in C# 

This example demonstrates a common error in C#: accessing a property before it has been initialized.  Uninitialized properties will often have a default value, but relying on these defaults can lead to unexpected behavior and difficult-to-debug issues in larger projects. It's better to explicitly initialize properties, ensuring predictable results.

## Bug
The `bug.cs` file shows a class with a property that is accessed before it is explicitly assigned a value. This may lead to the variable getting an unexpected default value. 

## Solution
The `bugSolution.cs` file demonstrates the proper way to handle property initialization. By initializing `MyProperty` in the constructor or directly, you eliminate the ambiguity and ensure predictable behavior.