class Calculator
{
	static void Main(string[] args)
	{
		int a = 10;
		int b = 6;
		
		Console.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a, b, penjumlahan(a, b));
		
	}
	
	static int penjumlahan(int a, int b)
	{
		return a + b;
	}
	
	static int pengurangan(int a, int b)
	{
		return a - b;
	}
}