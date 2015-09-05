// Const and ReadOnky
// What is the difference between const and readonly?

//Apart from the apparent difference of
	//having to declare the value at the time of a definition for a const VS readonly values can be computed dynamically but need to be assigned before the constructor exits.. after that it is frozen.
	//'const's are implicitly static. You use a ClassName.ConstantName notation to access them.

//There is a subtle difference. Consider a class defined in AssemblyA.

public class Const_V_ReadOnly
{
	public const int I_CONST_VALUE = 2;
	public readonly int I_RO_VALUE;

	public Const_V_ReadOnly()
	{
		// Here Readonly is being initialized 
		I_RO_VALUE = 2;
	}

	// after the constructor the Readonly field is frozen
}


// AssemmblyB References AssemblyA and uses these values in code. When this is compiled

	// >> in this case of the const value it's like a find-replace, the value 2 is baked into the AssemblyB's IL
	// 	  this means that if tomorrow i'll update I_CONST_VALUE to 20. AssemblyB would still contain 2 till i recompile it

	// >> in the case of the readonly, it is like a ref to a memory location. The value is not baked into ASSEMBLYB's IL
	//    this means that if the memory location is updated. ASSEMBLYB gets the new value without recompilation. 
	//    so if I_RO_VALUE is updated 30, you only need to build ASSEMBLY A.
	//    all clients donot need to be recompiled
