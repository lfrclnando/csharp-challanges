string tracosSoma = new string('-', 10);

Console.WriteLine($"{tracosSoma} SOMA {tracosSoma}\n");

Console.Write("Digite o primeiro número: ");
double num1 = double.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
double num2 = double.Parse(Console.ReadLine());

double plus = num1 + num2;

Console.WriteLine($"\nA soma de {num1} + {num2} são: {plus}... Parabéns!!!");

// -----------------------------------------------------------------------------

string tracosSubtracao = new string('-', 10);

Console.WriteLine($"\n{tracosSubtracao} SUBTRAÇÃO {tracosSubtracao}\n");

Console.Write("Digite o primeiro número: ");
double num3 = double.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
double num4 = double.Parse(Console.ReadLine());

double minus = num3 - num4;

Console.WriteLine($"\nA subtração de {num3} - {num4} são: {minus}... Parabéns, é isso!!!");

// -----------------------------------------------------------------------------

string tracosMultiplicacao = new string('-', 10);

Console.WriteLine($"\n{tracosMultiplicacao} MULTIPLICAÇÃO {tracosMultiplicacao}\n");

Console.Write("Digite o primeiro número: ");
double num5 = double.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
double num6 = double.Parse(Console.ReadLine());

double times = num5 * num6;

Console.WriteLine($"\nA multiplicação entre {num5} por {num6} são: {times}... Parabéns, maravilha!!!");

// -----------------------------------------------------------------------------

string tracosDivisao = new string('-', 10);

Console.WriteLine($"\n{tracosDivisao} DIVISÃO {tracosDivisao}\n");

Console.Write("Digite o primeiro número: ");
double num7 = double.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
double num8 = double.Parse(Console.ReadLine());

if (num8 != 0)
{
    double division = num7 / num8;

    Console.WriteLine($"\nA divisão de {num7} por {num8} são: {division}... Parabéns, maravilha!!!");
}
else
{
    Console.WriteLine("\nNão é possível dividir por zero. Faça novamente.");
}

// -----------------------------------------------------------------------------

string tracosMedia = new string('-', 10);

Console.WriteLine($"\n{tracosMedia} MÉDIA {tracosMedia}\n");

Console.Write("Digite o primeiro número: ");
double num9 = double.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
double num10 = double.Parse(Console.ReadLine());

double media = (num9 + num10) / 2;

Console.WriteLine($"\nA média entre {num9} por {num10} são: {media}... Parabéns, show demais!!!");
