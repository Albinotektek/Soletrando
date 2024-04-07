Console.WriteLine();

Console.WriteLine("----Soletrar----\n");

Console.Write("Digite uma palavra:");
string txt = Console.ReadLine()!;

Console.WriteLine();

Console.WriteLine("\nSoletrando fica:\n");

Console.WriteLine(string.Join("-",txt.ToUpper().ToCharArray()));

Console.WriteLine();