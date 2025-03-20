Console.Clear();

string cebolinha;

Console.WriteLine("Escreva uma frase: ");
cebolinha = Console.ReadLine()!;

Console.WriteLine($"Frase do cebolinha: {cebolinha.Replace('r', 'l')}");