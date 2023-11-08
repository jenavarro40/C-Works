using System;

public class programa2
{
	public programa2()
	{
		int Entrada1;
		int Entrada2;
		int Result;
		string Entrada1_string;
		string Entrada2_string;
		Console.WriteLine("Write numbers and press enter");
		Entrada1_string = Console.ReadLine();
		Entrada2_string = Console.ReadLine();
		Entrada1= Convert.Toint(Entrada1);
		Entrada2=Convert.Toint(Entrada2);
		Result=Entrada1*Entrada2;
        Console.WriteLine("Multiplication from: {0} and {1} is: {3}",(Entrada1),(Entrada2),(Result));
        Result = Entrada1 / Entrada2;
        Console.WriteLine("Division from: {0} and {1} is: {3}", (Entrada1), (Entrada2), (Result));
        Result = Entrada1 + Entrada2;
        Console.WriteLine("Sum from: {0} and {1} is: {3}", (Entrada1), (Entrada2), (Result));
        Result = Entrada1 - Entrada2;
        Console.WriteLine("Rest from: {0} and {1} is: {3}", (Entrada1), (Entrada2), (Result));
        Result = Entrada1 mod Entrada2;
        Console.WriteLine("Mod from: {0} and {1} is: {3}", (Entrada1), (Entrada2), (Result));
		Return result;

    }
}
