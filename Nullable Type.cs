// Nullable Types

// instances of System.Nullable<T> struct

// Example 

class NullableExample()
{
	static void Main()
	{
		int? num = Nullable 

		// Is the HasValue property true
		if(num.HasValue)
			System.Console.WriteLine("num = " + num.Value);
		else
			System.Console.WriteLine("num = Null");

		// y is set to zero
		int y = num.GetValueOrdDefault();

		// num.Value throws an InvalidOperationException if num.HasValue is false
		try
		{
			y = num.Value;
		}
		catch(System.InvalidOperationException e)
		{
			System.Console.WriteLine(e.Message);
		}

	}
}


// Use the ?? operator to assign a default value
// that will be applied when a nullable type whose current value 

// for example
// int? x = null;
// 

// Nested Nullable Types are not allowed
// the follwoing code will not compile
// Nullable<Nullable<int>> n;