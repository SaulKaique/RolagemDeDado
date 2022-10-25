Console.Clear();


Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("--- Rolagem de Dado ---\n");


Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Quantas faces? ");
int faces = Convert.ToInt32(Console.ReadLine());



int Rolagem = new Random().Next(1,100);
Console.ResetColor();


Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"\nRolagem: {Rolagem}");
Console.ResetColor();
