// use to declare a method that is implemented externally

// A common use of Extern Modifier is with the DLLImport attribute 
// when use Interop Services to call into unmanaged Code
//

// the method must also be declared as static

[DllImport("avifil32.dll")]
private static extern void AVIFileInit();

// Example - 

// using System.Runtime.InteropServices

class ExternTest
{
	[DllImport("User32.dll", CharSet = CharSet.Unicode)]
	public static extern int MessageBox(IntPtr h, string m, string c, int type);
	static int Main()
	{
		string myString;
		Console.WriteLine("Enter your Message");
		myString = Console.ReadLine();
		return MessageBox((IntPtr)0, myString, "MyMessageBox", 0); 
	}
}