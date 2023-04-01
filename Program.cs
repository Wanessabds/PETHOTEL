Console.WriteLine("___PET HOTEL WN___\n");

Console.Write("Espécie__: ");
string especie = Console.ReadLine()!;


Console.Write("Raça__: ");
string raca = Console.ReadLine()!;

Console.Write("Apelido__: ");
string alcunha = Console.ReadLine()!;

Console.Write("Idade__: ");
string idade = Console.ReadLine()!;

Console.Write("Cor da pelagem__: ");
string pelagemCor = Console.ReadLine()!;

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("+--------------------------------------------------------+");
Console.Write("|                 ");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write(" PET HOTEL WN    |");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("                  |");

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("+--------------------------------------------------------+");
Console.Write("| Espécie: ");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write(especie.Trim().ToUpper().PadLeft(15, '.').Substring(0, 15));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write(" | Raça: ");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write(raca.Trim().ToUpper().PadLeft(22, '.').Substring(0, 22));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine(" |");

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("+---------------------------------------------------------+");
Console.Write("| Atende pelo apelido : ");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write(alcunha.Trim().ToUpper().PadLeft(31, '.').Substring(0, 31));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine(" |");
Console.Write("| Idade: ");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write($"{idade.Trim().ToUpper().PadLeft(2, '0').Substring(0, 2)} ano(s)");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write(" | Cor da pelagem: ");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write(pelagemCor.Trim().ToUpper().PadLeft(23, '.').Substring(0, 23));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine(" |");

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write("+----------------------------------------------------------+");

Console.ResetColor();
