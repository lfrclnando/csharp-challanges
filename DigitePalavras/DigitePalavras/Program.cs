string tracosPalavras = new string('-', 10);
string tracosResultado = new string('-', 16);

Console.WriteLine($"{tracosPalavras} DIGITA AS PALAVRAS {tracosPalavras}\n");

Console.Write("Digite uma ou mais palavras: ");
string wordsOriginal = (Console.ReadLine());

if (string.IsNullOrWhiteSpace(wordsOriginal))
{
    Console.WriteLine("\nVocê não digitou nada... Tente novamente!!!");
    return;
}

string wordsWithoutSpaces = wordsOriginal.Replace(" ", "");

int count = wordsWithoutSpaces.Length;

Console.WriteLine($"\n{tracosResultado} RESULTADO {tracosResultado}\n");

Console.WriteLine($"Texto original: \"{wordsOriginal}\"");
Console.WriteLine($"Texto sem espaços: \"{wordsWithoutSpaces}\"");
Console.WriteLine($"\nTotal de caracteres (sem os espaços): {count}\n");
Console.WriteLine("-------------------------------------------");
